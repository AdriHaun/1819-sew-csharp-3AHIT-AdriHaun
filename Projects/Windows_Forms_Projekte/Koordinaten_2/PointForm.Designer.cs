namespace PointCoords
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtXcoords = new System.Windows.Forms.TextBox();
            this.txtYcoords = new System.Windows.Forms.TextBox();
            this.cmdSaveCoords = new System.Windows.Forms.Button();
            this.cmdAusgabe = new System.Windows.Forms.Button();
            this.cmdClearLbox = new System.Windows.Forms.Button();
            this.cmdWriteCoords = new System.Windows.Forms.Button();
            this.cmdReadCoords = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Index = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lboxcoords = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonBin = new System.Windows.Forms.RadioButton();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.cmdSort = new System.Windows.Forms.Button();
            this.txtXref = new System.Windows.Forms.TextBox();
            this.txtYref = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // txtXcoords
            // 
            this.txtXcoords.Location = new System.Drawing.Point(35, 12);
            this.txtXcoords.Name = "txtXcoords";
            this.txtXcoords.Size = new System.Drawing.Size(32, 20);
            this.txtXcoords.TabIndex = 2;
            // 
            // txtYcoords
            // 
            this.txtYcoords.Location = new System.Drawing.Point(108, 12);
            this.txtYcoords.Name = "txtYcoords";
            this.txtYcoords.Size = new System.Drawing.Size(35, 20);
            this.txtYcoords.TabIndex = 3;
            // 
            // cmdSaveCoords
            // 
            this.cmdSaveCoords.Location = new System.Drawing.Point(149, 9);
            this.cmdSaveCoords.Name = "cmdSaveCoords";
            this.cmdSaveCoords.Size = new System.Drawing.Size(128, 23);
            this.cmdSaveCoords.TabIndex = 4;
            this.cmdSaveCoords.Text = "Koordinaten speichern";
            this.cmdSaveCoords.UseVisualStyleBackColor = true;
            this.cmdSaveCoords.Click += new System.EventHandler(this.cmdSaveCoords_Click);
            // 
            // cmdAusgabe
            // 
            this.cmdAusgabe.Location = new System.Drawing.Point(149, 49);
            this.cmdAusgabe.Name = "cmdAusgabe";
            this.cmdAusgabe.Size = new System.Drawing.Size(128, 37);
            this.cmdAusgabe.TabIndex = 6;
            this.cmdAusgabe.Text = "Koordinaten ausgeben";
            this.cmdAusgabe.UseVisualStyleBackColor = true;
            this.cmdAusgabe.Click += new System.EventHandler(this.cmdAusgabe_Click);
            // 
            // cmdClearLbox
            // 
            this.cmdClearLbox.Location = new System.Drawing.Point(149, 92);
            this.cmdClearLbox.Name = "cmdClearLbox";
            this.cmdClearLbox.Size = new System.Drawing.Size(128, 37);
            this.cmdClearLbox.TabIndex = 9;
            this.cmdClearLbox.Text = "Koordinaten aus Listbox löschen";
            this.cmdClearLbox.UseVisualStyleBackColor = true;
            this.cmdClearLbox.Click += new System.EventHandler(this.cmdClearLbox_Click);
            // 
            // cmdWriteCoords
            // 
            this.cmdWriteCoords.Location = new System.Drawing.Point(149, 135);
            this.cmdWriteCoords.Name = "cmdWriteCoords";
            this.cmdWriteCoords.Size = new System.Drawing.Size(128, 41);
            this.cmdWriteCoords.TabIndex = 10;
            this.cmdWriteCoords.Text = "Koordinaten in Datei schreiben";
            this.cmdWriteCoords.UseVisualStyleBackColor = true;
            this.cmdWriteCoords.Click += new System.EventHandler(this.cmdWriteCoords_Click);
            // 
            // cmdReadCoords
            // 
            this.cmdReadCoords.Location = new System.Drawing.Point(149, 185);
            this.cmdReadCoords.Name = "cmdReadCoords";
            this.cmdReadCoords.Size = new System.Drawing.Size(128, 37);
            this.cmdReadCoords.TabIndex = 11;
            this.cmdReadCoords.Text = "Koordinaten aus Datei lesen";
            this.cmdReadCoords.UseVisualStyleBackColor = true;
            this.cmdReadCoords.Click += new System.EventHandler(this.cmdReadCoords_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nullbasierter Index der Koordinate";
            // 
            // txt_Index
            // 
            this.txt_Index.Location = new System.Drawing.Point(24, 268);
            this.txt_Index.Name = "txt_Index";
            this.txt_Index.Size = new System.Drawing.Size(29, 20);
            this.txt_Index.TabIndex = 13;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(59, 266);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 14;
            this.cmdSearch.Text = "Suchen...";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // lboxcoords
            // 
            this.lboxcoords.FormattingEnabled = true;
            this.lboxcoords.Location = new System.Drawing.Point(15, 49);
            this.lboxcoords.Name = "lboxcoords";
            this.lboxcoords.Size = new System.Drawing.Size(128, 173);
            this.lboxcoords.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonBin);
            this.panel1.Controls.Add(this.radioButtonText);
            this.panel1.Location = new System.Drawing.Point(204, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 51);
            this.panel1.TabIndex = 16;
            // 
            // radioButtonBin
            // 
            this.radioButtonBin.AutoSize = true;
            this.radioButtonBin.Location = new System.Drawing.Point(4, 29);
            this.radioButtonBin.Name = "radioButtonBin";
            this.radioButtonBin.Size = new System.Drawing.Size(49, 17);
            this.radioButtonBin.TabIndex = 1;
            this.radioButtonBin.TabStop = true;
            this.radioButtonBin.Text = "Binär";
            this.radioButtonBin.UseVisualStyleBackColor = true;
            // 
            // radioButtonText
            // 
            this.radioButtonText.AutoSize = true;
            this.radioButtonText.Checked = true;
            this.radioButtonText.Location = new System.Drawing.Point(4, 6);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(46, 17);
            this.radioButtonText.TabIndex = 0;
            this.radioButtonText.TabStop = true;
            this.radioButtonText.Text = "Text";
            this.radioButtonText.UseVisualStyleBackColor = true;
            // 
            // cmdSort
            // 
            this.cmdSort.Location = new System.Drawing.Point(171, 330);
            this.cmdSort.Name = "cmdSort";
            this.cmdSort.Size = new System.Drawing.Size(106, 25);
            this.cmdSort.TabIndex = 17;
            this.cmdSort.Text = "Ausgabe sortieren";
            this.cmdSort.UseVisualStyleBackColor = true;
            this.cmdSort.Click += new System.EventHandler(this.cmdSort_Click);
            // 
            // txtXref
            // 
            this.txtXref.Location = new System.Drawing.Point(24, 335);
            this.txtXref.Name = "txtXref";
            this.txtXref.Size = new System.Drawing.Size(35, 20);
            this.txtXref.TabIndex = 18;
            this.txtXref.Text = "0";
            // 
            // txtYref
            // 
            this.txtYref.Location = new System.Drawing.Point(97, 333);
            this.txtYref.Name = "txtYref";
            this.txtYref.Size = new System.Drawing.Size(37, 20);
            this.txtYref.TabIndex = 19;
            this.txtYref.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "X ref";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Y ref";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYref);
            this.Controls.Add(this.txtXref);
            this.Controls.Add(this.cmdSort);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lboxcoords);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txt_Index);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdReadCoords);
            this.Controls.Add(this.cmdWriteCoords);
            this.Controls.Add(this.cmdClearLbox);
            this.Controls.Add(this.cmdAusgabe);
            this.Controls.Add(this.cmdSaveCoords);
            this.Controls.Add(this.txtYcoords);
            this.Controls.Add(this.txtXcoords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PointCoords";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXcoords;
        private System.Windows.Forms.TextBox txtYcoords;
        private System.Windows.Forms.Button cmdSaveCoords;
        private System.Windows.Forms.Button cmdAusgabe;
        private System.Windows.Forms.Button cmdClearLbox;
        private System.Windows.Forms.Button cmdWriteCoords;
        private System.Windows.Forms.Button cmdReadCoords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Index;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox lboxcoords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonBin;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.Button cmdSort;
        private System.Windows.Forms.TextBox txtXref;
        private System.Windows.Forms.TextBox txtYref;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

