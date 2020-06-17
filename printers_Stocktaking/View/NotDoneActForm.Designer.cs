namespace printers_Stocktaking.View
{
    partial class NotDoneActForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.AddRequireBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.matList = new System.Windows.Forms.DataGridView();
            this.IDcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matList)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.matList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 346F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 420);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.AcceptBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.CancelBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.FinishBtn, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.AddRequireBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DeleteBtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 372);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(487, 46);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.AcceptBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AcceptBtn.Location = new System.Drawing.Point(291, 0);
            this.AcceptBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(97, 46);
            this.AcceptBtn.TabIndex = 0;
            this.AcceptBtn.Text = "Сохранить";
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelBtn.Location = new System.Drawing.Point(194, 0);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(97, 46);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // FinishBtn
            // 
            this.FinishBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(251)))));
            this.FinishBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.FinishBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinishBtn.Location = new System.Drawing.Point(388, 0);
            this.FinishBtn.Margin = new System.Windows.Forms.Padding(0);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(99, 46);
            this.FinishBtn.TabIndex = 5;
            this.FinishBtn.Text = "Завершить закупку";
            this.FinishBtn.UseVisualStyleBackColor = false;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // AddRequireBtn
            // 
            this.AddRequireBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(152)))));
            this.AddRequireBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddRequireBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddRequireBtn.Location = new System.Drawing.Point(97, 0);
            this.AddRequireBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddRequireBtn.Name = "AddRequireBtn";
            this.AddRequireBtn.Size = new System.Drawing.Size(97, 46);
            this.AddRequireBtn.TabIndex = 5;
            this.AddRequireBtn.Text = "Добавить требуемые";
            this.AddRequireBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteBtn.Location = new System.Drawing.Point(0, 0);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(97, 46);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // matList
            // 
            this.matList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.matList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcol,
            this.ActionCol,
            this.MatCol,
            this.quantityCol,
            this.measureCol,
            this.totalCol});
            this.matList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matList.Location = new System.Drawing.Point(3, 3);
            this.matList.Name = "matList";
            this.matList.RowHeadersVisible = false;
            this.matList.Size = new System.Drawing.Size(485, 340);
            this.matList.TabIndex = 0;
            this.matList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.matList_CellMouseDoubleClick);
            this.matList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.matList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.matList_RowsRemoved);
            this.matList.SelectionChanged += new System.EventHandler(this.matList_SelectionChanged);
            // 
            // IDcol
            // 
            this.IDcol.HeaderText = "ID";
            this.IDcol.Name = "IDcol";
            this.IDcol.Visible = false;
            // 
            // ActionCol
            // 
            this.ActionCol.FillWeight = 20.30457F;
            this.ActionCol.HeaderText = "";
            this.ActionCol.Name = "ActionCol";
            this.ActionCol.ReadOnly = true;
            // 
            // MatCol
            // 
            this.MatCol.FillWeight = 80.86295F;
            this.MatCol.HeaderText = "Материал";
            this.MatCol.Name = "MatCol";
            this.MatCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MatCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // quantityCol
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.quantityCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.quantityCol.FillWeight = 35.93909F;
            this.quantityCol.HeaderText = "Количество";
            this.quantityCol.Name = "quantityCol";
            // 
            // measureCol
            // 
            this.measureCol.FillWeight = 17.96954F;
            this.measureCol.HeaderText = "Ед. изм.";
            this.measureCol.Name = "measureCol";
            this.measureCol.ReadOnly = true;
            // 
            // totalCol
            // 
            dataGridViewCellStyle6.NullValue = null;
            this.totalCol.DefaultCellStyle = dataGridViewCellStyle6;
            this.totalCol.FillWeight = 44.92386F;
            this.totalCol.HeaderText = "Стоимость";
            this.totalCol.Name = "totalCol";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.78207F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.21792F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.total, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 346);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(491, 24);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Итого";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // total
            // 
            this.total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(380, 4);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(108, 15);
            this.total.TabIndex = 0;
            this.total.Text = "[Сумма]";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NotDoneActForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 420);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotDoneActForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Закупаемые материалы";
            this.Load += new System.EventHandler(this.NotDoneActForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matList)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView matList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Button AddRequireBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn MatCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCol;
    }
}