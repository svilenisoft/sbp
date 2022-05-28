using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using System.Text;
using System.Threading.Tasks;
using ZgradaApp.Entiteti;
using System.Windows.Forms;

namespace ZgradaApp {
    class DTOManager {
        #region Zgrade
        public static List<ZgradaPregled> getSveZgrade() {
            List<ZgradaPregled> zgrade = new List<ZgradaPregled>();
            try {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zgrada> sveZgrade = from z in s.Query<Zgrada>() orderby z.Id select z;

                foreach (Zgrada z in sveZgrade) {
                    String ime = z.upravnikZgrade.lIme + " (" + z.upravnikZgrade.imeR + ") " + z.upravnikZgrade.prezime;
                    zgrade.Add(new ZgradaPregled(z.Id, z.upravnikZgrade.Id, ime, z.adresa));
                }

                s.Close();
            } catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }

            return zgrade;
        }


        public static void dodajZgradu(string adresa, int id) {
            try {
                ISession s = DataLayer.GetSession();
                Zgrada z = new Zgrada();
                z.adresa = adresa;
                Osoba o = s.Load<Osoba>(id);
                z.upravnikZgrade = o;

                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();


            } catch (Exception e) {

            }
        }

        public static void izmeniZgradu(string adresa, int idUpravnika, int idZgrade) {
            try {
                ISession s = DataLayer.GetSession();
                Zgrada z = s.Get<Zgrada>(idZgrade);
                z.adresa = adresa;
                Osoba o = s.Load<Osoba>(idUpravnika);
                z.upravnikZgrade = o;

                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();


            } catch (Exception e) {

            }
        }


        public static void obrisiZgradu(int idZgrade) {
            try {
                ISession s = DataLayer.GetSession();

                Zgrada o = s.Load<Zgrada>(idZgrade);

                s.Delete(o);
                s.Flush();

                s.Close();
            } catch (Exception ec) {
                //handle exceptions
            }
        }
        #endregion

        #region Nivoi
        public static List<NivoPregled> getSviNivoiZgrade(int idZgrade) {
            List<NivoPregled> zgrade = new List<NivoPregled>();
            try {
                ISession s = DataLayer.GetSession();

                IEnumerable<StamenbeniNivo> stambeniNivoi = from z
                                                in s.Query<StamenbeniNivo>()
                                                            orderby z.broj
                                                            where z.zgrada.Id == idZgrade
                                                            orderby z.broj descending
                                                            select z;

                foreach (StamenbeniNivo nio in stambeniNivoi) {
                    int brO = (from o in s.Query<Stan>() where o.nivo.Id == nio.Id select o).Count();
                    zgrade.Add(new NivoPregled(nio.Id, nio.broj, brO, "Stambeni nivo"));
                }

                IEnumerable<PoslovniNivo> poslovniNivoi = from z
                                                in s.Query<PoslovniNivo>()
                                                          orderby z.broj
                                                          where z.zgrada.Id == idZgrade
                                                          orderby z.broj descending
                                                          select z;

                foreach (PoslovniNivo nio in poslovniNivoi) {
                    int brO = (from o in s.Query<Lokal>() where o.nivo.Id == nio.Id select o).Count();
                    zgrade.Add(new NivoPregled(nio.Id, nio.broj, brO, "Poslovni nivo"));
                }





                IEnumerable<GarazniNivo> garazniNivoi = from z
                                                in s.Query<GarazniNivo>()
                                                        orderby z.broj
                                                        where z.zgrada.Id == idZgrade
                                                        orderby z.broj descending
                                                        select z;

                foreach (GarazniNivo nio in garazniNivoi) {
                    int brO = (from o in s.Query<Mesto>() where o.nivo.Id == nio.Id select o).Count();
                    zgrade.Add(new NivoPregled(nio.Id, nio.broj, brO, "Garazni nivo"));
                }


                s.Close();
            } catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }

            return zgrade;
        }


        public static bool dodajNivo(int idZgrade, string brNivoa, string tip) {
            try {
                ISession s = DataLayer.GetSession();
                Nivo nivo = null;
                switch (tip) {
                    case "Stambeni nivo":
                        nivo = new StamenbeniNivo();
                        break;
                    case "Poslovni nivo":
                        nivo = new PoslovniNivo();
                        break;
                    case "Garazni nivo":
                        nivo = new GarazniNivo();
                        break;

                }
                nivo.broj = Int32.Parse(brNivoa);
                nivo.zgrada = s.Get<Zgrada>(idZgrade);

                s.SaveOrUpdate(nivo);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }
            return true;
        }

        internal static bool izmeniNivo(int idNivoa, string brNivoa) {
            try {
                ISession s = DataLayer.GetSession();
                Nivo n = s.Get<Nivo>(idNivoa);
                n.broj = Int32.Parse(brNivoa);
                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }

            return true;
        }

        internal static bool obrisiNivo(int idNivoa) {
            try {
                ISession s = DataLayer.GetSession();

                Nivo o = s.Load<Nivo>(idNivoa);

                s.Delete(o);
                s.Flush();

                s.Close();
            } catch (Exception ec) {
                return false;
            }
            return true;
        }

        #endregion

        #region Upravnici
        public static List<UpravnikSimplePregled> getSviUpravnici() {
            List<UpravnikSimplePregled> upravnici = new List<UpravnikSimplePregled>();
            try {
                ISession s = DataLayer.GetSession();

                IEnumerable<Upravnik> sviUpravnici = from u in s.Query<Upravnik>() select u;

                foreach (Upravnik u in sviUpravnici) {
                    String ime = u.lIme + " (" + u.imeR + ") " + u.prezime;
                    upravnici.Add(new UpravnikSimplePregled(u.Id, ime));
                }

                IEnumerable<BlagajnikUpravnik> blagajnikUpravnik = from u in s.Query<BlagajnikUpravnik>() select u;

                foreach (BlagajnikUpravnik u in blagajnikUpravnik) {
                    String ime = u.lIme + " (" + u.imeR + ") " + u.prezime;
                    upravnici.Add(new UpravnikSimplePregled(u.Id, ime));
                }

                IEnumerable<ClanSavetaUpravnik> clanSavetaUpravnik = from u in s.Query<ClanSavetaUpravnik>() select u;

                foreach (ClanSavetaUpravnik u in clanSavetaUpravnik) {
                    String ime = u.lIme + " (" + u.imeR + ") " + u.prezime;
                    upravnici.Add(new UpravnikSimplePregled(u.Id, ime));
                }

                IEnumerable<PredsednikUpravnik> predsednikUpravnik = from u in s.Query<PredsednikUpravnik>() select u;

                foreach (PredsednikUpravnik u in predsednikUpravnik) {
                    String ime = u.lIme + " (" + u.imeR + ") " + u.prezime;
                    upravnici.Add(new UpravnikSimplePregled(u.Id, ime));
                }


                s.Close();
            } catch (Exception ec) {
                //handle exceptions
            }

            return upravnici;
        }





        #endregion

        #region Objekti
        public static List<ObjekatPregled> getSviObjektiNivoa(int idNivoa, string tip) {
            List<ObjekatPregled> objekti = new List<ObjekatPregled>();
            try {
                ISession s = DataLayer.GetSession();

                IEnumerable<Objekat> sviObjekti = null;

                switch (tip) {
                    case "Stambeni nivo":
                        sviObjekti = from z in s.Query<Stan>() orderby z.redniBr where z.nivo.Id == idNivoa select z;
                        break;
                    case "Poslovni nivo":
                        sviObjekti = from z in s.Query<Lokal>() orderby z.redniBr where z.nivo.Id == idNivoa select z;
                        break;
                    case "Garazni nivo":
                        sviObjekti = from z in s.Query<Mesto>() orderby z.redniBr where z.nivo.Id == idNivoa select z;
                        break;
                }

                foreach (Objekat o in sviObjekti) {
                    string data = "";
                    switch (tip) {
                        case "Stambeni nivo":
                            data = o.vlasnik.lIme + " (" + o.vlasnik.imeR + ") " + o.vlasnik.prezime;
                            break;
                        case "Poslovni nivo":
                            data = o.imeFirma;
                            break;
                        case "Garazni nivo":
                            if (o.status != 0)
                                data = o.regBr;
                            else
                                data = "Mesto nije rezervisano";
                            break;
                    }
                    objekti.Add(new ObjekatPregled(o.Id, o.redniBr, data));
                }

                s.Close();
            } catch (Exception ec) {
                Console.WriteLine(ec.StackTrace);
                MessageBox.Show(ec.Message);
            }

            return objekti;
        }
        #endregion
        #region Liftovi
        public static List<LiftPregled> getSviLiftoviZgrade(int idZgrade)
        {
            List<LiftPregled> zgrade = new List<LiftPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<TeretniLift> teretniLiftovi= from l
                                                in s.Query<TeretniLift>()
                                                            orderby l.Id
                                                            where l.zgrada.Id == idZgrade
                                                            orderby l.Id descending
                                                            select l;

                foreach (TeretniLift lift in teretniLiftovi)
                {
                    zgrade.Add(new LiftPregled(lift.Id,lift.serijskiBroj,lift.brDanaKvara,lift.nosivost,lift.maxBrOsoba,"teretni",lift.nazivProizvodjaca,lift.datumServisa,lift.datumKvara));
                }

                IEnumerable<PutnickiLift> putnickiLiftovi = from l
                                                 in s.Query<PutnickiLift>()
                                                          orderby l.Id
                                                          where l.zgrada.Id == idZgrade
                                                          orderby l.Id descending
                                                          select l;

                foreach (PutnickiLift lift in putnickiLiftovi)
                {
                    zgrade.Add(new LiftPregled(lift.Id, lift.serijskiBroj, lift.brDanaKvara, lift.nosivost, lift.maxBrOsoba, "putnicki", lift.nazivProizvodjaca, lift.datumServisa, lift.datumKvara));
                }



                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return zgrade;
        }


        public static bool dodajLift(int idZgrade, string serisjkibr, string brDanaKvara,string nosivost,string maxBrOsoba,string tip,string nazivPropzivodjaca,string datumServisa,string datumKvara)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Lift lift= null;
                switch (tip)
                {
                    case "teretni":
                        lift = new TeretniLift();
                        break;
                    case "putnicki":
                        lift = new PutnickiLift();
                        break;
                }
                lift.serijskiBroj = Int32.Parse(serisjkibr);
                lift.brDanaKvara = Int32.Parse(brDanaKvara);
                lift.nosivost = Int32.Parse(nosivost);
                lift.maxBrOsoba = Int32.Parse(maxBrOsoba);
                lift.nazivProizvodjaca = nazivPropzivodjaca;
                lift.datumServisa = DateTime.Parse(datumServisa);
                lift.datumKvara = DateTime.Parse(datumKvara);

                lift.zgrada = s.Get<Zgrada>(idZgrade);

                s.SaveOrUpdate(lift);

                s.Flush();

                s.Close();


            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        internal static bool izmeniLift(int idLifta, string datumServisa,string datumKvara,string brDanaKvara)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Lift l = s.Get<Lift>(idLifta);
                l.brDanaKvara= Int32.Parse(brDanaKvara);
                l.datumServisa = DateTime.Parse(datumServisa);
                l.datumKvara = DateTime.Parse(datumKvara);
                s.SaveOrUpdate(l);

                s.Flush();

                s.Close();


            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        internal static bool obrisiLift(int idLifta)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lift l = s.Load<Lift>(idLifta);

                s.Delete(l);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                return false;
            }
            return true;
        }

        #endregion
    }
}
