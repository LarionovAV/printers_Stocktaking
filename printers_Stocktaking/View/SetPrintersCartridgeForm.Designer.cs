namespace printers_Stocktaking.View
{
    partial class SetPrintersCartridgeForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SetCartridge = new System.Windows.Forms.RadioButton();
            this.TakeOffCartridge = new System.Windows.Forms.RadioButton();
            this.CartPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cartridgeInvNum = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CartPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 136);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.AcceptBtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.CancelBtn, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 82);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(341, 52);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.AcceptBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptBtn.Location = new System.Drawing.Point(226, 8);
            this.AcceptBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(115, 35);
            this.AcceptBtn.TabIndex = 0;
            this.AcceptBtn.Text = "Принять";
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(113, 8);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(113, 35);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SetCartridge);
            this.panel1.Controls.Add(this.TakeOffCartridge);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 40);
            this.panel1.TabIndex = 0;
            // 
            // SetCartridge
            // 
            this.SetCartridge.AutoSize = true;
            this.SetCartridge.Location = new System.Drawing.Point(131, 12);
            this.SetCartridge.Name = "SetCartridge";
            this.SetCartridge.Size = new System.Drawing.Size(143, 19);
            this.SetCartridge.TabIndex = 1;
            this.SetCartridge.TabStop = true;
            this.SetCartridge.Text = "Установить картридж";
            this.SetCartridge.UseVisualStyleBackColor = true;
            this.SetCartridge.CheckedChanged += new System.EventHandler(this.ChoiceCabinet_CheckedChanged);
            // 
            // TakeOffCartridge
            // 
            this.TakeOffCartridge.AutoSize = true;
            this.TakeOffCartridge.Checked = true;
            this.TakeOffCartridge.Location = new System.Drawing.Point(12, 12);
            this.TakeOffCartridge.Name = "TakeOffCartridge";
            this.TakeOffCartridge.Size = new System.Drawing.Size(113, 19);
            this.TakeOffCartridge.TabIndex = 0;
            this.TakeOffCartridge.TabStop = true;
            this.TakeOffCartridge.Text = "Снять картридж";
            this.TakeOffCartridge.UseVisualStyleBackColor = true;
            // 
            // CartPanel
            // 
            this.CartPanel.ColumnCount = 2;
            this.CartPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.CartPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.CartPanel.Controls.Add(this.label1, 0, 0);
            this.CartPanel.Controls.Add(this.cartridgeInvNum, 1, 0);
            this.CartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartPanel.Enabled = false;
            this.CartPanel.Location = new System.Drawing.Point(0, 40);
            this.CartPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.RowCount = 1;
            this.CartPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CartPanel.Size = new System.Drawing.Size(345, 40);
            this.CartPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите картридж";
            // 
            // cartridgeInvNum
            // 
            this.cartridgeInvNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cartridgeInvNum.FormattingEnabled = true;
            this.cartridgeInvNum.Location = new System.Drawing.Point(129, 9);
            this.cartridgeInvNum.Name = "cartridgeInvNum";
            this.cartridgeInvNum.Size = new System.Drawing.Size(213, 23);
            this.cartridgeInvNum.TabIndex = 1;
            // 
            // SetPrintersCartridgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 136);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetPrintersCartridgeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление картриджем принтера";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CartPanel.ResumeLayout(false);
            this.CartPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton SetCartridge;
        private System.Windows.Forms.RadioButton TakeOffCartridge;
        private System.Windows.Forms.TableLayoutPanel CartPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cartridgeInvNum;
    }
}