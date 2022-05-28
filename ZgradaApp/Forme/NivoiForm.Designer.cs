
namespace ZgradaApp.Forme
{
    partial class NivoiForm
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
            this.nivoiListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zgradaLabel = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nivoiListView
            // 
            this.nivoiListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.nivoiListView.FullRowSelect = true;
            this.nivoiListView.HideSelection = false;
            this.nivoiListView.Location = new System.Drawing.Point(10, 41);
            this.nivoiListView.Margin = new System.Windows.Forms.Padding(2);
            this.nivoiListView.MultiSelect = false;
            this.nivoiListView.Name = "nivoiListView";
            this.nivoiListView.Size = new System.Drawing.Size(609, 410);
            this.nivoiListView.TabIndex = 0;
            this.nivoiListView.UseCompatibleStateImageBehavior = false;
            this.nivoiListView.View = System.Windows.Forms.View.Details;
            this.nivoiListView.DoubleClick += new System.EventHandler(this.nivoiListView_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Broj nivoa";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tip nivoa";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Broj objekata";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 119;
            // 
            // zgradaLabel
            // 
            this.zgradaLabel.AutoSize = true;
            this.zgradaLabel.Location = new System.Drawing.Point(10, 11);
            this.zgradaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zgradaLabel.Name = "zgradaLabel";
            this.zgradaLabel.Size = new System.Drawing.Size(35, 13);
            this.zgradaLabel.TabIndex = 1;
            this.zgradaLabel.Text = "label1";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(16, 134);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(98, 32);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj novi nivo";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(16, 188);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(98, 32);
            this.btnIzmeni.TabIndex = 3;
            this.btnIzmeni.Text = "Izmeni nivo";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(16, 243);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(98, 32);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi nivo";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisi);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.btnIzmeni);
            this.groupBox1.Location = new System.Drawing.Point(636, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(130, 410);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // NivoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zgradaLabel);
            this.Controls.Add(this.nivoiListView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NivoiForm";
            this.Text = "NivoiForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView nivoiListView;
        private System.Windows.Forms.Label zgradaLabel;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}