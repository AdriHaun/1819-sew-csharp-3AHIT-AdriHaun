namespace Delegate
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
            this.cmdCall = new System.Windows.Forms.Button();
            this.chkConnect = new System.Windows.Forms.CheckBox();
            this.lblPushCmd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdCall
            // 
            this.cmdCall.Location = new System.Drawing.Point(16, 38);
            this.cmdCall.Name = "cmdCall";
            this.cmdCall.Size = new System.Drawing.Size(75, 23);
            this.cmdCall.TabIndex = 0;
            this.cmdCall.Text = "Call Method";
            this.cmdCall.UseVisualStyleBackColor = true;
            this.cmdCall.Click += new System.EventHandler(this.cmdCall_Click);
            // 
            // chkConnect
            // 
            this.chkConnect.AutoSize = true;
            this.chkConnect.Location = new System.Drawing.Point(16, 67);
            this.chkConnect.Name = "chkConnect";
            this.chkConnect.Size = new System.Drawing.Size(193, 17);
            this.chkConnect.TabIndex = 1;
            this.chkConnect.Text = "Connect/Disconnect with Delegate";
            this.chkConnect.UseVisualStyleBackColor = true;
            this.chkConnect.CheckedChanged += new System.EventHandler(this.chkConnect_CheckedChanged);
            // 
            // lblPushCmd
            // 
            this.lblPushCmd.AutoSize = true;
            this.lblPushCmd.Location = new System.Drawing.Point(13, 13);
            this.lblPushCmd.Name = "lblPushCmd";
            this.lblPushCmd.Size = new System.Drawing.Size(137, 13);
            this.lblPushCmd.TabIndex = 2;
            this.lblPushCmd.Text = "Push Button to call method!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 95);
            this.Controls.Add(this.lblPushCmd);
            this.Controls.Add(this.chkConnect);
            this.Controls.Add(this.cmdCall);
            this.Name = "Form1";
            this.Text = "Delegate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCall;
        private System.Windows.Forms.CheckBox chkConnect;
        private System.Windows.Forms.Label lblPushCmd;
    }
}

