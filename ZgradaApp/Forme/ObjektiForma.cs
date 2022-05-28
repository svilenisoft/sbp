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
    public partial class ObjektiForma : Form {

        int idNivoa;
        string tip;

        public ObjektiForma(int idNivoa, string tip, int redniBr) {
            this.idNivoa = idNivoa;
            this.tip = tip;
            InitializeComponent();

            switch (tip) {
                case "Stambeni nivo":
                    objektiListView.Columns.Add("Ime vlasnika");
                    break;
                case "Poslovni nivo":
                    objektiListView.Columns.Add("Ime firme");
                    break;
                case "Garazni nivo":
                    objektiListView.Columns.Add("Registarski broj");
                    break;
            }

            label1.Text = tip + " : " + redniBr;
            objektiListView.Columns[2].Width = 200;
            objektiListView.Columns[2].TextAlign = HorizontalAlignment.Center;
            fillObjektiList();
        }

        private void fillObjektiList() {
            objektiListView.Items.Clear();

            List<ObjekatPregled> objekti = DTOManager.getSviObjektiNivoa(idNivoa, tip);
            foreach (ObjekatPregled o in objekti) {
                ListViewItem item = new ListViewItem(new string[] { o.id + "", o.redniBr + "", o.data });
                objektiListView.Items.Add(item);
            }

            objektiListView.Refresh();
        }

        private void dodajObjBtn_Click(object sender, EventArgs e) {

        }

        private void izmeniObjBtn_Click(object sender, EventArgs e) {

        }

        private void ukloniObjBtn_Click(object sender, EventArgs e) {

        }
    }
}
