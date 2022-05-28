
namespace ZgradaApp.Forme {
    partial class StanariForm {
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
            this.stanariListView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodajStanara = new System.Windows.Forms.Button();
            this.btnIzmeniStanara = new System.Windows.Forms.Button();
            this.brnObrisiStanara = new System.Windows.Forms.Button();
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
            // stanariListView
            // 
            this.stanariListView.FullRowSelect = true;
            this.stanariListView.HideSelection = false;
            this.stanariListView.Location = new System.Drawing.Point(12, 46);
            this.stanariListView.MultiSelect = false;
            this.stanariListView.Name = "stanariListView";
            this.stanariListView.Size = new System.Drawing.Size(656, 392);
            this.stanariListView.TabIndex = 1;
            this.stanariListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.brnObrisiStanara);
            this.groupBox1.Controls.Add(this.btnIzmeniStanara);
            this.groupBox1.Controls.Add(this.btnDodajStanara);
            this.groupBox1.Location = new System.Drawing.Point(677, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 400);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnDodajStanara
            // 
            this.btnDodajStanara.Location = new System.Drawing.Point(18, 91);
            this.btnDodajStanara.Name = "btnDodajStanara";
            this.btnDodajStanara.Size = new System.Drawing.Size(75, 36);
            this.btnDodajStanara.TabIndex = 0;
            this.btnDodajStanara.Text = "Dodaj stanara";
            this.btnDodajStanara.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniStanara
            // 
            this.btnIzmeniStanara.Location = new System.Drawing.Point(18, 182);
            this.btnIzmeniStanara.Name = "btnIzmeniStanara";
            this.btnIzmeniStanara.Size = new System.Drawing.Size(75, 36);
            this.btnIzmeniStanara.TabIndex = 1;
            this.btnIzmeniStanara.Text = "Izmeni stanara";
            this.btnIzmeniStanara.UseVisualStyleBackColor = true;
            // 
            // brnObrisiStanara
            // 
            this.brnObrisiStanara.Location = new System.Drawing.Point(18, 273);
            this.brnObrisiStanara.Name = "brnObrisiStanara";
            this.brnObrisiStanara.Size = new System.Drawing.Size(75, 36);
            this.brnObrisiStanara.TabIndex = 2;
            this.brnObrisiStanara.Text = "Obrisi stanara";
            this.brnObrisiStanara.UseVisualStyleBackColor = true;
            // 
            // StanariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stanariListView);
            this.Controls.Add(this.label1);
            this.Name = "StanariForm";
            this.Text = "StanariForm";
            this.Load += new System.EventHandler(this.StanariForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView stanariListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button brnObrisiStanara;
        private System.Windows.Forms.Button btnIzmeniStanara;
        private System.Windows.Forms.Button btnDodajStanara;
    }
}