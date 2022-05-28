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

    public class VlasnikPregled {
        public int id;
        public string naziv;

        public VlasnikPregled(int id, string naziv) {
            this.id = id;
            this.naziv = naziv;
        }
    }

    public class StanarPregled {
        public int id, brStana;

        public StanarPregled(int id, int brStana) {
            this.id = id;
            this.brStana = brStana;
        }
    }
}
