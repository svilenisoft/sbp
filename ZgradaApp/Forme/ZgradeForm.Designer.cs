
namespace ZgradaApp
{
    partial class ZgradeForm
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
            this.zgradeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObrisiZgradu = new System.Windows.Forms.Button();
            this.btnIzmeniZgradu = new System.Windows.Forms.Button();
            this.btnDodajZgradu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpravnik = new System.Windows.Forms.Button();
            this.btnVlasnici = new System.Windows.Forms.Button();
            this.btnStanari = new System.Windows.Forms.Button();
            this.btnUlazi = new System.Windows.Forms.Button();
            this.btnLiftovi = new System.Windows.Forms.Button();
            this.btnNivoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // zgradeListView
            // 
            this.zgradeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.zgradeListView.FullRowSelect = true;
            this.zgradeListView.HideSelection = false;
            this.zgradeListView.Location = new System.Drawing.Point(12, 12);
            this.zgradeListView.MultiSelect = false;
            this.zgradeListView.Name = "zgradeListView";
            this.zgradeListView.Size = new System.Drawing.Size(843, 553);
            this.zgradeListView.TabIndex = 0;
            this.zgradeListView.UseCompatibleStateImageBehavior = false;
            this.zgradeListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "idZgrade";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime upravnika";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adresa";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisiZgradu);
            this.groupBox1.Controls.Add(this.btnIzmeniZgradu);
            this.groupBox1.Controls.Add(this.btnDodajZgradu);
            this.groupBox1.Location = new System.Drawing.Point(861, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnObrisiZgradu
            // 
            this.btnObrisiZgradu.Location = new System.Drawing.Point(7, 107);
            this.btnObrisiZgradu.Name = "btnObrisiZgradu";
            this.btnObrisiZgradu.Size = new System.Drawing.Size(259, 35);
            this.btnObrisiZgradu.TabIndex = 2;
            this.btnObrisiZgradu.Text = "Obriši zgardu";
            this.btnObrisiZgradu.UseVisualStyleBackColor = true;
            this.btnObrisiZgradu.Click += new System.EventHandler(this.btnObrisiZgradu_Click);
            // 
            // btnIzmeniZgradu
            // 
            this.btnIzmeniZgradu.Location = new System.Drawing.Point(7, 64);
            this.btnIzmeniZgradu.Name = "btnIzmeniZgradu";
            this.btnIzmeniZgradu.Size = new System.Drawing.Size(260, 35);
            this.btnIzmeniZgradu.TabIndex = 1;
            this.btnIzmeniZgradu.Text = "Izmeni zgradu";
            this.btnIzmeniZgradu.UseVisualStyleBackColor = true;
            this.btnIzmeniZgradu.Click += new System.EventHandler(this.btnIzmeniZgradu_Click);
            // 
            // btnDodajZgradu
            // 
            this.btnDodajZgradu.Location = new System.Drawing.Point(6, 21);
            this.btnDodajZgradu.Name = "btnDodajZgradu";
            this.btnDodajZgradu.Size = new System.Drawing.Size(260, 35);
            this.btnDodajZgradu.TabIndex = 0;
            this.btnDodajZgradu.Text = "Dodaj zgradu";
            this.btnDodajZgradu.UseVisualStyleBackColor = true;
            this.btnDodajZgradu.Click += new System.EventHandler(this.btnDodajZgradu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpravnik);
            this.groupBox2.Controls.Add(this.btnVlasnici);
            this.groupBox2.Controls.Add(this.btnStanari);
            this.groupBox2.Controls.Add(this.btnUlazi);
            this.groupBox2.Controls.Add(this.btnLiftovi);
            this.groupBox2.Controls.Add(this.btnNivoi);
            this.groupBox2.Location = new System.Drawing.Point(861, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 365);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnUpravnik
            // 
            this.btnUpravnik.Location = new System.Drawing.Point(7, 324);
            this.btnUpravnik.Name = "btnUpravnik";
            this.btnUpravnik.Size = new System.Drawing.Size(250, 35);
            this.btnUpravnik.TabIndex = 5;
            this.btnUpravnik.Text = "Upravnik";
            this.btnUpravnik.UseVisualStyleBackColor = true;
            // 
            // btnVlasnici
            // 
            this.btnVlasnici.Location = new System.Drawing.Point(7, 262);
            this.btnVlasnici.Name = "btnVlasnici";
            this.btnVlasnici.Size = new System.Drawing.Size(250, 35);
            this.btnVlasnici.TabIndex = 4;
            this.btnVlasnici.Text = "Vlasnici";
            this.btnVlasnici.UseVisualStyleBackColor = true;
            // 
            // btnStanari
            // 
            this.btnStanari.Location = new System.Drawing.Point(7, 200);
            this.btnStanari.Name = "btnStanari";
            this.btnStanari.Size = new System.Drawing.Size(250, 35);
            this.btnStanari.TabIndex = 3;
            this.btnStanari.Text = "Stanari";
            this.btnStanari.UseVisualStyleBackColor = true;
            // 
            // btnUlazi
            // 
            this.btnUlazi.Location = new System.Drawing.Point(7, 138);
            this.btnUlazi.Name = "btnUlazi";
            this.btnUlazi.Size = new System.Drawing.Size(250, 35);
            this.btnUlazi.TabIndex = 2;
            this.btnUlazi.Text = "Ulazi";
            this.btnUlazi.UseVisualStyleBackColor = true;
            // 
            // btnLiftovi
            // 
            this.btnLiftovi.Location = new System.Drawing.Point(7, 76);
            this.btnLiftovi.Name = "btnLiftovi";
            this.btnLiftovi.Size = new System.Drawing.Size(250, 35);
            this.btnLiftovi.TabIndex = 1;
            this.btnLiftovi.Text = "Liftovi";
            this.btnLiftovi.UseVisualStyleBackColor = true;
            // 
            // btnNivoi
            // 
            this.btnNivoi.Location = new System.Drawing.Point(7, 21);
            this.btnNivoi.Name = "btnNivoi";
            this.btnNivoi.Size = new System.Drawing.Size(250, 35);
            this.btnNivoi.TabIndex = 0;
            this.btnNivoi.Text = "Nivoi";
            this.btnNivoi.UseVisualStyleBackColor = true;
            this.btnNivoi.Click += new System.EventHandler(this.btnNivoi_Click);
            // 
            // ZgradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 577);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zgradeListView);
            this.Name = "ZgradeForm";
            this.Text = "ZgradeForm";
            this.Load += new System.EventHandler(this.ZgradeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView zgradeListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnObrisiZgradu;
        private System.Windows.Forms.Button btnIzmeniZgradu;
        private System.Windows.Forms.Button btnDodajZgradu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpravnik;
        private System.Windows.Forms.Button btnVlasnici;
        private System.Windows.Forms.Button btnStanari;
        private System.Windows.Forms.Button btnUlazi;
        private System.Windows.Forms.Button btnLiftovi;
        private System.Windows.Forms.Button btnNivoi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}