using Npgsql;
using printers_Stocktaking.Model;
using System;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class DepartmentForm : Form
    {
        Color add;
        Color del;
        Color upd;
        
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            depTree.Nodes.Clear();
            Application.OpenForms["MainForm"].Show();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            CommonElements.actions.TryGetValue("add", out add);
            CommonElements.actions.TryGetValue("upd", out upd);
            CommonElements.actions.TryGetValue("del", out del);

            depTree.Nodes.Add(CommonElements.DepTreeRoot);
            depTree.SelectedNode = depTree.Nodes[0];

            foreach (Building build in CommonElements.Buildings)
            {
                buildingsTable.Rows.Add(build.ID, "", build.Name, build.ShortName);
            }

            buildNameCol.DataSource = CommonElements.Buildings;
            buildNameCol.DisplayMember = "Name";
            buildNameCol.ValueMember = "ID";
        }


        private void childDepTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((sender as DataGridView).Rows[e.RowIndex].Cells[depIDCol.Index].Value == null)
                {
                    (sender as DataGridView).Rows[e.RowIndex].Cells["depAction"].Style.BackColor = add;
                }
                else if ((sender as DataGridView).Rows[e.RowIndex].Cells["depAction"].Style.BackColor != add) {
                    (sender as DataGridView).Rows[e.RowIndex].Cells["depAction"].Style.BackColor = upd;
                }
            }
        }
        private void AcceptDepBtn_Click(object sender, EventArgs e)
        {
            string sql;

            for (int i = childDepTable.Rows.Count - 2; i >= 0; i--) {
                if (childDepTable.Rows[i].Cells[depAction.Index].Style.BackColor == del)
                {
                    // Т.к запись будет удалена не имеет смысла передавать реальные название и ИД родителя
                    Department dep = new Department(
                        Convert.ToInt32(childDepTable.Rows[i].Cells[depIDCol.Index].Value),
                        "",
                        "");
                    dep.Delete();
                
                    depTree.Nodes.Remove(
                        depTree.Nodes.Find(dep.ID.ToString(), true)[0]);

                    childDepTable.Rows.RemoveAt(i);
                }
                else if (childDepTable.Rows[i].Cells[depAction.Index].Style.BackColor == add) {
                    if (childDepTable.Rows[i].Cells[depNameCol.Index].Value == null ||
                        childDepTable.Rows[i].Cells[depNameCol.Index].Value.ToString() == "") {
                        MessageBox.Show(
                            "Все поля должны быть заполнены.\n Строка " + (i + 1),
                            "Предупреждение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        continue;
                    }

                    Department dep = new Department(
                        childDepTable.Rows[i].Cells[depNameCol.Index].Value.ToString(),
                        depTree.SelectedNode.Name);
                    dep.Create();
                    childDepTable.Rows[i].Cells[depIDCol.Index].Value = dep.ID;

                    childDepTable.Rows[i].Cells[depAction.Index].Style.BackColor = childDepTable.DefaultCellStyle.BackColor;

                    depTree.SelectedNode.Nodes.Add(
                        dep.ID.ToString(),
                        dep.Name);
                }
                else if (childDepTable.Rows[i].Cells[depAction.Index].Style.BackColor == upd)
                {
                    if (childDepTable.Rows[i].Cells[depNameCol.Index].Value == null ||
                        childDepTable.Rows[i].Cells[depNameCol.Index].Value.ToString().Trim() == "")
                    {
                        MessageBox.Show(
                            "Все поля должны быть заполнены.\n Строка " + (i + 1),
                            "Предупреждение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        continue;
                    }

                    Department dep = new Department(
                        Convert.ToInt32(childDepTable.Rows[i].Cells[depIDCol.Index].Value),
                        childDepTable.Rows[i].Cells[depNameCol.Index].Value.ToString(),
                        depTree.SelectedNode.Name);
                    dep.Update();
                    childDepTable.Rows[i].Cells[depAction.Index].Style.BackColor = childDepTable.DefaultCellStyle.BackColor;

                    depTree.Nodes.Find(childDepTable.Rows[i].Cells[depIDCol.Index].Value.ToString(), true)[0].Text 
                        = dep.Name;
                }
            }
        }
        private void CancelDepBtn_Click(object sender, EventArgs e)
        {
            string sql;

            for (int i = childDepTable.Rows.Count - 1; i >= 0; i--)
            { 
                if (childDepTable.Rows[i].Cells[depAction.Index].Style.BackColor == add)
                {
                    childDepTable.Rows.RemoveAt(i);
                }
                else if (childDepTable.Rows[i].Cells[depAction.Index].Style.BackColor == upd ||
                    childDepTable.Rows[i].Cells[depAction.Index].Style.BackColor == del)
                {
                    Department dep = new Department();
                    dep.Find(Convert.ToInt32(childDepTable.Rows[i].Cells[depIDCol.Index].Value));

                    childDepTable.Rows[i].Cells["depNameCol"].Value = dep.Name;
                    childDepTable.Rows[i].Cells["depAction"].Style.BackColor = childDepTable.DefaultCellStyle.BackColor;
                }
            }
        }
        private void childDepTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == depAction.Index)
            {
                if ((sender as DataGridView).Rows[e.RowIndex].Cells["depAction"].Style.BackColor != add)
                {
                    (sender as DataGridView).Rows[e.RowIndex].Cells["depAction"].Style.BackColor = del;
                }
                else {
                    (sender as DataGridView).Rows.RemoveAt(e.RowIndex);
                }
            }
        }
        private void childDepTable_SelectionChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedCells.Count > 0 &&
                (sender as DataGridView).SelectedCells[0].ColumnIndex == depAction.Index)
                (sender as DataGridView).ClearSelection();
        }

    
        
        private void depTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            childDepTable.Rows.Clear();
            string sql =
                "SELECT \"dep_ID\", \"name\" FROM \"Department\" " +
                "WHERE \"parent_dep_ID\" " +
                (depTree.SelectedNode.Name == "NULL" ? "is null" : ("= " + depTree.SelectedNode.Name)) + 
                " ORDER BY \"name\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                childDepTable.Rows.Add(record.GetInt32(0), "", record.GetString(1));
            }
            reader.Close();

            cabinetsTable.Rows.Clear();
            sql =
                "SELECT \"cabinet_ID\", \"building_ID\", \"number\" FROM \"Cabinet\" " +
                "WHERE \"dep_ID\" " +
                (depTree.SelectedNode.Name == "NULL" ? "is null" : ("= " + depTree.SelectedNode.Name));
            reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                cabinetsTable.Rows.Add(record.GetInt32(0), "", record.GetInt32(1), record.GetString(2));
            }
            reader.Close();
        }



        private void buildingsTable_SelectionChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedCells.Count > 0 &&
               (sender as DataGridView).SelectedCells[0].ColumnIndex == buildAction.Index)
                (sender as DataGridView).ClearSelection();
        }
        private void buildingsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == buildAction.Index)
            {
                if ((sender as DataGridView).Rows[e.RowIndex].Cells["buildAction"].Style.BackColor != add)
                {
                    (sender as DataGridView).Rows[e.RowIndex].Cells["buildAction"].Style.BackColor = del;
                }
                else
                {
                    (sender as DataGridView).Rows.RemoveAt(e.RowIndex);
                }
            }
        }
        private void buildingsTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((sender as DataGridView).Rows[e.RowIndex].Cells[buildIDCol.Index].Value == null)
                {
                    (sender as DataGridView).Rows[e.RowIndex].Cells["buildAction"].Style.BackColor = add;
                }
                else if ((sender as DataGridView).Rows[e.RowIndex].Cells["buildAction"].Style.BackColor != add)
                {
                    (sender as DataGridView).Rows[e.RowIndex].Cells["buildAction"].Style.BackColor = upd;
                }
            }
        }
        private void AcceptBuildBtn_Click(object sender, EventArgs e)
        {
            string sql;

            for (int i = buildingsTable.Rows.Count - 2; i >= 0; i--)
            {
                if (buildingsTable.Rows[i].Cells[buildAction.Index].Style.BackColor == del)
                {
                    Building build = CommonElements.Buildings.First(b => b.ID == (int)buildingsTable[buildIDCol.Index, i].Value);
                    build.Delete();

                    CommonElements.Buildings.Remove(build);

                    buildingsTable.Rows.RemoveAt(i);
                }
                else if (buildingsTable.Rows[i].Cells[buildAction.Index].Style.BackColor == add)
                {
                    if (buildingsTable.Rows[i].Cells[bNameCol.Index].Value == null ||
                        buildingsTable.Rows[i].Cells[bShortNameCol.Index].Value == null ||
                        buildingsTable.Rows[i].Cells[bNameCol.Index].Value.ToString().Trim() == "" ||
                        buildingsTable.Rows[i].Cells[bShortNameCol.Index].Value.ToString().Trim() == "") { 
                        MessageBox.Show(
                            "Все поля должны быть заполнены.\n Строка " + (i+1), 
                            "Предупреждение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        continue;
                    }

                    Building build = new Building(
                        buildingsTable[bNameCol.Index, i].Value.ToString(),
                        buildingsTable[bShortNameCol.Index, i].Value.ToString());
                    build.Create();
                    buildingsTable.Rows[i].Cells[buildIDCol.Index].Value = build.ID;

                    buildingsTable.Rows[i].Cells[buildAction.Index].Style.BackColor = buildingsTable.DefaultCellStyle.BackColor;

                    CommonElements.Buildings.Add(build);
                }
                else if (buildingsTable.Rows[i].Cells[buildAction.Index].Style.BackColor == upd)
                {
                    if (buildingsTable.Rows[i].Cells[bNameCol.Index].Value == null ||
                        buildingsTable.Rows[i].Cells[bShortNameCol.Index].Value == null ||
                        buildingsTable.Rows[i].Cells[bNameCol.Index].Value.ToString().Trim() == "" ||
                        buildingsTable.Rows[i].Cells[bShortNameCol.Index].Value.ToString().Trim() == "")
                    {
                        MessageBox.Show(
                            "Все поля должны быть заполнены.\n Строка " + (i + 1),
                            "Предупреждение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        continue;
                    }

                    Building changed = 
                        CommonElements.Buildings.First(b => b.ID == (int)buildingsTable[buildIDCol.Index, i].Value);
                    changed.Name = buildingsTable[bNameCol.Index, i].Value.ToString();
                    changed.ShortName = buildingsTable[bShortNameCol.Index, i].Value.ToString();
                    changed.Update();

                    buildingsTable.Rows[i].Cells[buildAction.Index].Style.BackColor = buildingsTable.DefaultCellStyle.BackColor;
                }
            }
        }
        private void CancelBuildBtn_Click(object sender, EventArgs e)
        {
            for (int i = buildingsTable.Rows.Count - 2; i >= 0; i--) {
                if (buildingsTable.Rows[i].Cells[buildAction.Index].Style.BackColor == add)
                {
                    buildingsTable.Rows.RemoveAt(i);
                }
                else if (buildingsTable.Rows[i].Cells[buildAction.Index].Style.BackColor == upd ||
                    buildingsTable.Rows[i].Cells[buildAction.Index].Style.BackColor == del) {
                    string sql =
                        "SELECT \"name\", \"short_name\" FROM \"Building\"" +
                        " WHERE \"building_ID\" = " + buildingsTable.Rows[i].Cells[buildIDCol.Index].Value;
                    NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
                    reader.Read();
                    buildingsTable.Rows[i].Cells[bNameCol.Index].Value = reader.GetString(0);
                    buildingsTable.Rows[i].Cells[bShortNameCol.Index].Value = reader.GetString(1);
                    reader.Close();

                    buildingsTable.Rows[i].Cells[buildAction.Index].Style.BackColor = buildingsTable.DefaultCellStyle.BackColor;
                }
            }
        }


        private void cabinetsTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                if ((sender as DataGridView).Rows[e.RowIndex].Cells[cabIDCol.Index].Value == null) {
                    (sender as DataGridView).Rows[e.RowIndex].Cells[cabAction.Index].Style.BackColor = add;
                }
                else
                {
                    (sender as DataGridView).Rows[e.RowIndex].Cells[cabAction.Index].Style.BackColor = upd;
                }
            }
        }
        private void cabinetsTable_SelectionChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedCells.Count > 0 &&
               (sender as DataGridView).SelectedCells[0].ColumnIndex == cabAction.Index)
                (sender as DataGridView).ClearSelection();
        }
        private void cabinetsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cabAction.Index) {
                if ((sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != add)
                {
                    (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = del;
                }
                else
                {
                    (sender as DataGridView).Rows.RemoveAt(e.RowIndex);
                }
            }
        }
        private void AcceptCabBtn_Click(object sender, EventArgs e)
        {
            string sql;
            for (int i = cabinetsTable.Rows.Count - 2; i >= 0; i--) {
                if (cabinetsTable.Rows[i].Cells[cabAction.Index].Style.BackColor == add)
                {
                    if (cabinetsTable.Rows[i].Cells[buildNameCol.Index].Value == null ||
                        cabinetsTable.Rows[i].Cells[cabNumCol.Index].Value == null ||
                        cabinetsTable.Rows[i].Cells[cabNumCol.Index].Value.ToString().Trim() == "")
                    {
                        MessageBox.Show(
                            "Все поля должны быть заполнены.\n Строка " + (i + 1),
                            "Предупреждение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        continue;
                    }


                    sql =
                        "SELECT * " +
                        "FROM \"Cabinet\"" +
                        "WHERE \"building_ID\" = " + cabinetsTable.Rows[i].Cells[buildNameCol.Index].Value +
                        " and \"number\" = '" + cabinetsTable.Rows[i].Cells[cabNumCol.Index].Value.ToString() + "'";
                    NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
                    if (reader.HasRows) {
                        reader.Read();
                        if (reader["dep_ID"] == DBNull.Value || MessageBox.Show(
                            "Кабинет " + reader["number"].ToString() + " " + CommonElements.Buildings.First(b => b.ID == Convert.ToInt32(reader["building_ID"])).ShortName +
                            " уже приписан подразделению \"" + depTree.Nodes.Find(reader["dep_ID"].ToString(), true)[0].Text + "\"\n Переписать?",
                            "Предупреждение",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                            ) == DialogResult.Yes) {
                            cabinetsTable.Rows[i].Cells[cabIDCol.Index].Value = reader["cabinet_ID"];
                            sql =
                                "UPDATE \"Cabinet\" SET \"dep_ID\" = " + depTree.SelectedNode.Name + 
                                " WHERE \"cabinet_ID\" = " + reader["cabinet_ID"];
                            reader.Close();
                            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();

                            cabinetsTable.Rows[i].Cells[cabAction.Index].Style.BackColor = cabinetsTable.DefaultCellStyle.BackColor;
                        }
                    }
                    else {
                        reader.Close();

                        sql =
                            "INSERT INTO \"Cabinet\"(\"building_ID\", \"number\", \"dep_ID\") " +
                            "VALUES(" + cabinetsTable.Rows[i].Cells[buildNameCol.Index].Value + ", '" +
                            cabinetsTable.Rows[i].Cells[cabNumCol.Index].Value + "', " + depTree.SelectedNode.Name + ") returning \"cabinet_ID\"";
                        reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
                        reader.Read();
                        cabinetsTable.Rows[i].Cells[cabIDCol.Index].Value = reader.GetInt32(0);
                        reader.Close();

                        cabinetsTable.Rows[i].Cells[cabAction.Index].Style.BackColor = cabinetsTable.DefaultCellStyle.BackColor;
                    }

                }
                else if (cabinetsTable.Rows[i].Cells[cabAction.Index].Style.BackColor == del)
                {
                    sql =
                        "UPDATE \"Cabinet\" SET \"dep_ID\" = null"  +
                        " WHERE \"cabinet_ID\" = " + cabinetsTable[cabIDCol.Index, i].Value;
                    new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
                    cabinetsTable.Rows.RemoveAt(i);

                }
                else if (cabinetsTable.Rows[i].Cells[cabAction.Index].Style.BackColor == upd) {
                    MessageBox.Show("Редактирование не возможно...\n", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void CancelCabBtn_Click(object sender, EventArgs e)
        {
            for (int i = cabinetsTable.Rows.Count - 2; i >= 0; i--) {
                if (cabinetsTable[cabAction.Index, i].Style.BackColor == add) {
                    cabinetsTable.Rows.RemoveAt(i);
                }
                else if (cabinetsTable[cabAction.Index, i].Style.BackColor == del ||
                    cabinetsTable[cabAction.Index, i].Style.BackColor == upd)
                {
                    string sql = "SELECT \"building_ID\", \"number\" " +
                        "FROM \"Cabinet\" " +
                        "WHERE \"cabinet_ID\" = " + cabinetsTable[cabIDCol.Index, i].Value;
                    NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
                    reader.Read();
                    cabinetsTable[cabNumCol.Index, i].Value = reader[1];
                    cabinetsTable[buildNameCol.Index, i].Value = reader[0];
                    reader.Close();

                    cabinetsTable[cabAction.Index, i].Style.BackColor = cabinetsTable.DefaultCellStyle.BackColor;
                }
            }
        }
    }
}
