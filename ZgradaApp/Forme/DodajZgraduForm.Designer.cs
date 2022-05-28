
namespace ZgradaApp.Forme
{
    partial class DodajZgraduForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.upravnikComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.upisiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodavanje nove zgrade";
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresaTextBox.Location = new System.Drawing.Point(232, 184);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(260, 26);
            this.adresaTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresa:";
            // 
            // upravnikComboBox
            // 
            this.upravnikComboBox.FormattingEnabled = true;
            this.upravnikComboBox.Location = new System.Drawing.Point(232, 243);
            this.upravnikComboBox.Name = "upravnikComboBox";
            this.upravnikComboBox.Size = new System.Drawing.Size(260, 24);
            this.upravnikComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Upravnik:";
            // 
            // upisiBtn
            // 
            this.upisiBtn.Location = new System.Drawing.Point(226, 386);
            this.upisiBtn.Name = "upisiBtn";
            this.upisiBtn.Size = new System.Drawing.Size(155, 52);
            this.upisiBtn.TabIndex = 5;
            this.upisiBtn.Text = "Upisi";
            this.upisiBtn.UseVisualStyleBackColor = true;
            this.upisiBtn.Click += new System.EventHandler(this.upisiBtn_Click);
            // 
            // DodajZgraduForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.upisiBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upravnikComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DodajZgraduForm";
            this.Text = "DodajZgraduForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox upravnikComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button upisiBtn;
    }
}