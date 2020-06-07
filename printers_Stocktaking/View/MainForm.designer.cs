namespace printers_Stocktaking
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PrintersBTN = new System.Windows.Forms.Button();
            this.OrgStructBTN = new System.Windows.Forms.Button();
            this.CartridgeBTN = new System.Windows.Forms.Button();
            this.UsingMatBTN = new System.Windows.Forms.Button();
            this.PrintingVolumeBTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 355F));
            this.tableLayoutPanel1.Controls.Add(this.Settings, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Settings
            // 
            this.Settings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Image = global::printers_Stocktaking.Properties.Resources.settingsBtn;
            this.Settings.Location = new System.Drawing.Point(321, 0);
            this.Settings.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(32, 32);
            this.Settings.TabIndex = 0;
            this.Settings.TabStop = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.PrintersBTN, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.OrgStructBTN, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.CartridgeBTN, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.UsingMatBTN, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PrintingVolumeBTN, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 34);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(351, 291);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // PrintersBTN
            // 
            this.PrintersBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintersBTN.Location = new System.Drawing.Point(24, 8);
            this.PrintersBTN.Margin = new System.Windows.Forms.Padding(2);
            this.PrintersBTN.Name = "PrintersBTN";
            this.PrintersBTN.Size = new System.Drawing.Size(126, 81);
            this.PrintersBTN.TabIndex = 1;
            this.PrintersBTN.Text = "Печатные устройства";
            this.PrintersBTN.UseVisualStyleBackColor = true;
            this.PrintersBTN.Click += new System.EventHandler(this.PrintersBTN_Click);
            // 
            // OrgStructBTN
            // 
            this.OrgStructBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrgStructBTN.Location = new System.Drawing.Point(200, 105);
            this.OrgStructBTN.Margin = new System.Windows.Forms.Padding(2);
            this.OrgStructBTN.Name = "OrgStructBTN";
            this.OrgStructBTN.Size = new System.Drawing.Size(126, 81);
            this.OrgStructBTN.TabIndex = 1;
            this.OrgStructBTN.Text = "Структура организации";
            this.OrgStructBTN.UseVisualStyleBackColor = true;
            this.OrgStructBTN.Click += new System.EventHandler(this.OrgStructBTN_Click);
            // 
            // CartridgeBTN
            // 
            this.CartridgeBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CartridgeBTN.Location = new System.Drawing.Point(200, 8);
            this.CartridgeBTN.Margin = new System.Windows.Forms.Padding(2);
            this.CartridgeBTN.Name = "CartridgeBTN";
            this.CartridgeBTN.Size = new System.Drawing.Size(126, 81);
            this.CartridgeBTN.TabIndex = 1;
            this.CartridgeBTN.Text = "Картриджи";
            this.CartridgeBTN.UseVisualStyleBackColor = true;
            this.CartridgeBTN.Click += new System.EventHandler(this.CartridgeBTN_Click);
            // 
            // UsingMatBTN
            // 
            this.UsingMatBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsingMatBTN.Location = new System.Drawing.Point(24, 105);
            this.UsingMatBTN.Margin = new System.Windows.Forms.Padding(2);
            this.UsingMatBTN.Name = "UsingMatBTN";
            this.UsingMatBTN.Size = new System.Drawing.Size(126, 81);
            this.UsingMatBTN.TabIndex = 1;
            this.UsingMatBTN.Text = "Расходные материалы";
            this.UsingMatBTN.UseVisualStyleBackColor = true;
            this.UsingMatBTN.Click += new System.EventHandler(this.UsingMatBTN_Click);
            // 
            // PrintingVolumeBTN
            // 
            this.PrintingVolumeBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintingVolumeBTN.Location = new System.Drawing.Point(24, 202);
            this.PrintingVolumeBTN.Margin = new System.Windows.Forms.Padding(2);
            this.PrintingVolumeBTN.Name = "PrintingVolumeBTN";
            this.PrintingVolumeBTN.Size = new System.Drawing.Size(126, 81);
            this.PrintingVolumeBTN.TabIndex = 1;
            this.PrintingVolumeBTN.Text = "Объемы печати";
            this.PrintingVolumeBTN.UseVisualStyleBackColor = true;
            this.PrintingVolumeBTN.Click += new System.EventHandler(this.PrintingVolumeBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 327);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет принтеров в организации";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button PrintersBTN;
        private System.Windows.Forms.Button OrgStructBTN;
        private System.Windows.Forms.Button CartridgeBTN;
        private System.Windows.Forms.Button UsingMatBTN;
        private System.Windows.Forms.Button PrintingVolumeBTN;
    }
}

