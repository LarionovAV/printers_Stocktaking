namespace printers_Stocktaking.View
{
    partial class CartridgeHistoryForm
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
            this.historyTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CabCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedMat = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyTable
            // 
            this.historyTable.AllowUserToAddRows = false;
            this.historyTable.AllowUserToDeleteRows = false;
            this.historyTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.historyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.CabCol,
            this.StartDate,
            this.EndDate,
            this.StateCol,
            this.UsedMat});
            this.historyTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyTable.Location = new System.Drawing.Point(0, 0);
            this.historyTable.Name = "historyTable";
            this.historyTable.ReadOnly = true;
            this.historyTable.RowHeadersVisible = false;
            this.historyTable.Size = new System.Drawing.Size(540, 450);
            this.historyTable.TabIndex = 1;
            this.historyTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyTable_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.historyTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 450);
            this.panel1.TabIndex = 2;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID записи";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            // 
            // CabCol
            // 
            this.CabCol.FillWeight = 29F;
            this.CabCol.HeaderText = "Местоположение";
            this.CabCol.Name = "CabCol";
            this.CabCol.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.FillWeight = 15F;
            this.StartDate.HeaderText = "Дата с";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.FillWeight = 16F;
            this.EndDate.HeaderText = "Дата по";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // StateCol
            // 
            this.StateCol.FillWeight = 20F;
            this.StateCol.HeaderText = "Статус";
            this.StateCol.Name = "StateCol";
            this.StateCol.ReadOnly = true;
            // 
            // UsedMat
            // 
            this.UsedMat.FillWeight = 20F;
            this.UsedMat.HeaderText = "Затраты";
            this.UsedMat.Name = "UsedMat";
            this.UsedMat.ReadOnly = true;
            this.UsedMat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UsedMat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CartridgeHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CartridgeHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "История картриджа";
            this.Load += new System.EventHandler(this.CartridgeHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historyTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CabCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateCol;
        private System.Windows.Forms.DataGridViewLinkColumn UsedMat;
    }
}