
namespace ZgradaApp.Forme {
    partial class DodajUlazForm {
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
            this.vremeOtvaranjaPicker = new System.Windows.Forms.DateTimePicker();
            this.vremeZatvaranjaPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kameraComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbrTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vreme otvaranja";
            // 
            // vremeOtvaranjaPicker
            // 
            this.vremeOtvaranjaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.vremeOtvaranjaPicker.Location = new System.Drawing.Point(245, 191);
            this.vremeOtvaranjaPicker.Name = "vremeOtvaranjaPicker";
            this.vremeOtvaranjaPicker.ShowUpDown = true;
            this.vremeOtvaranjaPicker.Size = new System.Drawing.Size(114, 20);
            this.vremeOtvaranjaPicker.TabIndex = 2;
            // 
            // vremeZatvaranjaPicker
            // 
            this.vremeZatvaranjaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.vremeZatvaranjaPicker.Location = new System.Drawing.Point(245, 238);
            this.vremeZatvaranjaPicker.Name = "vremeZatvaranjaPicker";
            this.vremeZatvaranjaPicker.ShowUpDown = true;
            this.vremeZatvaranjaPicker.Size = new System.Drawing.Size(114, 20);
            this.vremeZatvaranjaPicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vreme zatvaranja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Poseduje kameru";
            // 
            // kameraComboBox
            // 
            this.kameraComboBox.FormattingEnabled = true;
            this.kameraComboBox.Items.AddRange(new object[] {
            "DA",
            "NE"});
            this.kameraComboBox.Location = new System.Drawing.Point(245, 143);
            this.kameraComboBox.Name = "kameraComboBox";
            this.kameraComboBox.Size = new System.Drawing.Size(114, 21);
            this.kameraComboBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Upisi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Redni broj ulaza";
            // 
            // rbrTextBox
            // 
            this.rbrTextBox.Location = new System.Drawing.Point(245, 96);
            this.rbrTextBox.Name = "rbrTextBox";
            this.rbrTextBox.Size = new System.Drawing.Size(114, 20);
            this.rbrTextBox.TabIndex = 0;
            this.rbrTextBox.TextChanged += new System.EventHandler(this.rbrTextBox_TextChanged);
            // 
            // DodajUlazForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 423);
            this.Controls.Add(this.rbrTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kameraComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vremeZatvaranjaPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vremeOtvaranjaPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajUlazForm";
            this.Text = "DodajUlazForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker vremeOtvaranjaPicker;
        private System.Windows.Forms.DateTimePicker vremeZatvaranjaPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox kameraComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rbrTextBox;
    }
}