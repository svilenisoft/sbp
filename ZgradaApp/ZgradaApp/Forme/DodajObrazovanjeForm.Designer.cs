
namespace ZgradaApp.Forme {
    partial class DodajObrazovanjeForm {
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
            this.label3 = new System.Windows.Forms.Label();
            this.datumSticanjaPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbZvanje = new System.Windows.Forms.TextBox();
            this.tbImeUstanove = new System.Windows.Forms.TextBox();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime ustanove";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zvanje";
            // 
            // datumSticanjaPicker
            // 
            this.datumSticanjaPicker.Location = new System.Drawing.Point(157, 168);
            this.datumSticanjaPicker.Name = "datumSticanjaPicker";
            this.datumSticanjaPicker.Size = new System.Drawing.Size(200, 20);
            this.datumSticanjaPicker.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datum sticanja";
            // 
            // tbZvanje
            // 
            this.tbZvanje.Location = new System.Drawing.Point(157, 129);
            this.tbZvanje.Name = "tbZvanje";
            this.tbZvanje.Size = new System.Drawing.Size(200, 20);
            this.tbZvanje.TabIndex = 1;
            // 
            // tbImeUstanove
            // 
            this.tbImeUstanove.Location = new System.Drawing.Point(157, 79);
            this.tbImeUstanove.Name = "tbImeUstanove";
            this.tbImeUstanove.Size = new System.Drawing.Size(200, 20);
            this.tbImeUstanove.TabIndex = 0;
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(129, 275);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(111, 40);
            this.btnUpisi.TabIndex = 3;
            this.btnUpisi.Text = "Upisi";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // DodajObrazovanjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 331);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.tbImeUstanove);
            this.Controls.Add(this.tbZvanje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datumSticanjaPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajObrazovanjeForm";
            this.Text = "DodajObrazovanjeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datumSticanjaPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbZvanje;
        private System.Windows.Forms.TextBox tbImeUstanove;
        private System.Windows.Forms.Button btnUpisi;
    }
}