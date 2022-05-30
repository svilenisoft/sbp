
namespace ZgradaApp.Forme {
    partial class ObjektiForma {
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
            this.objektiListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ukloniObjBtn = new System.Windows.Forms.Button();
            this.izmeniObjBtn = new System.Windows.Forms.Button();
            this.dodajObjBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objektiListView
            // 
            this.objektiListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.objektiListView.FullRowSelect = true;
            this.objektiListView.HideSelection = false;
            this.objektiListView.Location = new System.Drawing.Point(12, 39);
            this.objektiListView.MultiSelect = false;
            this.objektiListView.Name = "objektiListView";
            this.objektiListView.Size = new System.Drawing.Size(622, 399);
            this.objektiListView.TabIndex = 0;
            this.objektiListView.UseCompatibleStateImageBehavior = false;
            this.objektiListView.View = System.Windows.Forms.View.Details;
            this.objektiListView.DoubleClick += new System.EventHandler(this.objektiListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Redni broj";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ukloniObjBtn);
            this.groupBox1.Controls.Add(this.izmeniObjBtn);
            this.groupBox1.Controls.Add(this.dodajObjBtn);
            this.groupBox1.Location = new System.Drawing.Point(643, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 399);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ukloniObjBtn
            // 
            this.ukloniObjBtn.Location = new System.Drawing.Point(35, 275);
            this.ukloniObjBtn.Name = "ukloniObjBtn";
            this.ukloniObjBtn.Size = new System.Drawing.Size(75, 39);
            this.ukloniObjBtn.TabIndex = 2;
            this.ukloniObjBtn.Text = "Ukloni objekat";
            this.ukloniObjBtn.UseVisualStyleBackColor = true;
            this.ukloniObjBtn.Click += new System.EventHandler(this.ukloniObjBtn_Click);
            // 
            // izmeniObjBtn
            // 
            this.izmeniObjBtn.Location = new System.Drawing.Point(35, 181);
            this.izmeniObjBtn.Name = "izmeniObjBtn";
            this.izmeniObjBtn.Size = new System.Drawing.Size(75, 39);
            this.izmeniObjBtn.TabIndex = 1;
            this.izmeniObjBtn.Text = "Izmeni objekat";
            this.izmeniObjBtn.UseVisualStyleBackColor = true;
            this.izmeniObjBtn.Click += new System.EventHandler(this.izmeniObjBtn_Click);
            // 
            // dodajObjBtn
            // 
            this.dodajObjBtn.Location = new System.Drawing.Point(35, 84);
            this.dodajObjBtn.Name = "dodajObjBtn";
            this.dodajObjBtn.Size = new System.Drawing.Size(75, 39);
            this.dodajObjBtn.TabIndex = 0;
            this.dodajObjBtn.Text = "Dodaj objekat";
            this.dodajObjBtn.UseVisualStyleBackColor = true;
            this.dodajObjBtn.Click += new System.EventHandler(this.dodajObjBtn_Click);
            // 
            // ObjektiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.objektiListView);
            this.Name = "ObjektiForma";
            this.Text = "ObjektiForma";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView objektiListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ukloniObjBtn;
        private System.Windows.Forms.Button izmeniObjBtn;
        private System.Windows.Forms.Button dodajObjBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}