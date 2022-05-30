
namespace ZgradaApp.Forme {
    partial class UgovoriForm {
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
            this.ugovoriListView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodajUgovor = new System.Windows.Forms.Button();
            this.btnIzmeniUgovor = new System.Windows.Forms.Button();
            this.btnObrisiUgovor = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ugovoriListView
            // 
            this.ugovoriListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ugovoriListView.FullRowSelect = true;
            this.ugovoriListView.HideSelection = false;
            this.ugovoriListView.Location = new System.Drawing.Point(13, 52);
            this.ugovoriListView.MultiSelect = false;
            this.ugovoriListView.Name = "ugovoriListView";
            this.ugovoriListView.Size = new System.Drawing.Size(614, 386);
            this.ugovoriListView.TabIndex = 1;
            this.ugovoriListView.UseCompatibleStateImageBehavior = false;
            this.ugovoriListView.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisiUgovor);
            this.groupBox1.Controls.Add(this.btnIzmeniUgovor);
            this.groupBox1.Controls.Add(this.btnDodajUgovor);
            this.groupBox1.Location = new System.Drawing.Point(644, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 390);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnDodajUgovor
            // 
            this.btnDodajUgovor.Location = new System.Drawing.Point(25, 59);
            this.btnDodajUgovor.Name = "btnDodajUgovor";
            this.btnDodajUgovor.Size = new System.Drawing.Size(96, 42);
            this.btnDodajUgovor.TabIndex = 0;
            this.btnDodajUgovor.Text = "Dodaj ugovor";
            this.btnDodajUgovor.UseVisualStyleBackColor = true;
            this.btnDodajUgovor.Click += new System.EventHandler(this.btnDodajUgovor_Click);
            // 
            // btnIzmeniUgovor
            // 
            this.btnIzmeniUgovor.Location = new System.Drawing.Point(25, 174);
            this.btnIzmeniUgovor.Name = "btnIzmeniUgovor";
            this.btnIzmeniUgovor.Size = new System.Drawing.Size(96, 42);
            this.btnIzmeniUgovor.TabIndex = 1;
            this.btnIzmeniUgovor.Text = "Izmeni ugovor";
            this.btnIzmeniUgovor.UseVisualStyleBackColor = true;
            this.btnIzmeniUgovor.Click += new System.EventHandler(this.btnIzmeniUgovor_Click);
            // 
            // btnObrisiUgovor
            // 
            this.btnObrisiUgovor.Location = new System.Drawing.Point(25, 289);
            this.btnObrisiUgovor.Name = "btnObrisiUgovor";
            this.btnObrisiUgovor.Size = new System.Drawing.Size(96, 42);
            this.btnObrisiUgovor.TabIndex = 2;
            this.btnObrisiUgovor.Text = "Obrisi ugovor";
            this.btnObrisiUgovor.UseVisualStyleBackColor = true;
            this.btnObrisiUgovor.Click += new System.EventHandler(this.btnObrisiUgovor_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sifra ugovora";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Period vazenja (godina)";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum pocetka vazenja";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Datum kraja vazenja";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // UgovoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ugovoriListView);
            this.Controls.Add(this.label1);
            this.Name = "UgovoriForm";
            this.Text = "UgovoriForm";
            this.Load += new System.EventHandler(this.UgovoriForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ugovoriListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnObrisiUgovor;
        private System.Windows.Forms.Button btnIzmeniUgovor;
        private System.Windows.Forms.Button btnDodajUgovor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}