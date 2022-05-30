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


        public static bool obrisiZgradu(int idZgrade) {
            ITransaction transaction = null;
            try {
                ISession s = DataLayer.GetSession();
                transaction = s.BeginTransaction();

                IEnumerable<Ugovor> ugovori = from u in s.Query<Ugovor>() where u.zgrada.Id == idZgrade select u;
                foreach (Ugovor u in ugovori) {
                    s.Delete(u);
                }

                IEnumerable<Nivo> nivoi = from nivo in s.Query<Nivo>() where nivo.zgrada.Id == idZgrade select nivo;
                foreach (Nivo nivo in nivoi) {
                    IEnumerable<Lokal> lokali = from lok in s.Query<Lokal>() where lok.nivo.Id == nivo.Id select lok;
                    foreach (Lokal lokal in lokali) s.Delete(lokal);
                    IEnumerable<Mesto> mesta = from lok in s.Query<Mesto>() where lok.nivo.Id == nivo.Id select lok;
                    foreach (Mesto mesto in mesta) s.Delete(mesto);
                    IEnumerable<Stan> stanovi = from stan in s.Query<Stan>() where stan.nivo.Id == nivo.Id select stan;
                    foreach (Stan stan in stanovi) {
                        foreach (Osoba osoba in stan.stanari)
                            if (osoba.Id != stan.vlasnik.Id)
                                s.Delete(osoba);
                        s.Delete(stan);

                        try {
                            s.Delete(stan.vlasnik);
                        } catch (Exception) {

                        }
                    }
                }

                Zgrada zgrada = s.Load<Zgrada>(idZgrade);
                s.Delete(zgrada);
                s.Flush();
                transaction.Commit();
                s.Close();
            } catch (Exception ec) {
                if (transaction != null)
                    transaction.Rollback();
                return false;
            }
            return true;
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
            ITransaction transaction = null;
            try {
                ISession s = DataLayer.GetSession();
                transaction = s.BeginTransaction();

                Nivo o = s.Load<Nivo>(idNivoa);
                IEnumerable<Lokal> lokali = from lok in s.Query<Lokal>() where lok.nivo.Id == o.Id select lok;
                foreach (Lokal lokal in lokali) s.Delete(lokal);
                IEnumerable<Mesto> mesta = from lok in s.Query<Mesto>() where lok.nivo.Id == o.Id select lok;
                foreach (Mesto mesto in mesta) s.Delete(mesto);
                IEnumerable<Stan> stanovi = from stan in s.Query<Stan>() where stan.nivo.Id == o.Id select stan;
                foreach (Stan stan in stanovi) {
                    foreach (Osoba osoba in stan.stanari)
                        if (osoba.Id != stan.vlasnik.Id)
                            s.Delete(osoba);
                    s.Delete(stan);

                    try {
                        s.Delete(stan.vlasnik);
                    } catch (Exception) {

                    }
                }

                s.Delete(o);
                s.Flush();
                transaction.Commit();
                s.Close();
            } catch (Exception ec) {
                if (transaction != null)
                    transaction.Rollback();
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

        internal static bool dodajPoslovniObjekat(int idNivoa, string imeFirme, int rbr) {
            try {
                ISession s = DataLayer.GetSession();
                Lokal l = new Lokal();
                l.imeFirma = imeFirme;
                l.nivo = s.Get<Nivo>(idNivoa);
                l.redniBr = rbr;

                s.SaveOrUpdate(l);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }
            return true;
        }
        internal static bool izmeniPoslovniObjekat(int idObjekta, string imeFirme, int rbr) {
            try {
                ISession s = DataLayer.GetSession();

                Lokal l = s.Get<Lokal>(idObjekta);
                l.redniBr = rbr;
                l.imeFirma = imeFirme;
                s.SaveOrUpdate(l);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }

            return true;
        }
        internal static bool dodajGaraznoMesto(int idNivoa, string reg, int rbr) {
            try {
                ISession s = DataLayer.GetSession();
                Mesto m = new Mesto();
                if (reg.Length == 0) {
                    m.status = 0;
                    m.regBr = null;
                }
                else {
                    m.status = 1;
                    m.regBr = reg;
                }
                m.nivo = s.Get<Nivo>(idNivoa);
                m.redniBr = rbr;
                s.SaveOrUpdate(m);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }
            return true;
        }
        internal static bool izmeniGaraznoMesto(int idObjekta, string regBr, int rbr) {
            try {
                ISession s = DataLayer.GetSession();

                Mesto l = s.Get<Mesto>(idObjekta);
                l.redniBr = rbr;
                l.regBr = regBr;
                s.SaveOrUpdate(l);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }

            return true;
        }
        internal static bool dodajStan(int idNivoa, string rbr, int idVlasnika) {
            try {
                ISession s = DataLayer.GetSession();
                Stan l = new Stan();
                l.vlasnik = s.Get<Osoba>(idVlasnika);
                l.nivo = s.Get<Nivo>(idNivoa);
                l.redniBr = int.Parse(rbr);

                s.SaveOrUpdate(l);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }
            return true;
        }
        internal static bool izmeniStan(int idObjekta, string rbr, int idVlasnika) {
            try {
                ISession s = DataLayer.GetSession();

                Stan l = s.Get<Stan>(idObjekta);
                l.redniBr = int.Parse(rbr);
                if (l.vlasnik.stanovi.Count == 1 && l.vlasnik.Id != idVlasnika) {
                    l.vlasnik.fvlasnik = 0;
                    l.vlasnik.tip = null;
                }
                l.vlasnik = s.Get<Osoba>(idVlasnika);
                s.SaveOrUpdate(l);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        internal static bool obrisiObjekat(int idObjekta) {
            ITransaction transaction = null;
            try {
                ISession s = DataLayer.GetSession();

                Objekat o = s.Load<Objekat>(idObjekta);
                foreach (Osoba osoba in o.stanari)
                    try {
                        if (osoba.fzaposleni == 0)
                            s.Delete(osoba);
                        else {
                            osoba.fstanar = 0;
                            osoba.stan = null;
                        }
                    } catch (Exception) {

                    }
                s.Delete(o);
                s.Flush();
                transaction.Commit();
                s.Close();
            } catch (Exception ec) {
                if (transaction != null)
                    transaction.Rollback();
                return false;
            }
            return true;
        }
        #endregion

        #region Osobe

        internal static List<VlasnikPregled> getSveOsobe() {
            List<VlasnikPregled> osobe = new List<VlasnikPregled>();
            try {
                ISession s = DataLayer.GetSession();
                IEnumerable<Osoba> sveOsobe = from o in s.Query<Osoba>() select o;
                foreach (Osoba osoba in sveOsobe) {
                    if (osoba.brojeviTelefona.Count > 0)
                        osobe.Add(new VlasnikPregled(osoba.Id, osoba.lIme, osoba.imeR, osoba.prezime, osoba.brojeviTelefona[0].brojTelefona, osoba.adresa, osoba.tip, osoba.jmbg + ""));
                    else
                        osobe.Add(new VlasnikPregled(osoba.Id, osoba.lIme, osoba.imeR, osoba.prezime, "", osoba.adresa, osoba.tip, osoba.jmbg + ""));

                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return osobe;
        }
        internal static bool izmeniOsobu(int idOsobe, long jmbg, string ime, string imer, string prezime, string telefon, string adresa, int tip) {
            try {
                ISession s = DataLayer.GetSession();
                Osoba o = s.Get<Osoba>(idOsobe);
                o.lIme = ime;
                o.jmbg = jmbg;
                o.imeR = imer;
                o.prezime = prezime;
                o.fvlasnik = 1;
                BrojTelefonaOsobe broj = new BrojTelefonaOsobe() { IdOsobe = o, brojTelefona = telefon };
                bool have = false;
                foreach (BrojTelefonaOsobe b in o.brojeviTelefona)
                    if (b.brojTelefona.Equals(telefon))
                        have = true;

                if (!have)
                    o.brojeviTelefona.Add(broj);
                o.adresa = adresa;

                switch (tip) {
                    case 0:
                        o.tip = "CLAN SAVETA";
                        break;
                    case 1:
                        o.tip = "PREDSEDNIK";
                        break;
                    case 2:
                        o.tip = "BLAGAJNIK";
                        break;
                }
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();

            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        internal static bool dodajOsobu(long jmbg, string ime, string imer, string prezime, string telefon, string adresa, int tip) {
            try {
                ISession s = DataLayer.GetSession();
                switch (tip) {
                    case 0:
                        ClanSaveta clan = new ClanSaveta {
                            jmbg = jmbg,
                            lIme = ime,
                            imeR = imer,
                            prezime = prezime,
                            adresa = adresa
                        };
                        clan.brojeviTelefona.Add(new BrojTelefonaOsobe() { IdOsobe = clan, brojTelefona = telefon });
                        s.SaveOrUpdate(clan);
                        break;
                    case 1:
                        Predsednik predsednik = new Predsednik {
                            jmbg = jmbg,
                            lIme = ime,
                            imeR = imer,
                            prezime = prezime,
                            adresa = adresa
                        };
                        predsednik.brojeviTelefona.Add(new BrojTelefonaOsobe() { IdOsobe = predsednik, brojTelefona = telefon });
                        s.SaveOrUpdate(predsednik);
                        break;
                    case 2:
                        Blagajnik blagajnik = new Blagajnik {
                            jmbg = jmbg,
                            lIme = ime,
                            imeR = imer,
                            prezime = prezime,
                            adresa = adresa
                        };
                        blagajnik.brojeviTelefona.Add(new BrojTelefonaOsobe() { IdOsobe = blagajnik, brojTelefona = telefon });
                        s.SaveOrUpdate(blagajnik);
                        break;
                }
                s.Flush();
                s.Close();

            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        #endregion

        #region Stanari
        internal static List<OsobaPregled> getStanariStana(int idStana) {
            List<OsobaPregled> osobe = new List<OsobaPregled>();
            try {
                ISession s = DataLayer.GetSession();
                Stan stan = s.Get<Stan>(idStana);
                foreach (Osoba osoba in stan.stanari) {
                    osobe.Add(new OsobaPregled(osoba.Id, osoba.lIme + " " + osoba.prezime));
                }

            } catch (Exception e) {
                Console.WriteLine(e.Message);

            }
            return osobe;
        }

        internal static bool dodajStanara(int idStana, string naziv) {
            try {
                ISession s = DataLayer.GetSession();
                Stanar stanar = new Stanar();
                Stan stan = s.Load<Stan>(idStana);
                stanar.stan = stan;
                string[] split = naziv.Split(' ');
                stanar.lIme = split[0];
                stanar.prezime = split[split.Length - 1];

                s.SaveOrUpdate(stanar);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return false;
            }
            return true;
        }

        internal static bool izmeniStanara(int idStanara, string naziv) {
            try {
                ISession s = DataLayer.GetSession();
                Stanar stanar = s.Get<Stanar>(idStanara);

                string[] split = naziv.Split(' ');
                stanar.lIme = split[0];
                stanar.prezime = split[split.Length - 1];

                s.SaveOrUpdate(stanar);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }
            return true;
        }

        internal static bool obrisiStanara(int idOStanara) {
            try {
                ISession s = DataLayer.GetSession();

                Stanar o = s.Load<Stanar>(idOStanara);
                if (o.stan.vlasnik.Id == idOStanara) {
                    s.Close();
                    return false;
                }

                s.Delete(o);
                s.Flush();

                s.Close();
            } catch (Exception ec) {
                return false;
            }
            return true;
        }
        #endregion

        #region Liftovi
        public static List<LiftPregled> getSviLiftoviZgrade(int idZgrade) {
            List<LiftPregled> zgrade = new List<LiftPregled>();
            try {
                ISession s = DataLayer.GetSession();

                IEnumerable<TeretniLift> teretniLiftovi = from l
                                                 in s.Query<TeretniLift>()
                                                          orderby l.Id
                                                          where l.zgrada.Id == idZgrade
                                                          orderby l.Id descending
                                                          select l;

                foreach (TeretniLift lift in teretniLiftovi) {
                    zgrade.Add(new LiftPregled(lift.Id, lift.serijskiBroj, lift.brDanaKvara, lift.nosivost, lift.maxBrOsoba, "teretni", lift.nazivProizvodjaca, lift.datumServisa, lift.datumKvara));
                }

                IEnumerable<PutnickiLift> putnickiLiftovi = from l
                                                 in s.Query<PutnickiLift>()
                                                            orderby l.Id
                                                            where l.zgrada.Id == idZgrade
                                                            orderby l.Id descending
                                                            select l;

                foreach (PutnickiLift lift in putnickiLiftovi) {
                    zgrade.Add(new LiftPregled(lift.Id, lift.serijskiBroj, lift.brDanaKvara, lift.nosivost, lift.maxBrOsoba, "putnicki", lift.nazivProizvodjaca, lift.datumServisa, lift.datumKvara));
                }



                s.Close();
            } catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }

            return zgrade;
        }


        public static bool dodajLift(int idZgrade, string serisjkibr, string brDanaKvara, string nosivost, string maxBrOsoba, string tip, string nazivPropzivodjaca, string datumServisa, string datumKvara) {
            try {
                ISession s = DataLayer.GetSession();
                Lift lift = null;
                switch (tip) {
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
                if (datumKvara.Length != 0)
                    lift.datumKvara = DateTime.Parse(datumKvara);

                lift.zgrada = s.Get<Zgrada>(idZgrade);

                s.SaveOrUpdate(lift);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }
            return true;
        }

        internal static bool izmeniLift(int idLifta, string serijskiBroj, string nazivProizvodjaca, string datumServisa, string datumKvara, string brDanaKvara, string nosivost, string maxBrOsoba) {
            try {
                ISession s = DataLayer.GetSession();
                Lift l = s.Get<Lift>(idLifta);

                l.serijskiBroj = Int32.Parse(serijskiBroj);
                l.nazivProizvodjaca = nazivProizvodjaca;
                l.brDanaKvara = Int32.Parse(brDanaKvara);
                l.datumServisa = DateTime.Parse(datumServisa);
                if (datumKvara.Length > 0)
                    l.datumKvara = DateTime.Parse(datumKvara);
                l.brDanaKvara = Int32.Parse(brDanaKvara);
                l.nosivost = Int32.Parse(nosivost);
                l.maxBrOsoba = Int32.Parse(maxBrOsoba);
                s.SaveOrUpdate(l);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                return false;
            }

            return true;
        }

        internal static bool obrisiLift(int idLifta) {
            try {
                ISession s = DataLayer.GetSession();

                Lift l = s.Load<Lift>(idLifta);

                s.Delete(l);
                s.Flush();

                s.Close();
            } catch (Exception ec) {
                return false;
            }
            return true;
        }

        #endregion

        #region Ulazi
        public static List<UlazPregled> getSviUlaziZgrade(int idZgrade) {
            List<UlazPregled> ulazi = new List<UlazPregled>();
            try {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ulaz> ulazs = from z in s.Query<Ulaz>() where z.zgrada.Id == idZgrade orderby z.Id select z;

                foreach (Ulaz u in ulazs) {
                    string prismotra;
                    if (u.kamera == 1)
                        prismotra = "Ima kameru";
                    else
                        prismotra = "Nema kameru";
                    string vO = u.vremeOtvaranja.ToString("HH:mm:ss");
                    string vZ = u.vremeZatvaranja.ToString("HH:mm:ss");
                    ulazi.Add(new UlazPregled(u.Id, u.redni_broj, prismotra, vO, vZ));
                }

                s.Close();
            } catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }

            return ulazi;
        }

        internal static bool dodajUlaz(int idZgrade, string rbr, string kamera, DateTime vremeOtvaranja, DateTime vremeZatvaranja) {
            try {
                ISession s = DataLayer.GetSession();
                Ulaz z = new Ulaz {
                    zgrada = s.Get<Zgrada>(idZgrade),
                    redni_broj = Int32.Parse(rbr),
                    kamera = kamera.Equals("DA") ? 1 : 0,
                    vremeOtvaranja = vremeOtvaranja,
                    vremeZatvaranja = vremeZatvaranja
                };

                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }
            return true;
        }

        internal static bool izmeniUlaz(int idUlaza, string rbr, string kamera, DateTime vremeOtvaranja, DateTime vremeZatvaranja) {
            try {
                ISession s = DataLayer.GetSession();
                Ulaz z = s.Get<Ulaz>(idUlaza);

                z.redni_broj = Int32.Parse(rbr);
                z.kamera = kamera.Equals("DA") ? 1 : 0;
                z.vremeOtvaranja = vremeOtvaranja;
                z.vremeZatvaranja = vremeZatvaranja;

                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }
            return true;
        }

        internal static bool obrisiUlaz(int idUlaza) {
            try {
                ISession s = DataLayer.GetSession();

                Ulaz z = s.Get<Ulaz>(idUlaza);

                s.Delete(z);
                s.Flush();
                s.Close();

            } catch (Exception e) {
                return false;
            }
            return true;
        }
        #endregion

        #region Ugovori
        internal static List<UgovorPregled> getUgovoriSaZgradom(int idZgrade) {
            List<UgovorPregled> ugovori = new List<UgovorPregled>();
            try {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ugovor> sviUgovori = from z in s.Query<Ugovor>() where z.zgrada.Id == idZgrade select z;
                foreach (Ugovor u in sviUgovori) {
                    ugovori.Add(new UgovorPregled(u.Id, u.sifra, u.periodVazenja, u.datum.ToString("dd.MM.yyyy"), u.datum.AddYears(u.periodVazenja).ToString("dd.MM.yyyy")));
                }

                s.Close();
            } catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }

            return ugovori;
        }

        internal static bool dodajUgovor(int idZgrade, string sifra, string period, DateTime value) {
            try {
                ISession s = DataLayer.GetSession();
                Ugovor z = new Ugovor {
                    zgrada = s.Get<Zgrada>(idZgrade),
                    sifra = Int32.Parse(sifra),
                    periodVazenja = Int32.Parse(period),
                    datum = value
                };

                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();

            } catch (Exception e) {
                return false;
            }
            return true;
        }

        internal static bool izmeniUgovor(int idUgovora, string sifra, string period, DateTime value) {
            try {
                ISession s = DataLayer.GetSession();
                Ugovor z = s.Get<Ugovor>(idUgovora);
                z.sifra = Int32.Parse(sifra);
                z.periodVazenja = Int32.Parse(period);
                z.datum = value;

                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();

            } catch (Exception e) {
                return false;
            }
            return true;
        }

        internal static bool obrisiUgovor(int idUgovora) {
            try {
                ISession s = DataLayer.GetSession();
                Ugovor z = s.Get<Ugovor>(idUgovora);
                s.Delete(z);

                s.Flush();

                s.Close();

            } catch (Exception e) {
                return false;
            }
            return true;
        }

        #endregion

        #region Zaposleni
        internal static List<ZaposleniPregled> getZaposleni() {
            List<ZaposleniPregled> zaposleni = new List<ZaposleniPregled>();
            try {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zaposlen> sviZaposleni = from z in s.Query<Zaposlen>() select z;
                foreach (Zaposlen u in sviZaposleni) {
                    zaposleni.Add(new ZaposleniPregled(u.Id, (long)u.jmbg, (int)u.brlk, u.lIme, u.imeR, u.prezime, u.mestoIzdavanja, u.adresa, ((DateTime)u.datumRodjenja).ToString("dd.MM.yyyy"), false));
                }

                IEnumerable<BlagajnikZaposleni> sviBlagajniciZaposleni = from z in s.Query<BlagajnikZaposleni>() select z;
                foreach (BlagajnikZaposleni u in sviBlagajniciZaposleni) {
                    zaposleni.Add(new ZaposleniPregled(u.Id, (long)u.jmbg, (int)u.brlk, u.lIme, u.imeR, u.prezime, u.mestoIzdavanja, u.adresa, ((DateTime)u.datumRodjenja).ToString("dd.MM.yyyy"), false));
                }

                IEnumerable<PredsednikZaposleni> sviPredsedniciZaposleni = from z in s.Query<PredsednikZaposleni>() select z;
                foreach (var u in sviPredsedniciZaposleni) {
                    zaposleni.Add(new ZaposleniPregled(u.Id, (long)u.jmbg, (int)u.brlk, u.lIme, u.imeR, u.prezime, u.mestoIzdavanja, u.adresa, ((DateTime)u.datumRodjenja).ToString("dd.MM.yyyy"), false));
                }
                IEnumerable<ClanSavetaZaposleni> sviClanSavetaZaposleni = from z in s.Query<ClanSavetaZaposleni>() select z;
                foreach (ClanSavetaZaposleni u in sviClanSavetaZaposleni) {
                    zaposleni.Add(new ZaposleniPregled(u.Id, (long)u.jmbg, (int)u.brlk, u.lIme, u.imeR, u.prezime, u.mestoIzdavanja, u.adresa, ((DateTime)u.datumRodjenja).ToString("dd.MM.yyyy"), false));
                }


                IEnumerable<Upravnik> sviUpravnici = from z in s.Query<Upravnik>() select z;
                foreach (Upravnik u in sviUpravnici) {
                    zaposleni.Add(new ZaposleniPregled(u.Id, (long)u.jmbg, (int)u.brlk, u.lIme, u.imeR, u.prezime, u.mestoIzdavanja, u.adresa, ((DateTime)u.datumRodjenja).ToString("dd.MM.yyyy"), true));
                }

                IEnumerable<BlagajnikUpravnik> sviBlagajniciUpravnici = from z in s.Query<BlagajnikUpravnik>() select z;
                foreach (BlagajnikUpravnik u in sviBlagajniciUpravnici) {
                    zaposleni.Add(new ZaposleniPregled(u.Id, (long)u.jmbg, (int)u.brlk, u.lIme, u.imeR, u.prezime, u.mestoIzdavanja, u.adresa, ((DateTime)u.datumRodjenja).ToString("dd.MM.yyyy"), true));
                }

                IEnumerable<PredsednikUpravnik> svipredsedniciUpravnici = from z in s.Query<PredsednikUpravnik>() select z;
                foreach (PredsednikUpravnik u in svipredsedniciUpravnici) {
                    zaposleni.Add(new ZaposleniPregled(u.Id, (long)u.jmbg, (int)u.brlk, u.lIme, u.imeR, u.prezime, u.mestoIzdavanja, u.adresa, ((DateTime)u.datumRodjenja).ToString("dd.MM.yyyy"), true));
                }
                IEnumerable<ClanSavetaUpravnik> sviClanSavetaUpravnici = from z in s.Query<ClanSavetaUpravnik>() select z;
                foreach (ClanSavetaUpravnik u in sviClanSavetaUpravnici) {
                    zaposleni.Add(new ZaposleniPregled(u.Id, (long)u.jmbg, (int)u.brlk, u.lIme, u.imeR, u.prezime, u.mestoIzdavanja, u.adresa, ((DateTime)u.datumRodjenja).ToString("dd.MM.yyyy"), true));
                }

                s.Close();
            } catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }

            return zaposleni;
        }

        internal static bool dodajZaposlenog(long? jmbg, int? brlk, string ime, string imer, string prezime, string mestoIzadavanja, string adresa, DateTime datumRodj, bool upravnik) {
            try {
                ISession s = DataLayer.GetSession();
                if (!upravnik) {
                    Zaposlen z = new Zaposlen {
                        jmbg = jmbg,
                        brlk = brlk,
                        lIme = ime,
                        imeR = imer,
                        prezime = prezime,
                        mestoIzdavanja = mestoIzadavanja,
                        adresa = adresa,
                        datumRodjenja = datumRodj
                    };

                    s.SaveOrUpdate(z);
                }
                else {
                    Upravnik z = new Upravnik {
                        jmbg = jmbg,
                        brlk = brlk,
                        lIme = ime,
                        imeR = imer,
                        prezime = prezime,
                        mestoIzdavanja = mestoIzadavanja,
                        adresa = adresa,
                        datumRodjenja = datumRodj,
                        fzaposleni = 1
                    };

                    s.SaveOrUpdate(z);
                }

                s.Flush();

                s.Close();

            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        internal static bool izmeniZaposlenog(int idZaposlenog, string jmbg, string brlk, string ime, string imer, string prezime, string mestoIzadvanja, string adresa, DateTime value, bool upravnik) {
            try {
                ISession s = DataLayer.GetSession();
                Osoba z = s.Get<Osoba>(idZaposlenog);
                if (z.fupravnik == 1 && !upravnik)
                    if (z.zgrade.Count > 0)
                        return false;
                z.jmbg = Int64.Parse(jmbg);
                z.brlk = Int32.Parse(brlk);
                z.lIme = ime;
                z.imeR = imer;
                z.prezime = prezime;
                z.mestoIzdavanja = mestoIzadvanja;
                z.datumRodjenja = value;
                z.adresa = adresa;
                if (upravnik)
                    z.fupravnik = 1;
                else
                    z.fupravnik = 0;
                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();

            } catch (Exception e) {
                return false;
            }
            return true;
        }

        internal static bool obrisiZaposlenog(int idZaposlenog) {
            try {
                ISession s = DataLayer.GetSession();
                Osoba z = s.Get<Osoba>(idZaposlenog);
                if (z.fstanar == 0 && z.fvlasnik == 0 && z.fupravnik == 0) {
                    s.Delete(z);
                }
                else {
                    if ((z.fstanar == 1 || z.fvlasnik == 1) && z.fupravnik == 0) {
                        z.fzaposleni = 0;
                        s.SaveOrUpdate(z);
                    }
                    else if (z.fupravnik == 1) {
                        if (z.zgrade.Count == 0) {

                            ITransaction t = s.BeginTransaction();
                            try {
                                foreach (Obrazovanje o in z.obrazovanja)
                                    s.Delete(o);
                                foreach (Licenca l in z.licence)
                                    s.Delete(l);
                                s.Delete(z);
                            } catch (Exception) {
                                t.Rollback();
                                return false;
                            }
                            t.Commit();
                        }
                        else {
                            s.Close();
                            return false;
                        }
                    }
                }

                s.Flush();
                s.Close();

            } catch (Exception e) {
                return false;
            }
            return true;
        }

        #endregion

        #region Obrazovanje
        public static List<ObrazovanjePregled> getObrazovanjaZaposlenog(int idZaposlenog) {
            List<ObrazovanjePregled> obrazovanja = new List<ObrazovanjePregled>();
            try {
                ISession s = DataLayer.GetSession();

                IEnumerable<Obrazovanje> os = from z in s.Query<Obrazovanje>() where z.osoba.Id == idZaposlenog orderby z.Id select z;

                foreach (Obrazovanje o in os) {
                    obrazovanja.Add(new ObrazovanjePregled(o.Id, o.nazivInstitucije, o.zvanje, o.datumSticanja.ToString("dd.MM.yyyy")));
                }

                s.Close();
            } catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }

            return obrazovanja;
        }
        internal static bool dodajObrazovanje(int idOsobe, string ustanova, string zvanje, DateTime value) {
            try {
                ISession s = DataLayer.GetSession();
                Obrazovanje z = new Obrazovanje {
                    osoba = s.Get<Osoba>(idOsobe),
                    nazivInstitucije = ustanova,
                    zvanje = zvanje,
                    datumSticanja = value
                };
                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }
            return true;
        }

        internal static bool izmeniObrazovanje(int idObrazovanja, string ustanova, string zvanje, DateTime value) {
            try {
                ISession s = DataLayer.GetSession();
                Obrazovanje z = s.Get<Obrazovanje>(idObrazovanja);
                z.nazivInstitucije = ustanova;
                z.zvanje = zvanje;
                z.datumSticanja = value;
                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }
            return true;
        }

        internal static bool obrisiObrazovanje(int idObrazovanja) {
            try {
                ISession s = DataLayer.GetSession();

                Obrazovanje z = s.Get<Obrazovanje>(idObrazovanja);

                s.Delete(z);
                s.Flush();
                s.Close();

            } catch (Exception e) {
                return false;
            }
            return true;
        }
        #endregion

        #region Licence
        public static List<LicencaPregled> getLicenceUpravnika(int idZaposlenog) {
            List<LicencaPregled> licence = new List<LicencaPregled>();
            try {
                ISession s = DataLayer.GetSession();

                IEnumerable<Licenca> os = from z in s.Query<Licenca>() where z.osoba.Id == idZaposlenog orderby z.Id select z;

                foreach (Licenca o in os) {
                    licence.Add(new LicencaPregled(o.Id, o.broj, o.datumSticanja.ToString("dd.MM.yyyy"), o.nazivInstitucije));
                }

                s.Close();
            } catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }

            return licence;
        }
        internal static bool dodajLicencu(int idOsobe, int brojLic, string ustanova, DateTime value) {
            try {
                ISession s = DataLayer.GetSession();
                Licenca z = new Licenca {
                    broj = brojLic,
                    osoba = s.Get<Osoba>(idOsobe),
                    nazivInstitucije = ustanova,
                    datumSticanja = value
                };
                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }
            return true;
        }

        internal static bool izmeniLicencu(int idLicence, int brojLic, string ustanova, DateTime value) {
            try {
                ISession s = DataLayer.GetSession();
                Licenca z = s.Get<Licenca>(idLicence);
                z.broj = brojLic;
                z.nazivInstitucije = ustanova;
                z.datumSticanja = value;
                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }
            return true;
        }

        internal static bool obrisiLicencu(int idLicence) {
            try {
                ISession s = DataLayer.GetSession();

                Licenca z = s.Get<Licenca>(idLicence);
                if (z.osoba.licence.Count <= 1) {
                    s.Close();
                    return false;
                }
                else {
                    ITransaction t = s.BeginTransaction();
                    try {
                        foreach (Obnavljanje o in z.obnavljanje) {
                            s.Delete(o);
                        }
                        z.osoba.licence.Remove(z);
                        s.Delete(z);
                        t.Commit();
                    } catch (Exception e) {
                        t.Rollback();
                        s.Close();
                        return false;
                    }
                    s.Flush();
                    s.Close();
                }

            } catch (Exception e) {
                return false;
            }
            return true;
        }
        #endregion

        #region Obnavljanje 
        public static List<ObnavljanjePregled> getObnavljanjaLicence(int idLicence) {
            List<ObnavljanjePregled> obnavljanja = new List<ObnavljanjePregled>();
            try {
                ISession s = DataLayer.GetSession();

                IEnumerable<Obnavljanje> os = from z in s.Query<Obnavljanje>() where z.licenca.Id == idLicence orderby z.Id select z;

                foreach (Obnavljanje o in os) {
                    obnavljanja.Add(new ObnavljanjePregled(o.Id, o.datum.ToString("dd.MM.yyyy")));
                }

                s.Close();
            } catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }

            return obnavljanja;
        }
        internal static bool dodajObnavljanje(int idLicence, DateTime value) {
            try {
                ISession s = DataLayer.GetSession();
                Obnavljanje z = new Obnavljanje {
                    datum = value,
                    licenca = s.Get<Licenca>(idLicence)
                };
                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }
            return true;
        }

        internal static bool izmeniObnavljanje(int idObnavljanja, DateTime value) {
            try {
                ISession s = DataLayer.GetSession();
                Obnavljanje z = s.Get<Obnavljanje>(idObnavljanja);
                z.datum = value;
                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();


            } catch (Exception e) {
                return false;
            }
            return true;
        }

        internal static bool obrisiObnavljanje(int idObnavljanja) {
            try {
                ISession s = DataLayer.GetSession();

                Obnavljanje z = s.Get<Obnavljanje>(idObnavljanja);
                s.Delete(z);
                s.Flush();
                s.Close();

            } catch (Exception e) {
                return false;
            }
            return true;
        }
        #endregion
    }


}
