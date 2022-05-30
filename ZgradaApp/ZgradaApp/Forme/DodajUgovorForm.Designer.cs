
namespace ZgradaApp.Forme {
    partial class DodajUgovorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifraUgovoraTxtBox = new System.Windows.Forms.TextBox();
            this.periodVazenjaTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datumPocetkaPicker = new System.Windows.Forms.DateTimePicker();
            this.upisiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifra ugovora";
            // 
            // sifraUgovoraTxtBox
            // 
            this.sifraUgovoraTxtBox.Location = new System.Drawing.Point(148, 97);
            this.sifraUgovoraTxtBox.Name = "sifraUgovoraTxtBox";
            this.sifraUgovoraTxtBox.Size = new System.Drawing.Size(100, 20);
            this.sifraUgovoraTxtBox.TabIndex = 2;
            this.sifraUgovoraTxtBox.TextChanged += new System.EventHandler(this.sifraUgovoraTxtBox_TextChanged);
            // 
            // periodVazenjaTxtBox
            // 
            this.periodVazenjaTxtBox.Location = new System.Drawing.Point(148, 130);
            this.periodVazenjaTxtBox.Name = "periodVazenjaTxtBox";
            this.periodVazenjaTxtBox.Size = new System.Drawing.Size(100, 20);
            this.periodVazenjaTxtBox.TabIndex = 4;
            this.periodVazenjaTxtBox.TextChanged += new System.EventHandler(this.periodVazenjaTxtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Period vazenja (godina)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datum pocetka vazenja";
            // 
            // datumPocetkaPicker
            // 
            this.datumPocetkaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumPocetkaPicker.Location = new System.Drawing.Point(148, 163);
            this.datumPocetkaPicker.Name = "datumPocetkaPicker";
            this.datumPocetkaPicker.Size = new System.Drawing.Size(100, 20);
            this.datumPocetkaPicker.TabIndex = 6;
            // 
            // upisiBtn
            // 
            this.upisiBtn.Location = new System.Drawing.Point(100, 258);
            this.upisiBtn.Name = "upisiBtn";
            this.upisiBtn.Size = new System.Drawing.Size(104, 42);
            this.upisiBtn.TabIndex = 7;
            this.upisiBtn.Text = "Upisi";
            this.upisiBtn.UseVisualStyleBackColor = true;
            this.upisiBtn.Click += new System.EventHandler(this.upisiBtn_Click);
            // 
            // DodajUgovorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 325);
            this.Controls.Add(this.upisiBtn);
            this.Controls.Add(this.datumPocetkaPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.periodVazenjaTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sifraUgovoraTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajUgovorForm";
            this.Text = "DodajUgovorForm";
            this.Load += new System.EventHandler(this.DodajUgovorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifraUgovoraTxtBox;
        private System.Windows.Forms.TextBox periodVazenjaTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datumPocetkaPicker;
        private System.Windows.Forms.Button upisiBtn;
    }
}