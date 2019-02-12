namespace DI_Logger
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
            this.rdoFile = new System.Windows.Forms.RadioButton();
            this.rdoWindow = new System.Windows.Forms.RadioButton();
            this.lbxWindow = new System.Windows.Forms.ListBox();
            this.txtMail = new System.Windows.Forms.RichTextBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblWindow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoFile
            // 
            this.rdoFile.AutoSize = true;
            this.rdoFile.Checked = true;
            this.rdoFile.Location = new System.Drawing.Point(18, 44);
            this.rdoFile.Name = "rdoFile";
            this.rdoFile.Size = new System.Drawing.Size(62, 17);
            this.rdoFile.TabIndex = 0;
            this.rdoFile.TabStop = true;
            this.rdoFile.Text = "File Log";
            this.rdoFile.UseVisualStyleBackColor = true;
            // 
            // rdoWindow
            // 
            this.rdoWindow.AutoSize = true;
            this.rdoWindow.Location = new System.Drawing.Point(18, 77);
            this.rdoWindow.Name = "rdoWindow";
            this.rdoWindow.Size = new System.Drawing.Size(85, 17);
            this.rdoWindow.TabIndex = 1;
            this.rdoWindow.Text = "Window Log";
            this.rdoWindow.UseVisualStyleBackColor = true;
            // 
            // lbxWindow
            // 
            this.lbxWindow.FormattingEnabled = true;
            this.lbxWindow.Location = new System.Drawing.Point(12, 207);
            this.lbxWindow.Name = "lbxWindow";
            this.lbxWindow.Size = new System.Drawing.Size(334, 173);
            this.lbxWindow.TabIndex = 2;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(12, 36);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(190, 71);
            this.txtMail.TabIndex = 3;
            this.txtMail.Text = "";
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(12, 113);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(190, 40);
            this.cmdSend.TabIndex = 4;
            this.cmdSend.Text = "Send";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFile);
            this.groupBox1.Controls.Add(this.rdoWindow);
            this.groupBox1.Location = new System.Drawing.Point(221, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Target";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(13, 17);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(50, 13);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Mail Text";
            // 
            // lblWindow
            // 
            this.lblWindow.AutoSize = true;
            this.lblWindow.Location = new System.Drawing.Point(9, 182);
            this.lblWindow.Name = "lblWindow";
            this.lblWindow.Size = new System.Drawing.Size(67, 13);
            this.lblWindow.TabIndex = 7;
            this.lblWindow.Text = "Window Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 392);
            this.Controls.Add(this.lblWindow);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdSend);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lbxWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoFile;
        private System.Windows.Forms.RadioButton rdoWindow;
        private System.Windows.Forms.RichTextBox txtMail;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblWindow;
        private System.Windows.Forms.ListBox lbxWindow;
    }
}

