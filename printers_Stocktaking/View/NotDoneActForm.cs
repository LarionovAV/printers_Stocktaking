using Npgsql;
using printers_Stocktaking.Model;
using System;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace printers_Stocktaking.View
{
    public partial class NotDoneActForm : Form
    {
        Color add;
        Color upd;
        Color del;

        int ActID;
        decimal totalSum = 0;

        public NotDoneActForm()
        {
            InitializeComponent();

            CommonElements.InitMaterials();
            MatCol.DataSource = CommonElements.Materials;
            MatCol.DisplayMember = "Name";
            MatCol.ValueMember = "ID";

            CommonElements.actions.TryGetValue("add", out add);
            CommonElements.actions.TryGetValue("del", out del);
            CommonElements.actions.TryGetValue("upd", out upd);
        }
        public NotDoneActForm(int actID) : this()
        {
            ActID = actID;

            string sql = "SELECT * from \"Buy_act_row\" WHERE \"act_ID\" = " + ActID;
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader) {
                matList.Rows.Add(
                    record[0],
                    "",
                    record.GetInt32(3),
                    record.GetInt32(1),
                    CommonElements.Measures
                                .First(meas => meas.ID
                                        == CommonElements.Materials
                                            .First(mat => mat.ID
                                                == record.GetInt32(3)).Measure).ShortName,
                    record.GetDecimal(2));

                totalSum += record.GetDecimal(2);
            }
            reader.Close();

            total.Text = totalSum.ToString();
        }

        private void NotDoneActForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((sender as DataGridView).Rows[e.RowIndex].Cells[IDcol.Index].Value == null)
                {
                    (sender as DataGridView)[ActionCol.Index, e.RowIndex].Style.BackColor = add;
                }
                else if ((sender as DataGridView)[ActionCol.Index, e.RowIndex].Style.BackColor != add)
                {
                    (sender as DataGridView)[ActionCol.Index, e.RowIndex].Style.BackColor = upd;
                }

                if (e.ColumnIndex == MatCol.Index)
                {
                    if ((int)(sender as DataGridView)[MatCol.Index, e.RowIndex].Value == -1)
                    {
                        new NewMaterialForm().ShowDialog();
                        CommonElements.InitMaterials();
                    }
                    else
                    {
                        (sender as DataGridView)[measureCol.Index, e.RowIndex].Value =
                            CommonElements.Measures
                                .First(meas => meas.ID
                                        == CommonElements.Materials
                                            .First(mat => mat.ID
                                                == (int)(sender as DataGridView)[MatCol.Index, e.RowIndex].Value).Measure).ShortName;
                    }
                }

                if ((sender as DataGridView)[quantityCol.Index, e.RowIndex].Value == null ||
                            Convert.ToInt32((sender as DataGridView)[quantityCol.Index, e.RowIndex].Value) < 0)
                    (sender as DataGridView)[quantityCol.Index, e.RowIndex].Value = 0;

                if ((sender as DataGridView)[totalCol.Index, e.RowIndex].Value == null ||
                        Convert.ToDouble((sender as DataGridView)[totalCol.Index, e.RowIndex].Value) < 0)
                {
                    (sender as DataGridView)[totalCol.Index, e.RowIndex].Value = 0;
                }
                if (e.ColumnIndex == totalCol.Index)
                    RecountTotal();
            }
        }

        private void RecountTotal() {
            totalSum = 0;
            for (int i = 0; i < matList.Rows.Count - 1; i++) {
                totalSum += Convert.ToDecimal(matList[totalCol.Index, i].Value);
            }
            total.Text = totalSum.ToString();
        }
        private void AcceptBtn_Click(object sender, System.EventArgs e)
        {
            CommitChanges();
        }

        private void matList_SelectionChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedCells.Count > 0 &&
                (sender as DataGridView).SelectedCells[0].ColumnIndex == ActionCol.Index)
                (sender as DataGridView).ClearSelection();
        }

        private void matList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == ActionCol.Index)
            {
                if ((sender as DataGridView)[ActionCol.Index, e.RowIndex].Style.BackColor != add)
                {
                    (sender as DataGridView)[ActionCol.Index, e.RowIndex].Style.BackColor = del;
                }
                else
                {
                    (sender as DataGridView).Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            CommitChanges();
            string sql;
            for ( int i = 0; i < matList.Rows.Count -1; i ++) {
                sql = "Update \"Material\" " +
                    "SET \"available\" = \"available\" + " + matList[quantityCol.Index, i].Value +
                    " WHERE \"material_ID\" = " + matList[MatCol.Index, i].Value;
                new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
            }

            sql = "Update \"Buy_act\" " +
                    "SET \"buy_date\" = current_date " +
                    "WHERE \"act_ID\" = " + ActID;

            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

        private void matList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RecountTotal();
        }

        private void CommitChanges()
        {
            for (int i = 0; i < matList.Rows.Count - 1; i++)
            {
                if (matList[ActionCol.Index, i].Style.BackColor == add)
                {
                    string sql = "Insert into \"Buy_act_row\"(\"quantity\", \"total_cost\", \"material_ID\", \"act_ID\") " +
                        "VALUES(" +
                        matList[quantityCol.Index, i].Value + ", " + matList[totalCol.Index, i].Value + ", " +
                        matList[MatCol.Index, i].Value + ", " + ActID + ") returning \"actString_ID\"";
                    NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
                    reader.Read();
                    matList[IDcol.Index, i].Value = reader[0];
                    reader.Close();

                    matList[ActionCol.Index, i].Style.BackColor = matList.DefaultCellStyle.BackColor;
                }
                else if (matList[ActionCol.Index, i].Style.BackColor == upd)
                {
                    string sql = "UPDATE \"Buy_act_row\" " +
                        "SET \"quantity\" = " + matList[quantityCol.Index, i].Value + ", " +
                        "\"total_cost\" = " + matList[totalCol.Index, i].Value + ", " +
                        "\"material_ID\" = " + matList[MatCol.Index, i].Value + ", " +
                        "\"act_ID\" = " + ActID +
                        "WHERE \"actString_ID\" = " + matList[IDcol.Index, i].Value;
                    new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();

                    matList[ActionCol.Index, i].Style.BackColor = matList.DefaultCellStyle.BackColor;
                }
                else if (matList[ActionCol.Index, i].Style.BackColor == del)
                {
                    string sql = "DELETE FROM \"Buy_act_row\" " +
                        "WHERE \"actString_ID\" = " + matList[IDcol.Index, i].Value;
                    new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();

                    matList.Rows.RemoveAt(i);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string sql = "Delete From \"Buy_act\" WHERE \"act_ID\" = " + ActID;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
            Close();
        }
    }
}
