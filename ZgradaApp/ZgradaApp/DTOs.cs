using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp {
    public class ZgradaPregled {
        public int id, idUpravnika;
        public String imeUpravnika, adresa;

        public ZgradaPregled() {

        }

        public ZgradaPregled(int id, int idUpravnika, string imeUpravnika, string adresa) {
            this.id = id;
            this.idUpravnika = idUpravnika;
            this.imeUpravnika = imeUpravnika;
            this.adresa = adresa;
        }
    }

    public class UpravnikSimplePregled {
        public int id;
        public String naziv;

        public UpravnikSimplePregled() {

        }
        public UpravnikSimplePregled(int id, string naziv) {
            this.id = id;
            this.naziv = naziv;
        }
    }

    public class NivoPregled {
        public int id, brNivoa, brObjekata;
        public String tipNivoa;

        public NivoPregled(int id, int brNivoa, int brObjekata, string tipNivoa) {
            this.id = id;
            this.brNivoa = brNivoa;
            this.brObjekata = brObjekata;
            this.tipNivoa = tipNivoa;
        }
    }

    public class ObjekatPregled {
        public int id, redniBr;
        public string data;

        public ObjekatPregled(int id, int redniBr, string data) {
            this.id = id;
            this.redniBr = redniBr;
            this.data = data;
        }
    }

    public class LiftPregled {
        public int id, serBr, brDanaKvara, nosivost, maxBrOsoba;
        public String nazivProizvodjaca, tip;
        public DateTime datumServisa, datumKvara;

        public LiftPregled(int id, int serBr, int brDanaKvara, int nosivost, int maxBrOsoba,
            string tip, string nazivProizvodjaca, DateTime datumServisa, DateTime datumKvara) {
            this.id = id;
            this.serBr = serBr;
            this.brDanaKvara = brDanaKvara;
            this.nosivost = nosivost;
            this.maxBrOsoba = maxBrOsoba;
            this.tip = tip;
            this.nazivProizvodjaca = nazivProizvodjaca;
            this.datumServisa = datumServisa;
            this.datumKvara = datumKvara;
        }
    }

    public class VlasnikPregled {
        public int id;
        public string ime, imer, prezime, brtel, adresa, tip, jmbg;

        public VlasnikPregled(int id, string ime, string imer, string prezime, string brtel, string adresa, string tip, string jmbg) {
            this.id = id;
            this.ime = ime;
            this.imer = imer;
            this.prezime = prezime;
            this.brtel = brtel;
            this.adresa = adresa;
            this.tip = tip;
            this.jmbg = jmbg;
        }
    }

    public class OsobaPregled {
        public int id;
        public string naziv;
        public OsobaPregled(int id, string naziv) {
            this.id = id;
            this.naziv = naziv;
        }
    }

    public class UlazPregled {
        public int id, broj;
        public string podPrismotrom, vOtvaranja, vZatvaranja;

        public UlazPregled(int id, int broj, string podPrismotrom, string vOtvaranja, string vZatvaranja) {
            this.id = id;
            this.broj = broj;
            this.podPrismotrom = podPrismotrom;
            this.vOtvaranja = vOtvaranja;
            this.vZatvaranja = vZatvaranja;
        }
    }

    public class UgovorPregled {
        public int id, sifra, vazenje;
        public string datum, datumKraja;

        public UgovorPregled(int id, int sifra, int vazenje, string datum, string datumKraja) {
            this.id = id;
            this.sifra = sifra;
            this.vazenje = vazenje;
            this.datum = datum;
            this.datumKraja = datumKraja;
        }
    }

    public class ZaposleniPregled {
        public int id;
        public long jmbg;
        public int brlk;
        public string ime, imeR, prezime, mestoIzdavanja, adresa, datumRodj;
        public bool upravnik;

        public ZaposleniPregled(int id, long jmbg, int brlk, string ime, string imer, string prezime, string mestoIzdavanja, string adresa, string datumRodj, bool upravnik) {
            this.id = id;
            this.jmbg = jmbg;
            this.brlk = brlk;
            this.ime = ime;
            this.imeR = imer;
            this.prezime = prezime;
            this.mestoIzdavanja = mestoIzdavanja;
            this.adresa = adresa;
            this.datumRodj = datumRodj;
            this.upravnik = upravnik;
        }
    }

    public class ObrazovanjePregled {
        public int id;
        public string ustanova, zvanje, datum;

        public ObrazovanjePregled(int id, string ustanova, string zvanje, string datum) {
            this.id = id;
            this.ustanova = ustanova;
            this.zvanje = zvanje;
            this.datum = datum;
        }
    }

    public class LicencaPregled {
        public int id, broj;
        public string datum, naziv;

        public LicencaPregled(int id, int broj, string datum, string naziv) {
            this.id = id;
            this.broj = broj;
            this.datum = datum;
            this.naziv = naziv;
        }
    }

    public class ObnavljanjePregled {
        public int id;
        public string datum;

        public ObnavljanjePregled(int id, string datum) {
            this.id = id;
            this.datum = datum;
        }
    }

}
