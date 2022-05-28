
namespace ZgradaApp.Forme {
    partial class DodajNivoForm {
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
            this.brNivoaTextBox = new System.Windows.Forms.TextBox();
            this.upisBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tipComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj nivoa";
            // 
            // brNivoaTextBox
            // 
            this.brNivoaTextBox.Location = new System.Drawing.Point(79, 99);
            this.brNivoaTextBox.Name = "brNivoaTextBox";
            this.brNivoaTextBox.Size = new System.Drawing.Size(219, 20);
            this.brNivoaTextBox.TabIndex = 2;
            this.brNivoaTextBox.TextChanged += new System.EventHandler(this.brNivoaTextBox_TextChanged);
            // 
            // upisBtn
            // 
            this.upisBtn.Location = new System.Drawing.Point(119, 204);
            this.upisBtn.Name = "upisBtn";
            this.upisBtn.Size = new System.Drawing.Size(75, 37);
            this.upisBtn.TabIndex = 3;
            this.upisBtn.Text = "Upisi";
            this.upisBtn.UseVisualStyleBackColor = true;
            this.upisBtn.Click += new System.EventHandler(this.upisBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip nivoa";
            // 
            // tipComboBox
            // 
            this.tipComboBox.FormattingEnabled = true;
            this.tipComboBox.Items.AddRange(new object[] {
            "Stambeni nivo",
            "Poslovni nivo",
            "Garazni nivo"});
            this.tipComboBox.Location = new System.Drawing.Point(79, 132);
            this.tipComboBox.Name = "tipComboBox";
            this.tipComboBox.Size = new System.Drawing.Size(219, 21);
            this.tipComboBox.TabIndex = 6;
            // 
            // DodajNivoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 253);
            this.Controls.Add(this.tipComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upisBtn);
            this.Controls.Add(this.brNivoaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajNivoForm";
            this.Text = "DodajNivoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox brNivoaTextBox;
        private System.Windows.Forms.Button upisBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipComboBox;
    }
}