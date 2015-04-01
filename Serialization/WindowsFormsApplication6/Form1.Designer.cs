namespace WindowsFormsApplication6
{
    partial class Form1
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
            this.tbx_Data = new System.Windows.Forms.TextBox();
            this.rb_Xml = new System.Windows.Forms.RadioButton();
            this.rb_Json = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_Data
            // 
            this.tbx_Data.Location = new System.Drawing.Point(122, 12);
            this.tbx_Data.Multiline = true;
            this.tbx_Data.Name = "tbx_Data";
            this.tbx_Data.Size = new System.Drawing.Size(480, 237);
            this.tbx_Data.TabIndex = 0;
            // 
            // rb_Xml
            // 
            this.rb_Xml.AutoSize = true;
            this.rb_Xml.Location = new System.Drawing.Point(6, 42);
            this.rb_Xml.Name = "rb_Xml";
            this.rb_Xml.Size = new System.Drawing.Size(47, 17);
            this.rb_Xml.TabIndex = 1;
            this.rb_Xml.TabStop = true;
            this.rb_Xml.Text = "XML";
            this.rb_Xml.UseVisualStyleBackColor = true;
            this.rb_Xml.CheckedChanged += new System.EventHandler(this.rb_Xml_CheckedChanged);
            // 
            // rb_Json
            // 
            this.rb_Json.AutoSize = true;
            this.rb_Json.Location = new System.Drawing.Point(6, 19);
            this.rb_Json.Name = "rb_Json";
            this.rb_Json.Size = new System.Drawing.Size(47, 17);
            this.rb_Json.TabIndex = 2;
            this.rb_Json.TabStop = true;
            this.rb_Json.Text = "Json";
            this.rb_Json.UseVisualStyleBackColor = true;
            this.rb_Json.CheckedChanged += new System.EventHandler(this.rb_Json_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 197);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Serialize";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(12, 226);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(104, 23);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "Deserialize";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Json);
            this.groupBox1.Controls.Add(this.rb_Xml);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 179);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XML ot Json";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbx_Data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Data;
        private System.Windows.Forms.RadioButton rb_Xml;
        private System.Windows.Forms.RadioButton rb_Json;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

