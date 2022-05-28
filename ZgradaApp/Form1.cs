using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using System.Windows.Forms;
using ZgradaApp.Entiteti;


namespace ZgradaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUcitavanjeZgrade_Click(object sender, EventArgs e)
        {
            try {
                ISession s = DataLayer.GetSession();
                ZgradaApp.Entiteti.Zgrada z = s.Load<ZgradaApp.Entiteti.Zgrada>(1);
                MessageBox.Show(z.adresa);
                s.Close();

            }
            catch (Exception ec) {
                MessageBox.Show(ec.Message+" "+ ec.StackTrace);
            }
        }

        private void btnUcitavanjeUlaza_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ZgradaApp.Entiteti.Ulaz u = s.Load<ZgradaApp.Entiteti.Ulaz>(1);
                MessageBox.Show(u.redni_broj.ToString());
                s.Close();

            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }
        }

        private void btnUcitavanjaUgovora_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ZgradaApp.Entiteti.Ugovor u = s.Load<ZgradaApp.Entiteti.Ugovor>(1);
                MessageBox.Show(u.sifra.ToString());
                s.Close();

            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }

        }

        private void btnUcitavanjeObrazovanja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ZgradaApp.Entiteti.Obrazovanje o = s.Load<ZgradaApp.Entiteti.Obrazovanje>(1);
                MessageBox.Show(o.zvanje);
                s.Close();

            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }
        }

        private void btnUcitavanjeObanvaljanja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ZgradaApp.Entiteti.Obnavljanje o = s.Load<ZgradaApp.Entiteti.Obnavljanje>(1);
                MessageBox.Show(o.datum.ToString());
                s.Close();

            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }
        }

        private void btnUcitavanjeLifta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ZgradaApp.Entiteti.Lift l = s.Load<ZgradaApp.Entiteti.Lift>(1);
                MessageBox.Show(l.nazivProizvodjaca);
                s.Close();

            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }
        }

        private void btnUcitavanjeNivoa_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ZgradaApp.Entiteti.Nivo n = s.Load<ZgradaApp.Entiteti.Nivo>(1);

                MessageBox.Show(n.broj.ToString());
                s.Close();

            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }
        }

        private void brnUcitavanjeObjekta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ZgradaApp.Entiteti.Objekat o = s.Load<ZgradaApp.Entiteti.Objekat>(1);
                if (o.GetType() == typeof(ZgradaApp.Entiteti.Stan))
                {
                    MessageBox.Show(o.status.ToString());

                }
                else if (o.GetType() == typeof(ZgradaApp.Entiteti.Lokal))
                {
                    MessageBox.Show(o.imeFirma);
                }
                else
                    MessageBox.Show(o.redniBr.ToString());
                s.Close();

            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }
        }

        private void btnUcitavanjeOsobe_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ZgradaApp.Entiteti.Osoba o = s.Get<ZgradaApp.Entiteti.Osoba>(1);
                /*if (o.GetType() == typeof(ZgradaApp.Entiteti.Zaposlen))
                {
                    MessageBox.Show(o.brlk.ToString());

                }
                else if (o.GetType() == typeof(ZgradaApp.Entiteti.Upravnik))
                {
                    MessageBox.Show(o.adresa);
                }
                else if (o.GetType() == typeof(ZgradaApp.Entiteti.Stanar))
                    MessageBox.Show(o.lIme);
                else
                    MessageBox.Show(o.prezime);*/
              
                MessageBox.Show(o.prezime);
                s.Close();

            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }

        }

        private void btnUcitavanjeLience_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ZgradaApp.Entiteti.Licenca l = s.Load<ZgradaApp.Entiteti.Licenca>(1);
                MessageBox.Show(l.Id.ToString());
                s.Close();

            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }
        }

        private void btnDodajZgradu_Click(object sender, EventArgs e)
        {
            try {
                ISession s = DataLayer.GetSession();

                Entiteti.Zgrada z = new Entiteti.Zgrada();
                Entiteti.Osoba o = new Upravnik();
                z.adresa = "Provmajska 2";
               
                o.lIme = "Mirko";
                o.prezime = "Aleksic";
                o.imeR = "Djorjde";
                o.jmbg = 1445222684578;
                o.brlk = 452774;
                o.datumRodjenja = new DateTime(1945,3,12);
                o.mestoIzdavanja = "Nis";
                o.adresa = "Provmajska 2";
                o.stan = null;
                o.tip = null;
           
                z.upravnikZgrade = o;
                o.zgrade.Add(z);

                s.Save(o);
                s.Save(z);
                s.Flush();
                MessageBox.Show("Uspesno dodata zgrada");
                s.Close();
            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }
        }

        private void btnVezaManyOne_Click(object sender, EventArgs e)
        {
            try{
                ISession s = DataLayer.GetSession();
                ZgradaApp.Entiteti.Nivo n = s.Load<ZgradaApp.Entiteti.Nivo>(2);
                    
                

                MessageBox.Show(n.zgrada.adresa);
                s.Close();
            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }
        }

        private void btnOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ZgradaApp.Entiteti.Nivo n = s.Load<ZgradaApp.Entiteti.Nivo>(2);
                String str = "";
                foreach (Objekat o in n.objekti)
                {
                    String t = "";
                    if (o.GetType() == typeof(Lokal))
                        t = "lokal";
                    if (o.GetType() == typeof(Stan))
                        t = "stan";
                    if (o.GetType() == typeof(Mesto))
                        t = "mesto";


                    str += t + " " + o.redniBr + "\n";
                }
                MessageBox.Show(str);
                s.Close();
            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }
        }

        private void btnKreiranjeLifta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ZgradaApp.Entiteti.Lift tl= new ZgradaApp.Entiteti.TeretniLift();
                tl.serijskiBroj = 321;
                tl.maxBrOsoba = 0;
                tl.nosivost = 500;
                tl.brDanaKvara =5;
                tl.datumKvara = new DateTime(2000, 2, 3);
                tl.datumServisa = new DateTime(2001, 2, 3);
                tl.zgrada = s.Get<Zgrada>(1);
                tl.nazivProizvodjaca = "MIlkom";
                s.Save(tl);

                ZgradaApp.Entiteti.Lift pl = new ZgradaApp.Entiteti.PutnickiLift();
                pl.serijskiBroj = 131;
                pl.maxBrOsoba = 4;
                pl.nosivost = 0;
                pl.brDanaKvara = 5;
                pl.datumKvara = new DateTime(2000, 2, 3);
                pl.datumServisa = new DateTime(2001, 2, 3);
                pl.zgrada = s.Get<Zgrada>(1);
                pl.nazivProizvodjaca = "Mlkom";
                s.Save(pl);
                s.Close();
                MessageBox.Show("Uspesno kreirani liftovi");
            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }
        }

       /* private void btnKreiranjeOsobe_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

               
                Entiteti.Osoba o = new Vlasnik();
                

                o.lIme = "Mirko";
                o.prezime = "Aleksic";
                o.imeR = "Djorjde";
                o.jmbg = 1222222222278;
                o.brlk = 47874;
                o.datumRodjenja = new DateTime(1945, 3, 12);
                o.mestoIzdavanja = "Nis";
                o.adresa = "Provmajska 2";
                o.stan = s.Get<Objekat>(1);
                o.tip = "CLAN SAVETA";



               
               s.Save(o);
                
                s.Flush();
                MessageBox.Show("Uspesno dodat vlasnik");
                s.Close();
            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Entiteti.Osoba o = new Zaposlen();
                

                o.lIme = "Mirko";
                o.prezime = "Aleksic";
                o.imeR = "Djorjde";
                o.jmbg = 1222333684578;
                o.brlk = 456664;
                o.datumRodjenja = new DateTime(1945, 3, 12);
                o.mestoIzdavanja = "Nis";
                o.adresa = "Provmajska 2";
                o.stan = null;
                o.tip = null;
                o.stanovi.Add(s.Get<Objekat>(1));
                
                

                s.Save(o);
              
                s.Flush();
                MessageBox.Show("Uspesno dodat zposleni");
                s.Close();
            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }

        }

        private void btnKreirajStanara_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Entiteti.Osoba o = new Stanar();
                
                o.lIme = "Mirko";
                o.prezime = "Aleksic";
                o.imeR = "Djorjde";
                o.jmbg = 1445222666578;
                o.brlk = 488884;
                o.datumRodjenja = new DateTime(1945, 3, 12);
                o.mestoIzdavanja = "Nis";
                o.adresa = "Provmajska 2";
                Stan st =(Stan)s.Get<Objekat>(1);
                o.tip = null;


                o.stan = st;
                st.stanari.Add(o);

                s.Save(st);
                s.Save(o);
                s.Flush();
                //MessageBox.Show("Uspesno dodat stanar");
                s.Close();
            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message + " " + ec.StackTrace);
            }
        }

        private void btnKoriscnjeGet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat o = s.Get<Objekat>(2);

                if (o != null)
                {
                    MessageBox.Show(o.nivo.broj.ToString());
                }
                else
                {
                    MessageBox.Show("Ne postoji objekat sa zadatim identifikatorom");
                }


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnKoriscenjeMetodeReferesh_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat o = s.Get<Objekat>(5);

                //obrada podataka o objektu

                s.Refresh(o);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnKreiranjeUpita_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Objekat");

                IList<Objekat> objekti= q.List<Objekat>();

                foreach (Objekat o in objekti)
                {
                    MessageBox.Show(o.redniBr.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ZgradeForm().Show();
        }
    }
}
