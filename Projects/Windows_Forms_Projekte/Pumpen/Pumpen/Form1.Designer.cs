namespace Pumpen
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
            this.chckPump1 = new System.Windows.Forms.CheckBox();
            this.chckPump2 = new System.Windows.Forms.CheckBox();
            this.chckPump3 = new System.Windows.Forms.CheckBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chckPump1
            // 
            this.chckPump1.AutoSize = true;
            this.chckPump1.Location = new System.Drawing.Point(13, 13);
            this.chckPump1.Name = "chckPump1";
            this.chckPump1.Size = new System.Drawing.Size(68, 17);
            this.chckPump1.TabIndex = 0;
            this.chckPump1.Text = "Pumpe 1";
            this.chckPump1.UseVisualStyleBackColor = true;
            this.chckPump1.CheckedChanged += new System.EventHandler(this.chckPump1_CheckedChanged);
            // 
            // chckPump2
            // 
            this.chckPump2.AutoSize = true;
            this.chckPump2.Location = new System.Drawing.Point(13, 37);
            this.chckPump2.Name = "chckPump2";
            this.chckPump2.Size = new System.Drawing.Size(68, 17);
            this.chckPump2.TabIndex = 1;
            this.chckPump2.Text = "Pumpe 2";
            this.chckPump2.UseVisualStyleBackColor = true;
            // 
            // chckPump3
            // 
            this.chckPump3.AutoSize = true;
            this.chckPump3.Location = new System.Drawing.Point(13, 61);
            this.chckPump3.Name = "chckPump3";
            this.chckPump3.Size = new System.Drawing.Size(68, 17);
            this.chckPump3.TabIndex = 2;
            this.chckPump3.Text = "Pumpe 3";
            this.chckPump3.UseVisualStyleBackColor = true;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(12, 85);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(69, 23);
            this.cmdStart.TabIndex = 3;
            this.cmdStart.Text = "Starten";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 120);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.chckPump3);
            this.Controls.Add(this.chckPump2);
            this.Controls.Add(this.chckPump1);
            this.Name = "Form1";
            this.Text = "select Pumps to start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chckPump1;
        private System.Windows.Forms.CheckBox chckPump2;
        private System.Windows.Forms.CheckBox chckPump3;
        private System.Windows.Forms.Button cmdStart;
    }
}

