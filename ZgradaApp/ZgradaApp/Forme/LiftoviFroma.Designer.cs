
namespace ZgradaApp.Forme
{
    partial class LiftoviFroma
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
            this.zgradaLabel = new System.Windows.Forms.Label();
            this.listaLiftoviView = new System.Windows.Forms.ListView();
            this.serijskibroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajLift = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zgradaLabel
            // 
            this.zgradaLabel.AutoSize = true;
            this.zgradaLabel.Location = new System.Drawing.Point(12, 9);
            this.zgradaLabel.Name = "zgradaLabel";
            this.zgradaLabel.Size = new System.Drawing.Size(0, 17);
            this.zgradaLabel.TabIndex = 0;
            // 
            // listaLiftoviView
            // 
            this.listaLiftoviView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serijskibroj,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listaLiftoviView.FullRowSelect = true;
            this.listaLiftoviView.HideSelection = false;
            this.listaLiftoviView.Location = new System.Drawing.Point(15, 47);
            this.listaLiftoviView.Name = "listaLiftoviView";
            this.listaLiftoviView.Size = new System.Drawing.Size(1050, 391);
            this.listaLiftoviView.TabIndex = 1;
            this.listaLiftoviView.UseCompatibleStateImageBehavior = false;
            this.listaLiftoviView.View = System.Windows.Forms.View.Details;
            // 
            // serijskibroj
            // 
            this.serijskibroj.Text = "serijski broj";
            this.serijskibroj.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "naziv prozivodjaca";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "datum servisa";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "datum kvara";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "broj dana kvara";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "tip";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "nosivost";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "max broj osova";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "id";
            // 
            // btnDodajLift
            // 
            this.btnDodajLift.Location = new System.Drawing.Point(1097, 86);
            this.btnDodajLift.Name = "btnDodajLift";
            this.btnDodajLift.Size = new System.Drawing.Size(139, 50);
            this.btnDodajLift.TabIndex = 2;
            this.btnDodajLift.Text = "Dodaj";
            this.btnDodajLift.UseVisualStyleBackColor = true;
            this.btnDodajLift.Click += new System.EventHandler(this.btnDodajLift_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(1097, 200);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(139, 50);
            this.btnIzmeni.TabIndex = 3;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(1103, 313);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(133, 55);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // LiftoviFroma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodajLift);
            this.Controls.Add(this.listaLiftoviView);
            this.Controls.Add(this.zgradaLabel);
            this.Name = "LiftoviFroma";
            this.Text = "LiftoviFroma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zgradaLabel;
        private System.Windows.Forms.ListView listaLiftoviView;
        private System.Windows.Forms.Button btnDodajLift;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ColumnHeader serijskibroj;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}