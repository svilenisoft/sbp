﻿
namespace ZgradaApp.Forme {
    partial class DodajStanaraForm {
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
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.upisiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime stanara";
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(116, 71);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(152, 20);
            this.imeTextBox.TabIndex = 2;
            // 
            // upisiBtn
            // 
            this.upisiBtn.Location = new System.Drawing.Point(108, 136);
            this.upisiBtn.Name = "upisiBtn";
            this.upisiBtn.Size = new System.Drawing.Size(99, 40);
            this.upisiBtn.TabIndex = 3;
            this.upisiBtn.Text = "Upisi";
            this.upisiBtn.UseVisualStyleBackColor = true;
            this.upisiBtn.Click += new System.EventHandler(this.upisiBtn_Click);
            // 
            // DodajStanaraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 203);
            this.Controls.Add(this.upisiBtn);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajStanaraForm";
            this.Text = "DodajStanaraForm";
            this.Load += new System.EventHandler(this.DodajStanaraForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.Button upisiBtn;
    }
}