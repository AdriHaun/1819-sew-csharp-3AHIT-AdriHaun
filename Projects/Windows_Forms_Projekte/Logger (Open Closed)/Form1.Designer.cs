namespace Logger
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSend = new System.Windows.Forms.Button();
            this.rdoFileLog = new System.Windows.Forms.RadioButton();
            this.rdoWindowLog = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lboWindowLog = new System.Windows.Forms.ListBox();
            this.txtMailText = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Text";
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(12, 127);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(462, 23);
            this.cmdSend.TabIndex = 2;
            this.cmdSend.Text = "Send";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // rdoFileLog
            // 
            this.rdoFileLog.AutoSize = true;
            this.rdoFileLog.Location = new System.Drawing.Point(6, 33);
            this.rdoFileLog.Name = "rdoFileLog";
            this.rdoFileLog.Size = new System.Drawing.Size(62, 17);
            this.rdoFileLog.TabIndex = 3;
            this.rdoFileLog.TabStop = true;
            this.rdoFileLog.Text = "File Log";
            this.rdoFileLog.UseVisualStyleBackColor = true;
            this.rdoFileLog.CheckedChanged += new System.EventHandler(this.rdoFileLog_CheckedChanged);
            // 
            // rdoWindowLog
            // 
            this.rdoWindowLog.AutoSize = true;
            this.rdoWindowLog.Location = new System.Drawing.Point(6, 56);
            this.rdoWindowLog.Name = "rdoWindowLog";
            this.rdoWindowLog.Size = new System.Drawing.Size(85, 17);
            this.rdoWindowLog.TabIndex = 4;
            this.rdoWindowLog.TabStop = true;
            this.rdoWindowLog.Text = "Window Log";
            this.rdoWindowLog.UseVisualStyleBackColor = true;
            this.rdoWindowLog.CheckedChanged += new System.EventHandler(this.rdoWindowLog_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFileLog);
            this.groupBox1.Controls.Add(this.rdoWindowLog);
            this.groupBox1.Location = new System.Drawing.Point(480, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 96);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Target";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Window Log";
            // 
            // lboWindowLog
            // 
            this.lboWindowLog.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboWindowLog.FormattingEnabled = true;
            this.lboWindowLog.ItemHeight = 14;
            this.lboWindowLog.Location = new System.Drawing.Point(12, 195);
            this.lboWindowLog.Name = "lboWindowLog";
            this.lboWindowLog.Size = new System.Drawing.Size(593, 214);
            this.lboWindowLog.TabIndex = 7;
            // 
            // txtMailText
            // 
            this.txtMailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMailText.Location = new System.Drawing.Point(12, 25);
            this.txtMailText.Name = "txtMailText";
            this.txtMailText.Size = new System.Drawing.Size(462, 96);
            this.txtMailText.TabIndex = 8;
            this.txtMailText.Text = "";
            this.txtMailText.TextChanged += new System.EventHandler(this.txtMailText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 437);
            this.Controls.Add(this.txtMailText);
            this.Controls.Add(this.lboWindowLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdSend);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Logger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.RadioButton rdoFileLog;
        private System.Windows.Forms.RadioButton rdoWindowLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboWindowLog;
        private System.Windows.Forms.RichTextBox txtMailText;
    }
}

