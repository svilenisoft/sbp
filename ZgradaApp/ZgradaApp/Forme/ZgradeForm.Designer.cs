
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
            this.btnUlazi = new System.Windows.Forms.Button();
            this.btnLiftovi = new System.Windows.Forms.Button();
            this.btnNivoi = new System.Windows.Forms.Button();
            this.btnUgovori = new System.Windows.Forms.Button();
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
            this.zgradeListView.Location = new System.Drawing.Point(9, 10);
            this.zgradeListView.Margin = new System.Windows.Forms.Padding(2);
            this.zgradeListView.MultiSelect = false;
            this.zgradeListView.Name = "zgradeListView";
            this.zgradeListView.Size = new System.Drawing.Size(633, 450);
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
            this.groupBox1.Location = new System.Drawing.Point(646, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(204, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnObrisiZgradu
            // 
            this.btnObrisiZgradu.Location = new System.Drawing.Point(5, 87);
            this.btnObrisiZgradu.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisiZgradu.Name = "btnObrisiZgradu";
            this.btnObrisiZgradu.Size = new System.Drawing.Size(194, 28);
            this.btnObrisiZgradu.TabIndex = 2;
            this.btnObrisiZgradu.Text = "Obriši zgardu";
            this.btnObrisiZgradu.UseVisualStyleBackColor = true;
            this.btnObrisiZgradu.Click += new System.EventHandler(this.btnObrisiZgradu_Click);
            // 
            // btnIzmeniZgradu
            // 
            this.btnIzmeniZgradu.Location = new System.Drawing.Point(5, 52);
            this.btnIzmeniZgradu.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzmeniZgradu.Name = "btnIzmeniZgradu";
            this.btnIzmeniZgradu.Size = new System.Drawing.Size(195, 28);
            this.btnIzmeniZgradu.TabIndex = 1;
            this.btnIzmeniZgradu.Text = "Izmeni zgradu";
            this.btnIzmeniZgradu.UseVisualStyleBackColor = true;
            this.btnIzmeniZgradu.Click += new System.EventHandler(this.btnIzmeniZgradu_Click);
            // 
            // btnDodajZgradu
            // 
            this.btnDodajZgradu.Location = new System.Drawing.Point(4, 17);
            this.btnDodajZgradu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajZgradu.Name = "btnDodajZgradu";
            this.btnDodajZgradu.Size = new System.Drawing.Size(195, 28);
            this.btnDodajZgradu.TabIndex = 0;
            this.btnDodajZgradu.Text = "Dodaj zgradu";
            this.btnDodajZgradu.UseVisualStyleBackColor = true;
            this.btnDodajZgradu.Click += new System.EventHandler(this.btnDodajZgradu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUgovori);
            this.groupBox2.Controls.Add(this.btnUlazi);
            this.groupBox2.Controls.Add(this.btnLiftovi);
            this.groupBox2.Controls.Add(this.btnNivoi);
            this.groupBox2.Location = new System.Drawing.Point(646, 162);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(204, 297);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnUlazi
            // 
            this.btnUlazi.Location = new System.Drawing.Point(22, 172);
            this.btnUlazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnUlazi.Name = "btnUlazi";
            this.btnUlazi.Size = new System.Drawing.Size(161, 28);
            this.btnUlazi.TabIndex = 2;
            this.btnUlazi.Text = "Ulazi";
            this.btnUlazi.UseVisualStyleBackColor = true;
            this.btnUlazi.Click += new System.EventHandler(this.btnUlazi_Click);
            // 
            // btnLiftovi
            // 
            this.btnLiftovi.Location = new System.Drawing.Point(22, 99);
            this.btnLiftovi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLiftovi.Name = "btnLiftovi";
            this.btnLiftovi.Size = new System.Drawing.Size(161, 28);
            this.btnLiftovi.TabIndex = 1;
            this.btnLiftovi.Text = "Liftovi";
            this.btnLiftovi.UseVisualStyleBackColor = true;
            this.btnLiftovi.Click += new System.EventHandler(this.btnLiftovi_Click);
            // 
            // btnNivoi
            // 
            this.btnNivoi.Location = new System.Drawing.Point(22, 26);
            this.btnNivoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnNivoi.Name = "btnNivoi";
            this.btnNivoi.Size = new System.Drawing.Size(161, 28);
            this.btnNivoi.TabIndex = 0;
            this.btnNivoi.Text = "Nivoi";
            this.btnNivoi.UseVisualStyleBackColor = true;
            this.btnNivoi.Click += new System.EventHandler(this.btnNivoi_Click);
            // 
            // btnUgovori
            // 
            this.btnUgovori.Location = new System.Drawing.Point(22, 245);
            this.btnUgovori.Name = "btnUgovori";
            this.btnUgovori.Size = new System.Drawing.Size(161, 28);
            this.btnUgovori.TabIndex = 3;
            this.btnUgovori.Text = "Ugovori";
            this.btnUgovori.UseVisualStyleBackColor = true;
            this.btnUgovori.Click += new System.EventHandler(this.btnUgovori_Click);
            // 
            // ZgradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 469);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zgradeListView);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnUlazi;
        private System.Windows.Forms.Button btnLiftovi;
        private System.Windows.Forms.Button btnNivoi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnUgovori;
    }
}