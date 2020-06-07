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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.childDepTable = new System.Windows.Forms.DataGridView();
            this.depIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cabinets = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.AcceptCabBtn = new System.Windows.Forms.Button();
            this.CancelCabBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cabIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildNameCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cabNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buildings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.AcceptBuildBtn = new System.Windows.Forms.Button();
            this.CancelBuildBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buildIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bShortNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Departments.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.subDep.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childDepTable)).BeginInit();
            this.Cabinets.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Buildings.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(611, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // Departments
            // 
            this.Departments.Controls.Add(this.tableLayoutPanel1);
            this.Departments.Location = new System.Drawing.Point(4, 24);
            this.Departments.Name = "Departments";
            this.Departments.Padding = new System.Windows.Forms.Padding(3);
            this.Departments.Size = new System.Drawing.Size(603, 410);
            this.Departments.TabIndex = 0;
            this.Departments.Text = "Подразделения";
            this.Departments.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel1.Controls.Add(this.depTree, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(597, 404);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // depTree
            // 
            this.depTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depTree.Location = new System.Drawing.Point(2, 2);
            this.depTree.Margin = new System.Windows.Forms.Padding(2);
            this.depTree.Name = "depTree";
            this.depTree.Size = new System.Drawing.Size(173, 400);
            this.depTree.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.subDep);
            this.tabControl2.Controls.Add(this.Cabinets);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(177, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(420, 404);
            this.tabControl2.TabIndex = 1;
            // 
            // subDep
            // 
            this.subDep.Controls.Add(this.tableLayoutPanel2);
            this.subDep.Location = new System.Drawing.Point(4, 24);
            this.subDep.Margin = new System.Windows.Forms.Padding(0);
            this.subDep.Name = "subDep";
            this.subDep.Size = new System.Drawing.Size(412, 376);
            this.subDep.TabIndex = 0;
            this.subDep.Text = "Дочерние подразделения";
            this.subDep.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.childDepTable, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 335F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(412, 376);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 337);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(408, 37);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // AcceptDepBtn
            // 
            this.AcceptDepBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptDepBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.AcceptDepBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptDepBtn.Location = new System.Drawing.Point(272, 1);
            this.AcceptDepBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AcceptDepBtn.Name = "AcceptDepBtn";
            this.AcceptDepBtn.Size = new System.Drawing.Size(136, 35);
            this.AcceptDepBtn.TabIndex = 0;
            this.AcceptDepBtn.Text = "Принять";
            this.AcceptDepBtn.UseVisualStyleBackColor = false;
            // 
            // CancelDepBtn
            // 
            this.CancelDepBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelDepBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.CancelDepBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDepBtn.Location = new System.Drawing.Point(136, 1);
            this.CancelDepBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CancelDepBtn.Name = "CancelDepBtn";
            this.CancelDepBtn.Size = new System.Drawing.Size(136, 35);
            this.CancelDepBtn.TabIndex = 0;
            this.CancelDepBtn.Text = "Отмена";
            this.CancelDepBtn.UseVisualStyleBackColor = false;
            // 
            // childDepTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.childDepTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.childDepTable.ColumnHeadersHeight = 29;
            this.childDepTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depIDCol,
            this.depNameCol});
            this.childDepTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childDepTable.Location = new System.Drawing.Point(2, 2);
            this.childDepTable.Margin = new System.Windows.Forms.Padding(2);
            this.childDepTable.Name = "childDepTable";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.childDepTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.childDepTable.RowHeadersWidth = 51;
            this.childDepTable.RowTemplate.Height = 24;
            this.childDepTable.Size = new System.Drawing.Size(408, 331);
            this.childDepTable.TabIndex = 1;
            // 
            // depIDCol
            // 
            this.depIDCol.HeaderText = "ID";
            this.depIDCol.MinimumWidth = 6;
            this.depIDCol.Name = "depIDCol";
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
            // 
            // Cabinets
            // 
            this.Cabinets.Controls.Add(this.tableLayoutPanel8);
            this.Cabinets.Location = new System.Drawing.Point(4, 24);
            this.Cabinets.Name = "Cabinets";
            this.Cabinets.Padding = new System.Windows.Forms.Padding(3);
            this.Cabinets.Size = new System.Drawing.Size(412, 376);
            this.Cabinets.TabIndex = 1;
            this.Cabinets.Text = "Кабинеты";
            this.Cabinets.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 406F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.56757F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43243F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(406, 370);
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
            this.tableLayoutPanel9.Location = new System.Drawing.Point(2, 326);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(402, 42);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // AcceptCabBtn
            // 
            this.AcceptCabBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptCabBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.AcceptCabBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptCabBtn.Location = new System.Drawing.Point(268, 1);
            this.AcceptCabBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AcceptCabBtn.Name = "AcceptCabBtn";
            this.AcceptCabBtn.Size = new System.Drawing.Size(134, 40);
            this.AcceptCabBtn.TabIndex = 0;
            this.AcceptCabBtn.Text = "Принять";
            this.AcceptCabBtn.UseVisualStyleBackColor = false;
            // 
            // CancelCabBtn
            // 
            this.CancelCabBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelCabBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.CancelCabBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelCabBtn.Location = new System.Drawing.Point(134, 1);
            this.CancelCabBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CancelCabBtn.Name = "CancelCabBtn";
            this.CancelCabBtn.Size = new System.Drawing.Size(134, 40);
            this.CancelCabBtn.TabIndex = 0;
            this.CancelCabBtn.Text = "Отмена";
            this.CancelCabBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cabIDCol,
            this.buildNameCol,
            this.cabNumCol});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(400, 318);
            this.dataGridView2.TabIndex = 5;
            // 
            // cabIDCol
            // 
            this.cabIDCol.HeaderText = "ID";
            this.cabIDCol.Name = "cabIDCol";
            this.cabIDCol.Visible = false;
            // 
            // buildNameCol
            // 
            this.buildNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buildNameCol.FillWeight = 60F;
            this.buildNameCol.HeaderText = "Корпус";
            this.buildNameCol.Name = "buildNameCol";
            this.buildNameCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.buildNameCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cabNumCol
            // 
            this.cabNumCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cabNumCol.FillWeight = 40F;
            this.cabNumCol.HeaderText = "Номер кабинета";
            this.cabNumCol.Name = "cabNumCol";
            // 
            // Buildings
            // 
            this.Buildings.Controls.Add(this.tableLayoutPanel5);
            this.Buildings.Location = new System.Drawing.Point(4, 24);
            this.Buildings.Name = "Buildings";
            this.Buildings.Padding = new System.Windows.Forms.Padding(3);
            this.Buildings.Size = new System.Drawing.Size(603, 410);
            this.Buildings.TabIndex = 1;
            this.Buildings.Text = "Корпуса";
            this.Buildings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 354F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(597, 404);
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
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 356);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(593, 46);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // AcceptBuildBtn
            // 
            this.AcceptBuildBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptBuildBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.AcceptBuildBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptBuildBtn.Location = new System.Drawing.Point(473, 3);
            this.AcceptBuildBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AcceptBuildBtn.Name = "AcceptBuildBtn";
            this.AcceptBuildBtn.Size = new System.Drawing.Size(120, 40);
            this.AcceptBuildBtn.TabIndex = 0;
            this.AcceptBuildBtn.Text = "Принять";
            this.AcceptBuildBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBuildBtn
            // 
            this.CancelBuildBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBuildBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.CancelBuildBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBuildBtn.Location = new System.Drawing.Point(355, 3);
            this.CancelBuildBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CancelBuildBtn.Name = "CancelBuildBtn";
            this.CancelBuildBtn.Size = new System.Drawing.Size(118, 40);
            this.CancelBuildBtn.TabIndex = 0;
            this.CancelBuildBtn.Text = "Отмена";
            this.CancelBuildBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildIDCol,
            this.bNameCol,
            this.bShortNameCol});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 348);
            this.dataGridView1.TabIndex = 5;
            // 
            // buildIDCol
            // 
            this.buildIDCol.HeaderText = "";
            this.buildIDCol.Name = "buildIDCol";
            this.buildIDCol.Visible = false;
            // 
            // bNameCol
            // 
            this.bNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bNameCol.FillWeight = 40F;
            this.bNameCol.HeaderText = "Название корпуса";
            this.bNameCol.Name = "bNameCol";
            // 
            // bShortNameCol
            // 
            this.bShortNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bShortNameCol.FillWeight = 20F;
            this.bShortNameCol.HeaderText = "Краткое обозначание";
            this.bShortNameCol.Name = "bShortNameCol";
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 438);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Структура оргнаизации";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentForm_FormClosed);
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Departments.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.subDep.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.childDepTable)).EndInit();
            this.Cabinets.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Buildings.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView childDepTable;
        private System.Windows.Forms.TabPage Cabinets;
        private System.Windows.Forms.TabPage Buildings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button AcceptBuildBtn;
        private System.Windows.Forms.Button CancelBuildBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button AcceptCabBtn;
        private System.Windows.Forms.Button CancelCabBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn depIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn depNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabIDCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn buildNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn bShortNameCol;
    }
}