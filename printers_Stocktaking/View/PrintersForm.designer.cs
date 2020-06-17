namespace printers_Stocktaking.View
{
    partial class PrintersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.StateFilter = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ModelFilter = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CreatorFilter = new System.Windows.Forms.ComboBox();
            this.SubmitFilterBtn = new System.Windows.Forms.Button();
            this.depTree = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.printersTable = new System.Windows.Forms.DataGridView();
            this.printID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moreInfo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.searchMethod = new System.Windows.Forms.ComboBox();
            this.searchParam = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reloadListBtn = new System.Windows.Forms.PictureBox();
            this.addPrinterBtn = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printersTable)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadListBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPrinterBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 626F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.SubmitFilterBtn, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.depTree, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.StateFilter, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 350);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(194, 50);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Состояние";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StateFilter
            // 
            this.StateFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StateFilter.FormattingEnabled = true;
            this.StateFilter.Location = new System.Drawing.Point(0, 23);
            this.StateFilter.Margin = new System.Windows.Forms.Padding(0);
            this.StateFilter.Name = "StateFilter";
            this.StateFilter.Size = new System.Drawing.Size(194, 23);
            this.StateFilter.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ModelFilter, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 300);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 50);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Модель";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelFilter
            // 
            this.ModelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelFilter.FormattingEnabled = true;
            this.ModelFilter.Location = new System.Drawing.Point(0, 23);
            this.ModelFilter.Margin = new System.Windows.Forms.Padding(0);
            this.ModelFilter.Name = "ModelFilter";
            this.ModelFilter.Size = new System.Drawing.Size(194, 23);
            this.ModelFilter.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CreatorFilter, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 250);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(194, 50);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreatorFilter
            // 
            this.CreatorFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatorFilter.FormattingEnabled = true;
            this.CreatorFilter.Location = new System.Drawing.Point(0, 23);
            this.CreatorFilter.Margin = new System.Windows.Forms.Padding(0);
            this.CreatorFilter.Name = "CreatorFilter";
            this.CreatorFilter.Size = new System.Drawing.Size(194, 23);
            this.CreatorFilter.TabIndex = 1;
            this.CreatorFilter.SelectedIndexChanged += new System.EventHandler(this.CreatorFilter_SelectedIndexChanged);
            // 
            // SubmitFilterBtn
            // 
            this.SubmitFilterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(251)))));
            this.SubmitFilterBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubmitFilterBtn.Location = new System.Drawing.Point(0, 400);
            this.SubmitFilterBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SubmitFilterBtn.Name = "SubmitFilterBtn";
            this.SubmitFilterBtn.Size = new System.Drawing.Size(194, 44);
            this.SubmitFilterBtn.TabIndex = 2;
            this.SubmitFilterBtn.Text = "Применить";
            this.SubmitFilterBtn.UseVisualStyleBackColor = false;
            this.SubmitFilterBtn.Click += new System.EventHandler(this.SubmitFilterBtn_Click);
            // 
            // depTree
            // 
            this.depTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depTree.HideSelection = false;
            this.depTree.Location = new System.Drawing.Point(3, 3);
            this.depTree.Name = "depTree";
            this.depTree.Size = new System.Drawing.Size(188, 244);
            this.depTree.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.printersTable, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(200, 3);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(626, 444);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // printersTable
            // 
            this.printersTable.AllowUserToAddRows = false;
            this.printersTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.printersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.printersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.printID,
            this.buildName,
            this.cabNum,
            this.State,
            this.moreInfo});
            this.printersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printersTable.Location = new System.Drawing.Point(3, 73);
            this.printersTable.Name = "printersTable";
            this.printersTable.ReadOnly = true;
            this.printersTable.RowHeadersVisible = false;
            this.printersTable.RowHeadersWidth = 51;
            this.printersTable.Size = new System.Drawing.Size(620, 368);
            this.printersTable.TabIndex = 7;
            this.printersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.printersTable_CellContentClick);
            // 
            // printID
            // 
            this.printID.HeaderText = "ID";
            this.printID.MinimumWidth = 6;
            this.printID.Name = "printID";
            this.printID.ReadOnly = true;
            this.printID.Visible = false;
            this.printID.Width = 125;
            // 
            // buildName
            // 
            this.buildName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buildName.FillWeight = 35F;
            this.buildName.HeaderText = "Инвентаризационный номер";
            this.buildName.MinimumWidth = 6;
            this.buildName.Name = "buildName";
            this.buildName.ReadOnly = true;
            // 
            // cabNum
            // 
            this.cabNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cabNum.FillWeight = 35F;
            this.cabNum.HeaderText = "Место установки";
            this.cabNum.MinimumWidth = 6;
            this.cabNum.Name = "cabNum";
            this.cabNum.ReadOnly = true;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.State.FillWeight = 15F;
            this.State.HeaderText = "Состояние";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // moreInfo
            // 
            this.moreInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.moreInfo.DefaultCellStyle = dataGridViewCellStyle8;
            this.moreInfo.FillWeight = 15F;
            this.moreInfo.HeaderText = "";
            this.moreInfo.MinimumWidth = 6;
            this.moreInfo.Name = "moreInfo";
            this.moreInfo.ReadOnly = true;
            this.moreInfo.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel7.Controls.Add(this.button6, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.searchMethod, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.searchParam, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(626, 32);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button6.Location = new System.Drawing.Point(474, 4);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 24);
            this.button6.TabIndex = 4;
            this.button6.Text = "Найти";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // searchMethod
            // 
            this.searchMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchMethod.FormattingEnabled = true;
            this.searchMethod.Location = new System.Drawing.Point(3, 4);
            this.searchMethod.Name = "searchMethod";
            this.searchMethod.Size = new System.Drawing.Size(270, 23);
            this.searchMethod.TabIndex = 0;
            // 
            // searchParam
            // 
            this.searchParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParam.Location = new System.Drawing.Point(279, 5);
            this.searchParam.Name = "searchParam";
            this.searchParam.Size = new System.Drawing.Size(190, 22);
            this.searchParam.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reloadListBtn);
            this.panel1.Controls.Add(this.addPrinterBtn);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 38);
            this.panel1.TabIndex = 6;
            // 
            // reloadListBtn
            // 
            this.reloadListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reloadListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadListBtn.Image = global::printers_Stocktaking.Properties.Resources.updateBtn;
            this.reloadListBtn.Location = new System.Drawing.Point(43, 3);
            this.reloadListBtn.Name = "reloadListBtn";
            this.reloadListBtn.Size = new System.Drawing.Size(32, 32);
            this.reloadListBtn.TabIndex = 0;
            this.reloadListBtn.TabStop = false;
            this.reloadListBtn.Click += new System.EventHandler(this.reloadListBtn_Click);
            // 
            // addPrinterBtn
            // 
            this.addPrinterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addPrinterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPrinterBtn.Image = global::printers_Stocktaking.Properties.Resources.addBtn;
            this.addPrinterBtn.Location = new System.Drawing.Point(5, 3);
            this.addPrinterBtn.Name = "addPrinterBtn";
            this.addPrinterBtn.Size = new System.Drawing.Size(32, 32);
            this.addPrinterBtn.TabIndex = 0;
            this.addPrinterBtn.TabStop = false;
            this.addPrinterBtn.Click += new System.EventHandler(this.addPrinterBtn_Click);
            // 
            // PrintersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrintersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Принтеры";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrintersForm_FormClosed);
            this.Load += new System.EventHandler(this.PrintersForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.printersTable)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reloadListBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPrinterBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StateFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ModelFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CreatorFilter;
        private System.Windows.Forms.Button SubmitFilterBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.ComboBox searchMethod;
        private System.Windows.Forms.TextBox searchParam;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox reloadListBtn;
        private System.Windows.Forms.PictureBox addPrinterBtn;
        private System.Windows.Forms.DataGridView printersTable;
        private System.Windows.Forms.TreeView depTree;
        private System.Windows.Forms.DataGridViewTextBoxColumn printID;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewLinkColumn moreInfo;
    }
}