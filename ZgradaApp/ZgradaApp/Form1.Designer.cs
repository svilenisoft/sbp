
namespace ZgradaApp {
    partial class Form1 {
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
            this.btnZgrada = new System.Windows.Forms.Button();
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZgrada
            // 
            this.btnZgrada.Location = new System.Drawing.Point(117, 122);
            this.btnZgrada.Name = "btnZgrada";
            this.btnZgrada.Size = new System.Drawing.Size(75, 23);
            this.btnZgrada.TabIndex = 0;
            this.btnZgrada.Text = "zgrada";
            this.btnZgrada.UseVisualStyleBackColor = true;
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.Location = new System.Drawing.Point(402, 122);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(75, 23);
            this.btnZaposleni.TabIndex = 1;
            this.btnZaposleni.Text = "zaposleni";
            this.btnZaposleni.UseVisualStyleBackColor = true;
            this.btnZaposleni.Click += new System.EventHandler(this.btnZaposleni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZaposleni);
            this.Controls.Add(this.btnZgrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZgrada;
        private System.Windows.Forms.Button btnZaposleni;
    }
}

