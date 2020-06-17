namespace printers_Stocktaking.View
{
    partial class CartrigesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.StateFilter = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ModelFilter = new System.Windows.Forms.ComboBox();
            this.SubmitFilterBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cartridgeTable = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moreInfo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.searchLine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReloadCartListBtn = new System.Windows.Forms.PictureBox();
            this.AddCartBtn = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartridgeTable)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadCartListBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCartBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 259F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SubmitFilterBtn, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(259, 546);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.StateFilter, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(259, 62);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Состояние";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StateFilter
            // 
            this.StateFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StateFilter.FormattingEnabled = true;
            this.StateFilter.Location = new System.Drawing.Point(0, 30);
            this.StateFilter.Margin = new System.Windows.Forms.Padding(0);
            this.StateFilter.Name = "StateFilter";
            this.StateFilter.Size = new System.Drawing.Size(259, 27);
            this.StateFilter.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ModelFilter, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(259, 62);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Модель";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelFilter
            // 
            this.ModelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelFilter.FormattingEnabled = true;
            this.ModelFilter.Location = new System.Drawing.Point(0, 30);
            this.ModelFilter.Margin = new System.Windows.Forms.Padding(0);
            this.ModelFilter.Name = "ModelFilter";
            this.ModelFilter.Size = new System.Drawing.Size(259, 27);
            this.ModelFilter.TabIndex = 1;
            // 
            // SubmitFilterBtn
            // 
            this.SubmitFilterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.SubmitFilterBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubmitFilterBtn.Location = new System.Drawing.Point(0, 124);
            this.SubmitFilterBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SubmitFilterBtn.Name = "SubmitFilterBtn";
            this.SubmitFilterBtn.Size = new System.Drawing.Size(259, 49);
            this.SubmitFilterBtn.TabIndex = 2;
            this.SubmitFilterBtn.Text = "Применить";
            this.SubmitFilterBtn.UseVisualStyleBackColor = false;
            this.SubmitFilterBtn.Click += new System.EventHandler(this.SubmitFilterBtn_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.cartridgeTable, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(271, 4);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 421F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(792, 546);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // cartridgeTable
            // 
            this.cartridgeTable.AllowUserToAddRows = false;
            this.cartridgeTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartridgeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cartridgeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartridgeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.invNumCol,
            this.modelCol,
            this.stateCol,
            this.moreInfo});
            this.cartridgeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartridgeTable.Location = new System.Drawing.Point(4, 90);
            this.cartridgeTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cartridgeTable.Name = "cartridgeTable";
            this.cartridgeTable.ReadOnly = true;
            this.cartridgeTable.RowHeadersVisible = false;
            this.cartridgeTable.RowHeadersWidth = 51;
            this.cartridgeTable.Size = new System.Drawing.Size(784, 452);
            this.cartridgeTable.TabIndex = 7;
            this.cartridgeTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartridgeTable_CellContentClick);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.MinimumWidth = 6;
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            this.idCol.Width = 125;
            // 
            // invNumCol
            // 
            this.invNumCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.invNumCol.FillWeight = 40F;
            this.invNumCol.HeaderText = "Инвентаризационный номер";
            this.invNumCol.MinimumWidth = 6;
            this.invNumCol.Name = "invNumCol";
            this.invNumCol.ReadOnly = true;
            // 
            // modelCol
            // 
            this.modelCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modelCol.FillWeight = 20F;
            this.modelCol.HeaderText = "Модель";
            this.modelCol.MinimumWidth = 6;
            this.modelCol.Name = "modelCol";
            this.modelCol.ReadOnly = true;
            // 
            // stateCol
            // 
            this.stateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stateCol.FillWeight = 20F;
            this.stateCol.HeaderText = "Состояние";
            this.stateCol.MinimumWidth = 6;
            this.stateCol.Name = "stateCol";
            this.stateCol.ReadOnly = true;
            // 
            // moreInfo
            // 
            this.moreInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.moreInfo.DefaultCellStyle = dataGridViewCellStyle4;
            this.moreInfo.FillWeight = 20F;
            this.moreInfo.HeaderText = "";
            this.moreInfo.MinimumWidth = 6;
            this.moreInfo.Name = "moreInfo";
            this.moreInfo.ReadOnly = true;
            this.moreInfo.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.tableLayoutPanel7.Controls.Add(this.SearchBtn, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.searchLine, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(792, 39);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchBtn.Location = new System.Drawing.Point(561, 4);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(133, 30);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Найти";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // searchLine
            // 
            this.searchLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLine.Location = new System.Drawing.Point(327, 6);
            this.searchLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchLine.Name = "searchLine";
            this.searchLine.Size = new System.Drawing.Size(227, 26);
            this.searchLine.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск по инвентаризационному номеру";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ReloadCartListBtn);
            this.panel1.Controls.Add(this.AddCartBtn);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 47);
            this.panel1.TabIndex = 6;
            // 
            // ReloadCartListBtn
            // 
            this.ReloadCartListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ReloadCartListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReloadCartListBtn.Image = global::printers_Stocktaking.Properties.Resources.updateBtn;
            this.ReloadCartListBtn.Location = new System.Drawing.Point(57, 4);
            this.ReloadCartListBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReloadCartListBtn.Name = "ReloadCartListBtn";
            this.ReloadCartListBtn.Size = new System.Drawing.Size(43, 39);
            this.ReloadCartListBtn.TabIndex = 0;
            this.ReloadCartListBtn.TabStop = false;
            this.ReloadCartListBtn.Click += new System.EventHandler(this.ReloadCartListBtn_Click);
            // 
            // AddCartBtn
            // 
            this.AddCartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AddCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCartBtn.Image = global::printers_Stocktaking.Properties.Resources.addBtn;
            this.AddCartBtn.Location = new System.Drawing.Point(7, 4);
            this.AddCartBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCartBtn.Name = "AddCartBtn";
            this.AddCartBtn.Size = new System.Drawing.Size(43, 39);
            this.AddCartBtn.TabIndex = 0;
            this.AddCartBtn.TabStop = false;
            this.AddCartBtn.Click += new System.EventHandler(this.AddCartBtn_Click);
            // 
            // CartrigesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CartrigesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Картриджи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CartrigesForm_FormClosed);
            this.Load += new System.EventHandler(this.CartrigesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartridgeTable)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReloadCartListBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCartBtn)).EndInit();
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
        private System.Windows.Forms.Button SubmitFilterBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataGridView cartridgeTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox searchLine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ReloadCartListBtn;
        private System.Windows.Forms.PictureBox AddCartBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn invNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateCol;
        private System.Windows.Forms.DataGridViewLinkColumn moreInfo;
    }
}