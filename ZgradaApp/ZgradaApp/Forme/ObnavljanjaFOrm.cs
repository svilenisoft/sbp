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
    public partial class ObnavljanjaFOrm : Form {

        int idLicence;
        public ObnavljanjaFOrm(int idLicc) {
            idLicence = idLicc;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            new DodavanjeObnavljanjaForm(idLicence, -1, null).ShowDialog();
            fillObnavljanjeList();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite obnavljanje koje zelite da menjate", "Obavestenje");
                return;
            }

            int idOb = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string datum = listView1.SelectedItems[0].SubItems[1].Text;
            new DodavanjeObnavljanjaForm(idLicence, idOb, datum).ShowDialog();
            fillObnavljanjeList();
        }

        private void button3_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite obnavljanje koje zelite da obrisete", "Obavestenje");
                return;
            }

            int idOb = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Da li zelite da obrisete obnavljanje?", "Paznja!", buttons);

            if (result == DialogResult.OK)
                if (DTOManager.obrisiObnavljanje(idOb)) {
                    MessageBox.Show("Uspesno ste obrisali obnavljanje", "Obavestenje");
                }
                else {
                    MessageBox.Show("Doslo je do greske! Obnavljanje nije obrisano!", "Obavestenje");

                }
        }

        private void fillObnavljanjeList() {
            listView1.Items.Clear();
            List<ObnavljanjePregled> o = DTOManager.getObnavljanjaLicence(idLicence);
            foreach (ObnavljanjePregled ob in o) {
                listView1.Items.Add(new ListViewItem(new string[] { ob.id + "", ob.datum }));
            }
            listView1.Refresh();
        }

        private void ObnavljanjaFOrm_Load(object sender, EventArgs e) {
            fillObnavljanjeList();
        }
    }
}
