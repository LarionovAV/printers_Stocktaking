namespace printers_Stocktaking.View
{
    partial class CompatibilitiesForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.compTable = new System.Windows.Forms.DataGridView();
            this.model = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDepBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.creator = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compTable)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.compTable, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(519, 384);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // compTable
            // 
            this.compTable.AllowUserToAddRows = false;
            this.compTable.AllowUserToDeleteRows = false;
            this.compTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.compTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.compTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.creatorCol,
            this.modelCol,
            this.delCol});
            this.compTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compTable.Location = new System.Drawing.Point(4, 66);
            this.compTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.compTable.Name = "compTable";
            this.compTable.ReadOnly = true;
            this.compTable.RowHeadersVisible = false;
            this.compTable.RowHeadersWidth = 51;
            this.compTable.Size = new System.Drawing.Size(511, 314);
            this.compTable.TabIndex = 1;
            this.compTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.compTable_CellContentClick);
            // 
            // model
            // 
            this.model.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(201, 31);
            this.model.Margin = new System.Windows.Forms.Padding(4);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(203, 27);
            this.model.TabIndex = 1;
            this.model.SelectedIndexChanged += new System.EventHandler(this.model_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модель принтера";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка принтера";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddDepBtn
            // 
            this.AddDepBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDepBtn.Location = new System.Drawing.Point(411, 11);
            this.AddDepBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddDepBtn.Name = "AddDepBtn";
            this.tableLayoutPanel2.SetRowSpan(this.AddDepBtn, 2);
            this.AddDepBtn.Size = new System.Drawing.Size(105, 39);
            this.AddDepBtn.TabIndex = 3;
            this.AddDepBtn.Text = "Добавить";
            this.AddDepBtn.UseVisualStyleBackColor = true;
            this.AddDepBtn.Click += new System.EventHandler(this.AddDepBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel2.Controls.Add(this.AddDepBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.creator, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.model, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(519, 62);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // creator
            // 
            this.creator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.creator.FormattingEnabled = true;
            this.creator.Location = new System.Drawing.Point(4, 30);
            this.creator.Margin = new System.Windows.Forms.Padding(4);
            this.creator.Name = "creator";
            this.creator.Size = new System.Drawing.Size(189, 27);
            this.creator.TabIndex = 1;
            this.creator.SelectedIndexChanged += new System.EventHandler(this.creator_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // creatorCol
            // 
            this.creatorCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.creatorCol.FillWeight = 40F;
            this.creatorCol.HeaderText = "Марка принтера";
            this.creatorCol.MinimumWidth = 6;
            this.creatorCol.Name = "creatorCol";
            this.creatorCol.ReadOnly = true;
            // 
            // modelCol
            // 
            this.modelCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modelCol.FillWeight = 40F;
            this.modelCol.HeaderText = "Модель";
            this.modelCol.MinimumWidth = 6;
            this.modelCol.Name = "modelCol";
            this.modelCol.ReadOnly = true;
            // 
            // delCol
            // 
            this.delCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.delCol.FillWeight = 20F;
            this.delCol.HeaderText = "";
            this.delCol.MinimumWidth = 6;
            this.delCol.Name = "delCol";
            this.delCol.ReadOnly = true;
            this.delCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delCol.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // CompatibilitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 384);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompatibilitiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Совместимость";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compTable)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView compTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AddDepBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox creator;
        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelCol;
        private System.Windows.Forms.DataGridViewLinkColumn delCol;
    }
}