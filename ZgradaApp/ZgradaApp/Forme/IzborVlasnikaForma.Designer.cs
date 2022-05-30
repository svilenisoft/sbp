
namespace ZgradaApp.Forme {
    partial class IzborVlasnikaForma {
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
            this.osobeList = new System.Windows.Forms.ListView();
            this.okBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.izmeniBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // osobeList
            // 
            this.osobeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.osobeList.FullRowSelect = true;
            this.osobeList.HideSelection = false;
            this.osobeList.Location = new System.Drawing.Point(12, 77);
            this.osobeList.MultiSelect = false;
            this.osobeList.Name = "osobeList";
            this.osobeList.Size = new System.Drawing.Size(1099, 361);
            this.osobeList.TabIndex = 0;
            this.osobeList.UseCompatibleStateImageBehavior = false;
            this.osobeList.View = System.Windows.Forms.View.Details;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(1144, 77);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(112, 58);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(1145, 343);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(111, 62);
            this.dodajBtn.TabIndex = 2;
            this.dodajBtn.Text = "Dodaj novu osobu";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ime roditelja";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prezime";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Adresa";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 200;
            // 
            // izmeniBtn
            // 
            this.izmeniBtn.Location = new System.Drawing.Point(1145, 206);
            this.izmeniBtn.Name = "izmeniBtn";
            this.izmeniBtn.Size = new System.Drawing.Size(111, 62);
            this.izmeniBtn.TabIndex = 3;
            this.izmeniBtn.Text = "Izmeni osobu";
            this.izmeniBtn.UseVisualStyleBackColor = true;
            this.izmeniBtn.Click += new System.EventHandler(this.izmeniBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(212, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Da bi odabrali osobu za vlasnika, svi atributi moraju biti popunjeni!";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tip";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "JMBG";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 150;
            // 
            // IzborVlasnikaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izmeniBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.osobeList);
            this.Name = "IzborVlasnikaForma";
            this.Text = "IzborVlasnikaForma";
            this.Load += new System.EventHandler(this.IzborVlasnikaForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView osobeList;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button izmeniBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}