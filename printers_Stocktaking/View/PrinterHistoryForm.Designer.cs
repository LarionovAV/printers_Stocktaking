namespace printers_Stocktaking.View
{
    partial class PrinterHistoryForm
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
            this.hisTab = new System.Windows.Forms.DataGridView();
            this.CabCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.hisTab)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hisTab
            // 
            this.hisTab.AllowUserToAddRows = false;
            this.hisTab.AllowUserToDeleteRows = false;
            this.hisTab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hisTab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.hisTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hisTab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CabCol,
            this.DepCol,
            this.StartDate,
            this.EndDate,
            this.StateCol});
            this.hisTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hisTab.Location = new System.Drawing.Point(0, 0);
            this.hisTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hisTab.Name = "hisTab";
            this.hisTab.ReadOnly = true;
            this.hisTab.RowHeadersVisible = false;
            this.hisTab.RowHeadersWidth = 51;
            this.hisTab.Size = new System.Drawing.Size(777, 401);
            this.hisTab.TabIndex = 0;
            // 
            // CabCol
            // 
            this.CabCol.FillWeight = 10F;
            this.CabCol.HeaderText = "Кабинет";
            this.CabCol.MinimumWidth = 6;
            this.CabCol.Name = "CabCol";
            this.CabCol.ReadOnly = true;
            // 
            // DepCol
            // 
            this.DepCol.FillWeight = 40F;
            this.DepCol.HeaderText = "Подразделение";
            this.DepCol.MinimumWidth = 6;
            this.DepCol.Name = "DepCol";
            this.DepCol.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.FillWeight = 15F;
            this.StartDate.HeaderText = "Дата с";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.FillWeight = 15F;
            this.EndDate.HeaderText = "Дата по";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // StateCol
            // 
            this.StateCol.FillWeight = 20F;
            this.StateCol.HeaderText = "Статус";
            this.StateCol.MinimumWidth = 6;
            this.StateCol.Name = "StateCol";
            this.StateCol.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hisTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 401);
            this.panel1.TabIndex = 1;
            // 
            // PrinterHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 401);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrinterHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "История принтера";
            this.Load += new System.EventHandler(this.PrinterHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hisTab)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView hisTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn CabCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateCol;
        private System.Windows.Forms.Panel panel1;
    }
}