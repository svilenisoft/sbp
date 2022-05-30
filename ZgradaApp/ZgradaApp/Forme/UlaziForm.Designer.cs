
namespace ZgradaApp.Forme {
    partial class UlaziForm {
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
            this.ulaziListView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dodajUlazBtn = new System.Windows.Forms.Button();
            this.izmeniUlazBtn = new System.Windows.Forms.Button();
            this.obrisiUlazBtn = new System.Windows.Forms.Button();
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
            // ulaziListView
            // 
            this.ulaziListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ulaziListView.FullRowSelect = true;
            this.ulaziListView.HideSelection = false;
            this.ulaziListView.Location = new System.Drawing.Point(16, 56);
            this.ulaziListView.MultiSelect = false;
            this.ulaziListView.Name = "ulaziListView";
            this.ulaziListView.Size = new System.Drawing.Size(617, 382);
            this.ulaziListView.TabIndex = 1;
            this.ulaziListView.UseCompatibleStateImageBehavior = false;
            this.ulaziListView.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.obrisiUlazBtn);
            this.groupBox1.Controls.Add(this.izmeniUlazBtn);
            this.groupBox1.Controls.Add(this.dodajUlazBtn);
            this.groupBox1.Location = new System.Drawing.Point(639, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 388);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dodajUlazBtn
            // 
            this.dodajUlazBtn.Location = new System.Drawing.Point(21, 76);
            this.dodajUlazBtn.Name = "dodajUlazBtn";
            this.dodajUlazBtn.Size = new System.Drawing.Size(106, 42);
            this.dodajUlazBtn.TabIndex = 0;
            this.dodajUlazBtn.Text = "Dodaj ulaz";
            this.dodajUlazBtn.UseVisualStyleBackColor = true;
            this.dodajUlazBtn.Click += new System.EventHandler(this.dodajUlazBtn_Click);
            // 
            // izmeniUlazBtn
            // 
            this.izmeniUlazBtn.Location = new System.Drawing.Point(21, 173);
            this.izmeniUlazBtn.Name = "izmeniUlazBtn";
            this.izmeniUlazBtn.Size = new System.Drawing.Size(106, 42);
            this.izmeniUlazBtn.TabIndex = 1;
            this.izmeniUlazBtn.Text = "Izmeni ulaz";
            this.izmeniUlazBtn.UseVisualStyleBackColor = true;
            this.izmeniUlazBtn.Click += new System.EventHandler(this.izmeniUlazBtn_Click);
            // 
            // obrisiUlazBtn
            // 
            this.obrisiUlazBtn.Location = new System.Drawing.Point(21, 270);
            this.obrisiUlazBtn.Name = "obrisiUlazBtn";
            this.obrisiUlazBtn.Size = new System.Drawing.Size(106, 42);
            this.obrisiUlazBtn.TabIndex = 2;
            this.obrisiUlazBtn.Text = "Obrisi ulaz";
            this.obrisiUlazBtn.UseVisualStyleBackColor = true;
            this.obrisiUlazBtn.Click += new System.EventHandler(this.obrisiUlazBtn_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Broj ulaza";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vreme otvaranja";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vreme zatvaranja";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Poseduje video kameru";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 200;
            // 
            // UlaziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ulaziListView);
            this.Controls.Add(this.label1);
            this.Name = "UlaziForm";
            this.Text = "UlaziForm";
            this.Load += new System.EventHandler(this.UlaziForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ulaziListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button obrisiUlazBtn;
        private System.Windows.Forms.Button izmeniUlazBtn;
        private System.Windows.Forms.Button dodajUlazBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}