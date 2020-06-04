namespace printers_Stocktaking.View
{
    partial class DepartmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Departments = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.depTree = new System.Windows.Forms.TreeView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.subDep = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.AcceptDepBtn = new System.Windows.Forms.Button();
            this.CancelDepBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.newDepName = new System.Windows.Forms.TextBox();
            this.AddDepBtn = new System.Windows.Forms.Button();
            this.childDepTable = new System.Windows.Forms.DataGridView();
            this.depIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chDepCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.delDepCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Cabinets = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.AcceptCabBtn = new System.Windows.Forms.Button();
            this.CancelCabBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddCabBtn = new System.Windows.Forms.Button();
            this.cabNun = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cabIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chCabCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.delCabCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Buildings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.AcceptBuildBtn = new System.Windows.Forms.Button();
            this.CancelBuildBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.AddBuildBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newBuilding = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newShortName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buildIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bShortNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chBuildCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.delBuildCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabControl1.SuspendLayout();
            this.Departments.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.subDep.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childDepTable)).BeginInit();
            this.Cabinets.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Buildings.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Departments);
            this.tabControl1.Controls.Add(this.Buildings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // Departments
            // 
            this.Departments.Controls.Add(this.tableLayoutPanel1);
            this.Departments.Location = new System.Drawing.Point(4, 24);
            this.Departments.Name = "Departments";
            this.Departments.Padding = new System.Windows.Forms.Padding(3);
            this.Departments.Size = new System.Drawing.Size(767, 408);
            this.Departments.TabIndex = 0;
            this.Departments.Text = "Подразделения";
            this.Departments.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.tableLayoutPanel1.Controls.Add(this.depTree, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 402);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // depTree
            // 
            this.depTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depTree.Location = new System.Drawing.Point(2, 2);
            this.depTree.Margin = new System.Windows.Forms.Padding(2);
            this.depTree.Name = "depTree";
            this.depTree.Size = new System.Drawing.Size(229, 398);
            this.depTree.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.subDep);
            this.tabControl2.Controls.Add(this.Cabinets);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(233, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(528, 402);
            this.tabControl2.TabIndex = 1;
            // 
            // subDep
            // 
            this.subDep.Controls.Add(this.tableLayoutPanel2);
            this.subDep.Location = new System.Drawing.Point(4, 24);
            this.subDep.Margin = new System.Windows.Forms.Padding(0);
            this.subDep.Name = "subDep";
            this.subDep.Size = new System.Drawing.Size(520, 374);
            this.subDep.TabIndex = 0;
            this.subDep.Text = "Дочерние подразделения";
            this.subDep.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.childDepTable, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 374);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.AcceptDepBtn, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.CancelDepBtn, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 325);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(516, 47);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // AcceptDepBtn
            // 
            this.AcceptDepBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptDepBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.AcceptDepBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptDepBtn.Location = new System.Drawing.Point(344, 3);
            this.AcceptDepBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AcceptDepBtn.Name = "AcceptDepBtn";
            this.AcceptDepBtn.Size = new System.Drawing.Size(172, 40);
            this.AcceptDepBtn.TabIndex = 0;
            this.AcceptDepBtn.Text = "Принять";
            this.AcceptDepBtn.UseVisualStyleBackColor = false;
            // 
            // CancelDepBtn
            // 
            this.CancelDepBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelDepBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.CancelDepBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDepBtn.Location = new System.Drawing.Point(172, 3);
            this.CancelDepBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CancelDepBtn.Name = "CancelDepBtn";
            this.CancelDepBtn.Size = new System.Drawing.Size(172, 40);
            this.CancelDepBtn.TabIndex = 0;
            this.CancelDepBtn.Text = "Отмена";
            this.CancelDepBtn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.newDepName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.AddDepBtn, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(520, 58);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новое дочернее подразделение";
            // 
            // newDepName
            // 
            this.newDepName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newDepName.Location = new System.Drawing.Point(151, 18);
            this.newDepName.Margin = new System.Windows.Forms.Padding(2);
            this.newDepName.Name = "newDepName";
            this.newDepName.Size = new System.Drawing.Size(263, 22);
            this.newDepName.TabIndex = 1;
            // 
            // AddDepBtn
            // 
            this.AddDepBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDepBtn.Location = new System.Drawing.Point(418, 13);
            this.AddDepBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddDepBtn.Name = "AddDepBtn";
            this.AddDepBtn.Size = new System.Drawing.Size(100, 32);
            this.AddDepBtn.TabIndex = 2;
            this.AddDepBtn.Text = "Добавить";
            this.AddDepBtn.UseVisualStyleBackColor = true;
            // 
            // childDepTable
            // 
            this.childDepTable.AllowUserToAddRows = false;
            this.childDepTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.childDepTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.childDepTable.ColumnHeadersHeight = 29;
            this.childDepTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depIDCol,
            this.depNameCol,
            this.chDepCol,
            this.delDepCol});
            this.childDepTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childDepTable.Location = new System.Drawing.Point(2, 60);
            this.childDepTable.Margin = new System.Windows.Forms.Padding(2);
            this.childDepTable.Name = "childDepTable";
            this.childDepTable.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.childDepTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.childDepTable.RowHeadersWidth = 51;
            this.childDepTable.RowTemplate.Height = 24;
            this.childDepTable.Size = new System.Drawing.Size(516, 261);
            this.childDepTable.TabIndex = 1;
            // 
            // depIDCol
            // 
            this.depIDCol.HeaderText = "ID";
            this.depIDCol.MinimumWidth = 6;
            this.depIDCol.Name = "depIDCol";
            this.depIDCol.ReadOnly = true;
            this.depIDCol.Visible = false;
            this.depIDCol.Width = 125;
            // 
            // depNameCol
            // 
            this.depNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.depNameCol.FillWeight = 70F;
            this.depNameCol.HeaderText = "Название";
            this.depNameCol.MinimumWidth = 6;
            this.depNameCol.Name = "depNameCol";
            this.depNameCol.ReadOnly = true;
            // 
            // chDepCol
            // 
            this.chDepCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chDepCol.FillWeight = 15F;
            this.chDepCol.HeaderText = "";
            this.chDepCol.MinimumWidth = 6;
            this.chDepCol.Name = "chDepCol";
            this.chDepCol.ReadOnly = true;
            // 
            // delDepCol
            // 
            this.delDepCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.delDepCol.FillWeight = 15F;
            this.delDepCol.HeaderText = "";
            this.delDepCol.MinimumWidth = 6;
            this.delDepCol.Name = "delDepCol";
            this.delDepCol.ReadOnly = true;
            // 
            // Cabinets
            // 
            this.Cabinets.Controls.Add(this.tableLayoutPanel8);
            this.Cabinets.Location = new System.Drawing.Point(4, 24);
            this.Cabinets.Name = "Cabinets";
            this.Cabinets.Padding = new System.Windows.Forms.Padding(3);
            this.Cabinets.Size = new System.Drawing.Size(520, 374);
            this.Cabinets.TabIndex = 1;
            this.Cabinets.Text = "Кабинеты";
            this.Cabinets.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.423913F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.3587F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(514, 368);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Controls.Add(this.AcceptCabBtn, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.CancelCabBtn, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(2, 314);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(510, 52);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // AcceptCabBtn
            // 
            this.AcceptCabBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptCabBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.AcceptCabBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptCabBtn.Location = new System.Drawing.Point(340, 6);
            this.AcceptCabBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AcceptCabBtn.Name = "AcceptCabBtn";
            this.AcceptCabBtn.Size = new System.Drawing.Size(170, 40);
            this.AcceptCabBtn.TabIndex = 0;
            this.AcceptCabBtn.Text = "Принять";
            this.AcceptCabBtn.UseVisualStyleBackColor = false;
            // 
            // CancelCabBtn
            // 
            this.CancelCabBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelCabBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.CancelCabBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelCabBtn.Location = new System.Drawing.Point(170, 6);
            this.CancelCabBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CancelCabBtn.Name = "CancelCabBtn";
            this.CancelCabBtn.Size = new System.Drawing.Size(170, 40);
            this.CancelCabBtn.TabIndex = 0;
            this.CancelCabBtn.Text = "Отмена";
            this.CancelCabBtn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 5;
            this.tableLayoutPanel8.SetColumnSpan(this.tableLayoutPanel10, 5);
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel10.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.AddCabBtn, 4, 0);
            this.tableLayoutPanel10.Controls.Add(this.cabNun, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(514, 31);
            this.tableLayoutPanel10.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Корпус";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Кабинет";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddCabBtn
            // 
            this.AddCabBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCabBtn.Location = new System.Drawing.Point(412, 3);
            this.AddCabBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddCabBtn.Name = "AddCabBtn";
            this.AddCabBtn.Size = new System.Drawing.Size(100, 24);
            this.AddCabBtn.TabIndex = 3;
            this.AddCabBtn.Text = "Добавить";
            this.AddCabBtn.UseVisualStyleBackColor = true;
            // 
            // cabNun
            // 
            this.cabNun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cabNun.Location = new System.Drawing.Point(333, 4);
            this.cabNun.Name = "cabNun";
            this.cabNun.Size = new System.Drawing.Size(74, 22);
            this.cabNun.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cabIDCol,
            this.buildNameCol,
            this.cabNumCol,
            this.chCabCol,
            this.delCabCol});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(508, 275);
            this.dataGridView2.TabIndex = 5;
            // 
            // cabIDCol
            // 
            this.cabIDCol.HeaderText = "ID";
            this.cabIDCol.Name = "cabIDCol";
            this.cabIDCol.ReadOnly = true;
            this.cabIDCol.Visible = false;
            // 
            // buildNameCol
            // 
            this.buildNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buildNameCol.FillWeight = 40F;
            this.buildNameCol.HeaderText = "Корпус";
            this.buildNameCol.Name = "buildNameCol";
            this.buildNameCol.ReadOnly = true;
            // 
            // cabNumCol
            // 
            this.cabNumCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cabNumCol.FillWeight = 30F;
            this.cabNumCol.HeaderText = "Номер кабинета";
            this.cabNumCol.Name = "cabNumCol";
            this.cabNumCol.ReadOnly = true;
            // 
            // chCabCol
            // 
            this.chCabCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.chCabCol.DefaultCellStyle = dataGridViewCellStyle12;
            this.chCabCol.FillWeight = 15F;
            this.chCabCol.HeaderText = "";
            this.chCabCol.Name = "chCabCol";
            this.chCabCol.ReadOnly = true;
            this.chCabCol.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // delCabCol
            // 
            this.delCabCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.delCabCol.DefaultCellStyle = dataGridViewCellStyle13;
            this.delCabCol.FillWeight = 15F;
            this.delCabCol.HeaderText = "";
            this.delCabCol.Name = "delCabCol";
            this.delCabCol.ReadOnly = true;
            this.delCabCol.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // Buildings
            // 
            this.Buildings.Controls.Add(this.tableLayoutPanel5);
            this.Buildings.Location = new System.Drawing.Point(4, 24);
            this.Buildings.Name = "Buildings";
            this.Buildings.Padding = new System.Windows.Forms.Padding(3);
            this.Buildings.Size = new System.Drawing.Size(767, 408);
            this.Buildings.TabIndex = 1;
            this.Buildings.Text = "Корпуса";
            this.Buildings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(761, 402);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Controls.Add(this.AcceptBuildBtn, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.CancelBuildBtn, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 352);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(757, 48);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // AcceptBuildBtn
            // 
            this.AcceptBuildBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptBuildBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.AcceptBuildBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptBuildBtn.Location = new System.Drawing.Point(605, 4);
            this.AcceptBuildBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AcceptBuildBtn.Name = "AcceptBuildBtn";
            this.AcceptBuildBtn.Size = new System.Drawing.Size(152, 40);
            this.AcceptBuildBtn.TabIndex = 0;
            this.AcceptBuildBtn.Text = "Принять";
            this.AcceptBuildBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBuildBtn
            // 
            this.CancelBuildBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBuildBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.CancelBuildBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBuildBtn.Location = new System.Drawing.Point(454, 4);
            this.CancelBuildBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CancelBuildBtn.Name = "CancelBuildBtn";
            this.CancelBuildBtn.Size = new System.Drawing.Size(151, 40);
            this.CancelBuildBtn.TabIndex = 0;
            this.CancelBuildBtn.Text = "Отмена";
            this.CancelBuildBtn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 5;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel7.Controls.Add(this.AddBuildBtn, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.newBuilding, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.newShortName, 3, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(755, 44);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // AddBuildBtn
            // 
            this.AddBuildBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddBuildBtn.Location = new System.Drawing.Point(537, 6);
            this.AddBuildBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBuildBtn.Name = "AddBuildBtn";
            this.AddBuildBtn.Size = new System.Drawing.Size(100, 32);
            this.AddBuildBtn.TabIndex = 4;
            this.AddBuildBtn.Text = "Добавить";
            this.AddBuildBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Новый корпус";
            // 
            // newBuilding
            // 
            this.newBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newBuilding.Location = new System.Drawing.Point(103, 11);
            this.newBuilding.Name = "newBuilding";
            this.newBuilding.Size = new System.Drawing.Size(194, 22);
            this.newBuilding.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Краткое обозначение";
            // 
            // newShortName
            // 
            this.newShortName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newShortName.Location = new System.Drawing.Point(438, 11);
            this.newShortName.Name = "newShortName";
            this.newShortName.Size = new System.Drawing.Size(94, 22);
            this.newShortName.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildIDCol,
            this.bNameCol,
            this.bShortNameCol,
            this.chBuildCol,
            this.delBuildCol});
            this.dataGridView1.Location = new System.Drawing.Point(3, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(755, 294);
            this.dataGridView1.TabIndex = 5;
            // 
            // buildIDCol
            // 
            this.buildIDCol.HeaderText = "";
            this.buildIDCol.Name = "buildIDCol";
            this.buildIDCol.ReadOnly = true;
            this.buildIDCol.Visible = false;
            // 
            // bNameCol
            // 
            this.bNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bNameCol.FillWeight = 40F;
            this.bNameCol.HeaderText = "Название корпуса";
            this.bNameCol.Name = "bNameCol";
            this.bNameCol.ReadOnly = true;
            // 
            // bShortNameCol
            // 
            this.bShortNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bShortNameCol.FillWeight = 20F;
            this.bShortNameCol.HeaderText = "Краткое обозначание";
            this.bShortNameCol.Name = "bShortNameCol";
            this.bShortNameCol.ReadOnly = true;
            // 
            // chBuildCol
            // 
            this.chBuildCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.chBuildCol.DefaultCellStyle = dataGridViewCellStyle15;
            this.chBuildCol.FillWeight = 15F;
            this.chBuildCol.HeaderText = "";
            this.chBuildCol.Name = "chBuildCol";
            this.chBuildCol.ReadOnly = true;
            this.chBuildCol.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // delBuildCol
            // 
            this.delBuildCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.delBuildCol.DefaultCellStyle = dataGridViewCellStyle16;
            this.delBuildCol.FillWeight = 15F;
            this.delBuildCol.HeaderText = "";
            this.delBuildCol.Name = "delBuildCol";
            this.delBuildCol.ReadOnly = true;
            this.delBuildCol.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 436);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Структура оргнаизации";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.Departments.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.subDep.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childDepTable)).EndInit();
            this.Cabinets.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Buildings.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Departments;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView depTree;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage subDep;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button AcceptDepBtn;
        private System.Windows.Forms.Button CancelDepBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newDepName;
        private System.Windows.Forms.Button AddDepBtn;
        private System.Windows.Forms.DataGridView childDepTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn depIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn depNameCol;
        private System.Windows.Forms.DataGridViewLinkColumn chDepCol;
        private System.Windows.Forms.DataGridViewLinkColumn delDepCol;
        private System.Windows.Forms.TabPage Cabinets;
        private System.Windows.Forms.TabPage Buildings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button AcceptBuildBtn;
        private System.Windows.Forms.Button CancelBuildBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newBuilding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newShortName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button AcceptCabBtn;
        private System.Windows.Forms.Button CancelCabBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddCabBtn;
        private System.Windows.Forms.TextBox cabNun;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabNumCol;
        private System.Windows.Forms.DataGridViewLinkColumn chCabCol;
        private System.Windows.Forms.DataGridViewLinkColumn delCabCol;
        private System.Windows.Forms.Button AddBuildBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn bShortNameCol;
        private System.Windows.Forms.DataGridViewLinkColumn chBuildCol;
        private System.Windows.Forms.DataGridViewLinkColumn delBuildCol;
    }
}