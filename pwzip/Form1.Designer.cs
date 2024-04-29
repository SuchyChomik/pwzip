namespace pwzip
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.browseZipButton = new System.Windows.Forms.Button();
            this.dictionaryRadioButton = new System.Windows.Forms.RadioButton();
            this.bruteForceRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dictionaryTextBox = new System.Windows.Forms.TextBox();
            this.browseDictionaryButton = new System.Windows.Forms.Button();
            this.crackButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZIP File:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // zipTextBox
            // 
            this.zipTextBox.BackColor = System.Drawing.Color.SeaShell;
            this.zipTextBox.Location = new System.Drawing.Point(73, 15);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(217, 22);
            this.zipTextBox.TabIndex = 1;
            // 
            // browseZipButton
            // 
            this.browseZipButton.Location = new System.Drawing.Point(296, 14);
            this.browseZipButton.Name = "browseZipButton";
            this.browseZipButton.Size = new System.Drawing.Size(75, 23);
            this.browseZipButton.TabIndex = 2;
            this.browseZipButton.Text = "Browse";
            this.browseZipButton.UseVisualStyleBackColor = true;
            this.browseZipButton.Click += new System.EventHandler(this.browseZipButton_Click);
            // 
            // dictionaryRadioButton
            // 
            this.dictionaryRadioButton.AutoSize = true;
            this.dictionaryRadioButton.Location = new System.Drawing.Point(12, 46);
            this.dictionaryRadioButton.Name = "dictionaryRadioButton";
            this.dictionaryRadioButton.Size = new System.Drawing.Size(128, 20);
            this.dictionaryRadioButton.TabIndex = 3;
            this.dictionaryRadioButton.TabStop = true;
            this.dictionaryRadioButton.Text = "Dictionary Attack";
            this.dictionaryRadioButton.UseVisualStyleBackColor = true;
            this.dictionaryRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // bruteForceRadioButton
            // 
            this.bruteForceRadioButton.AutoSize = true;
            this.bruteForceRadioButton.Location = new System.Drawing.Point(12, 107);
            this.bruteForceRadioButton.Name = "bruteForceRadioButton";
            this.bruteForceRadioButton.Size = new System.Drawing.Size(93, 20);
            this.bruteForceRadioButton.TabIndex = 4;
            this.bruteForceRadioButton.TabStop = true;
            this.bruteForceRadioButton.Text = "Brute-force";
            this.bruteForceRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password List:";
            // 
            // dictionaryTextBox
            // 
            this.dictionaryTextBox.BackColor = System.Drawing.Color.SeaShell;
            this.dictionaryTextBox.Location = new System.Drawing.Point(111, 78);
            this.dictionaryTextBox.Name = "dictionaryTextBox";
            this.dictionaryTextBox.Size = new System.Drawing.Size(158, 22);
            this.dictionaryTextBox.TabIndex = 6;
            this.dictionaryTextBox.TextChanged += new System.EventHandler(this.dictionaryTextBox_TextChanged);
            // 
            // browseDictionaryButton
            // 
            this.browseDictionaryButton.Location = new System.Drawing.Point(275, 78);
            this.browseDictionaryButton.Name = "browseDictionaryButton";
            this.browseDictionaryButton.Size = new System.Drawing.Size(75, 23);
            this.browseDictionaryButton.TabIndex = 7;
            this.browseDictionaryButton.Text = "Browse";
            this.browseDictionaryButton.UseVisualStyleBackColor = true;
            this.browseDictionaryButton.Click += new System.EventHandler(this.browseDictionaryButton_Click_1);
            // 
            // crackButton
            // 
            this.crackButton.Location = new System.Drawing.Point(151, 129);
            this.crackButton.Name = "crackButton";
            this.crackButton.Size = new System.Drawing.Size(75, 23);
            this.crackButton.TabIndex = 8;
            this.crackButton.Text = "Crack!";
            this.crackButton.UseVisualStyleBackColor = true;
            this.crackButton.Click += new System.EventHandler(this.crackButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(381, 164);
            this.Controls.Add(this.crackButton);
            this.Controls.Add(this.browseDictionaryButton);
            this.Controls.Add(this.dictionaryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bruteForceRadioButton);
            this.Controls.Add(this.dictionaryRadioButton);
            this.Controls.Add(this.browseZipButton);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ZIP Password Cracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Button browseZipButton;
        private System.Windows.Forms.RadioButton dictionaryRadioButton;
        private System.Windows.Forms.RadioButton bruteForceRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dictionaryTextBox;
        private System.Windows.Forms.Button browseDictionaryButton;
        private System.Windows.Forms.Button crackButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

