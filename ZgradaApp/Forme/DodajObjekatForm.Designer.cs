
namespace ZgradaApp.Forme {
    partial class DodajObjekatForm {
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
            this.brObjektaTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dodajStanPannel = new System.Windows.Forms.Panel();
            this.noviVlasnikBtn = new System.Windows.Forms.Button();
            this.vlasnikComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dodajLokalPannel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.imeFirmeTxtBox = new System.Windows.Forms.TextBox();
            this.dodajMestoPannel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.regBrTxtBox = new System.Windows.Forms.TextBox();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.upisBtn = new System.Windows.Forms.Button();
            this.dodajStanPannel.SuspendLayout();
            this.dodajLokalPannel.SuspendLayout();
            this.dodajMestoPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // brObjektaTxtBox
            // 
            this.brObjektaTxtBox.Location = new System.Drawing.Point(170, 92);
            this.brObjektaTxtBox.Name = "brObjektaTxtBox";
            this.brObjektaTxtBox.Size = new System.Drawing.Size(100, 20);
            this.brObjektaTxtBox.TabIndex = 1;
            this.brObjektaTxtBox.TextChanged += new System.EventHandler(this.brObjektaTxtBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj Objekta";
            // 
            // dodajStanPannel
            // 
            this.dodajStanPannel.Controls.Add(this.noviVlasnikBtn);
            this.dodajStanPannel.Controls.Add(this.vlasnikComboBox);
            this.dodajStanPannel.Controls.Add(this.label3);
            this.dodajStanPannel.Location = new System.Drawing.Point(64, 160);
            this.dodajStanPannel.Name = "dodajStanPannel";
            this.dodajStanPannel.Size = new System.Drawing.Size(236, 130);
            this.dodajStanPannel.TabIndex = 3;
            // 
            // noviVlasnikBtn
            // 
            this.noviVlasnikBtn.Location = new System.Drawing.Point(80, 74);
            this.noviVlasnikBtn.Name = "noviVlasnikBtn";
            this.noviVlasnikBtn.Size = new System.Drawing.Size(75, 23);
            this.noviVlasnikBtn.TabIndex = 5;
            this.noviVlasnikBtn.Text = "Novi vlasnik";
            this.noviVlasnikBtn.UseVisualStyleBackColor = true;
            this.noviVlasnikBtn.Click += new System.EventHandler(this.noviVlasnikBtn_Click);
            // 
            // vlasnikComboBox
            // 
            this.vlasnikComboBox.FormattingEnabled = true;
            this.vlasnikComboBox.Location = new System.Drawing.Point(93, 33);
            this.vlasnikComboBox.Name = "vlasnikComboBox";
            this.vlasnikComboBox.Size = new System.Drawing.Size(121, 21);
            this.vlasnikComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vlasnik";
            // 
            // dodajLokalPannel
            // 
            this.dodajLokalPannel.Controls.Add(this.label4);
            this.dodajLokalPannel.Controls.Add(this.imeFirmeTxtBox);
            this.dodajLokalPannel.Location = new System.Drawing.Point(64, 160);
            this.dodajLokalPannel.Name = "dodajLokalPannel";
            this.dodajLokalPannel.Size = new System.Drawing.Size(236, 130);
            this.dodajLokalPannel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ime firme";
            // 
            // imeFirmeTxtBox
            // 
            this.imeFirmeTxtBox.Location = new System.Drawing.Point(111, 55);
            this.imeFirmeTxtBox.Name = "imeFirmeTxtBox";
            this.imeFirmeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.imeFirmeTxtBox.TabIndex = 2;
            // 
            // dodajMestoPannel
            // 
            this.dodajMestoPannel.Controls.Add(this.label5);
            this.dodajMestoPannel.Controls.Add(this.regBrTxtBox);
            this.dodajMestoPannel.Location = new System.Drawing.Point(64, 160);
            this.dodajMestoPannel.Name = "dodajMestoPannel";
            this.dodajMestoPannel.Size = new System.Drawing.Size(236, 130);
            this.dodajMestoPannel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Registarski broj";
            // 
            // regBrTxtBox
            // 
            this.regBrTxtBox.Location = new System.Drawing.Point(111, 55);
            this.regBrTxtBox.Name = "regBrTxtBox";
            this.regBrTxtBox.Size = new System.Drawing.Size(100, 20);
            this.regBrTxtBox.TabIndex = 2;
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // upisBtn
            // 
            this.upisBtn.Location = new System.Drawing.Point(145, 296);
            this.upisBtn.Name = "upisBtn";
            this.upisBtn.Size = new System.Drawing.Size(75, 23);
            this.upisBtn.TabIndex = 5;
            this.upisBtn.Text = "Upisi";
            this.upisBtn.UseVisualStyleBackColor = true;
            this.upisBtn.Click += new System.EventHandler(this.upisBtn_Click);
            // 
            // DodajObjekatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 331);
            this.Controls.Add(this.upisBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dodajStanPannel);
            this.Controls.Add(this.brObjektaTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajMestoPannel);
            this.Controls.Add(this.dodajLokalPannel);
            this.Name = "DodajObjekatForm";
            this.Text = "DodajObjekatForm";
            this.Load += new System.EventHandler(this.DodajObjekatForm_Load);
            this.dodajStanPannel.ResumeLayout(false);
            this.dodajStanPannel.PerformLayout();
            this.dodajLokalPannel.ResumeLayout(false);
            this.dodajLokalPannel.PerformLayout();
            this.dodajMestoPannel.ResumeLayout(false);
            this.dodajMestoPannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox brObjektaTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel dodajStanPannel;
        private System.Windows.Forms.Panel dodajLokalPannel;
        private System.Windows.Forms.Panel dodajMestoPannel;
        private System.Windows.Forms.ComboBox vlasnikComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imeFirmeTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regBrTxtBox;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.Button upisBtn;
        private System.Windows.Forms.Button noviVlasnikBtn;
    }
}