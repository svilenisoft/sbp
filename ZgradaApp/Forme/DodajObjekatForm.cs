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
        int idNivoa;

        public DodajObjekatForm(int idNivoa, string tip) {
            this.idNivoa = idNivoa;
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
            List<VlasnikPregled> vlasnici = DTOManager.getSviLjudi();
            vlasnikComboBox.Items.Clear();
            foreach (VlasnikPregled v in vlasnici) {
                vlasnikComboBox.Items.Add(v.naziv);
            }
            vlasnikComboBox.Refresh();
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
                    dodajPoslovniNivo();
                    break;
                case "Garazni nivo":
                    dodajGarazniNivo();
                    break;
            }
        }

        private void dodajPoslovniNivo() {
            if (brObjektaTxtBox.Text.Length == 0) {
                MessageBox.Show("Morate uneti redi broj objekta!", "Paznja!");
                return;
            }
            if (imeFirmeTxtBox.Text.Trim().Length == 0) {
                MessageBox.Show("Morate uneti ime firme!", "Paznja!");
                return;
            }


            string poruka;
            poruka = "Da li zelite da dodate poslovni objekat?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                if (DTOManager.dodajPoslovniObjekat(idNivoa, imeFirmeTxtBox.Text.Trim(), Int32.Parse(brObjektaTxtBox.Text))) {
                    MessageBox.Show("Uspesno ste dodali poslovni objekat!", "Obavestenje");
                    this.Close();
                }
                else {
                    MessageBox.Show("Doslo je do greske! Objekat nije dodat!");
                }
            }
        }

        private void dodajGarazniNivo() {
            if (brObjektaTxtBox.Text.Length == 0) {
                MessageBox.Show("Morate uneti redi broj objekta!", "Paznja!");
                return;
            }


            string poruka;
            poruka = "Da li zelite da dodate parking mesto?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                if (DTOManager.dodajGaraznoMesto(idNivoa, regBrTxtBox.Text.Trim(), Int32.Parse(brObjektaTxtBox.Text))) {
                    MessageBox.Show("Uspesno ste dodali garazno mesto!", "Obavestenje");
                    this.Close();
                }
                else {
                    MessageBox.Show("Doslo je do greske! Objekat nije dodat!");
                }
            }
        }

        private void noviVlasnikBtn_Click(object sender, EventArgs e) {

        }
    }
}
