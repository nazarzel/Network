namespace IPAddressProject
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.tbIPDNSAddress = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(268, 35);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetInfo.TabIndex = 0;
            this.btnGetInfo.Text = "Get Info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnIPAddressGetInfo_Click);
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(21, 18);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(134, 13);
            this.lblIPAddress.TabIndex = 2;
            this.lblIPAddress.Text = "IP address / DNS address:";
            // 
            // tbIPDNSAddress
            // 
            this.tbIPDNSAddress.Location = new System.Drawing.Point(21, 37);
            this.tbIPDNSAddress.Name = "tbIPDNSAddress";
            this.tbIPDNSAddress.Size = new System.Drawing.Size(241, 20);
            this.tbIPDNSAddress.TabIndex = 5;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.tbInfo);
            this.gbInfo.Location = new System.Drawing.Point(21, 74);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(322, 324);
            this.gbInfo.TabIndex = 11;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info:";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(15, 19);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(294, 290);
            this.tbInfo.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 412);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.tbIPDNSAddress);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.btnGetInfo);
            this.Name = "MainForm";
            this.Text = "IP/DNS";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.TextBox tbIPDNSAddress;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox tbInfo;
    }
}

