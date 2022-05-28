using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZgradaApp.Forme {
    
    public partial class DodajObjekatForm : Form {

        string tip;


        public DodajObjekatForm(string tip) {
            this.tip = tip;
            InitializeComponent();


        }

        private void DodajObjekatForm_Load(object sender, EventArgs e) {
            switch (tip) {
                case "Stambeni nivo":
                    label1.Text = "Dodavanje stana";
                    label1.Left = (this.Width - label1.Width) / 2;
                    dodajStanPannel.Visible = true;
                    dodajLokalPannel.Visible = false;
                    dodajMestoPannel.Visible = false;
                    fillVlasniciComboBox();
                    break;
                case "Poslovni nivo":
                    label1.Text = "Dodavanje poslovnog objekta";
                    label1.Left = (this.Width - label1.Width) / 2;
                    dodajStanPannel.Visible = false;
                    dodajLokalPannel.Visible = true;
                    dodajMestoPannel.Visible = false;
                    break;
                case "Garazni nivo":
                    label1.Text = "Dodavanje garaznog mesta";
                    label1.Left = (this.Width - label1.Width) / 2;
                    dodajStanPannel.Visible = false;
                    dodajLokalPannel.Visible = false;
                    dodajMestoPannel.Visible = true;
                    break;
            }
        }

        private void fillVlasniciComboBox() {
            //List<VlasnikPregled> vlasnici = DTOManager.getSviLjudi();
            //upravnikComboBox.Items.Clear();
            //vlasnikComboBox.Items.Clear();
            //foreach (UpravnikSimplePregled u in upravnici) {
            //    upravnikComboBox.Items.Add(u.naziv);
            //}
            //idZgrade = -1;
        }

        private void brObjektaTxtBox_TextChanged(object sender, EventArgs e) {
            if (brObjektaTxtBox.Text.Equals("-"))
                return;
            if (!int.TryParse(brObjektaTxtBox.Text, out int r)) {
                brObjektaTxtBox.Text = "";
            }
        }

        private void upisBtn_Click(object sender, EventArgs e) {
            switch (tip) {
                case "Stambeni nivo":
                    break;
                case "Poslovni nivo":
                    break;
                case "Garazni nivo":
                    break;
            }
        }

        private void noviVlasnikBtn_Click(object sender, EventArgs e) {

        }
    }
}
