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

    public class LiftPregled
    {
        public int id, serBr, brDanaKvara,nosivost,maxBrOsoba;
        public String nazivProizvodjaca,tip;
        public DateTime datumServisa, datumKvara;

        public LiftPregled(int id, int serBr, int brDanaKvara,int nosivost,int maxBrOsoba,
            string tip,string nazivProizvodjaca,DateTime datumServisa,DateTime datumKvara)
        {
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
}
