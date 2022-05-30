using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Entiteti {
    public abstract class Osoba {
        public virtual int Id { get; set; }
        public virtual string lIme { get; set; }
        public virtual string imeR { get; set; }
        public virtual string prezime { get; set; }
        public virtual long? jmbg { get; set; }

        public virtual string adresa { get; set; }
        public virtual int fzaposleni { get; set; }
        public virtual int? brlk { get; set; }
        public virtual string mestoIzdavanja { get; set; }
        public virtual DateTime? datumRodjenja { get; set; }
        public virtual int fupravnik { get; set; }
        public virtual int fvlasnik { get; set; }
        public virtual string tip { get; set; }
        public virtual int fstanar { get; set; }

        public virtual Objekat stan { get; set; }

        public virtual IList<Zgrada> zgrade { get; set; }
        public virtual IList<Objekat> stanovi { get; set; }

        public virtual IList<BrojTelefonaOsobe> brojeviTelefona { get; set; }

        public virtual IList<Licenca> licence { get; set; }
        public virtual IList<Obrazovanje> obrazovanja { get; set; }

        public Osoba() {
            datumRodjenja = null;
            jmbg = null;
            brlk = null;

            zgrade = new List<Zgrada>();
            stanovi = new List<Objekat>();
            brojeviTelefona = new List<BrojTelefonaOsobe>();
            licence = new List<Licenca>();
            obrazovanja = new List<Obrazovanje>();
        }
    }
    public class Zaposlen : Osoba {
        public Zaposlen() : base() {
            fzaposleni = 1;
        }
    }
    /*public class Vlasnik : Osoba {
        public Vlasnik() : base() {
            fvlasnik = 1;
        }
    }*/
    public class Stanar : Osoba {
        public Stanar() : base() {
            fstanar = 1;
        }
    }
    public class Upravnik : Osoba {
        public Upravnik() : base() {
            fupravnik = 1;
        }
    }
    public class Predsednik : Osoba {
        public Predsednik() : base() {
            tip = "PREDSEDNIK";
            fvlasnik = 1;
        }
    }
    public class Blagajnik : Osoba {
        public Blagajnik() : base() {
            tip = "BLAGAJNIK";
            fvlasnik = 1;
        }
    }
    public class ClanSaveta : Osoba {
        public ClanSaveta() : base() {
            tip = "CLAN SAVETA";
            fvlasnik = 1;
        }
    }
    public class PredsednikZaposleni : Osoba {
        public PredsednikZaposleni() : base() {
            tip = "PREDSEDNIK";
            fvlasnik = 1;
            fzaposleni = 1;
        }
    }
    public class PredsednikUpravnik : Osoba {
        public PredsednikUpravnik() : base() {
            tip = "PREDSEDNIK";
            fzaposleni = 1;
            fupravnik = 1;
        }
    }
    public class BlagajnikZaposleni : Osoba {
        public BlagajnikZaposleni( ): base() {
            tip = "BLAGAJNIK";
            fzaposleni = 1;
        }
    }
    public class BlagajnikUpravnik : Osoba {
        public BlagajnikUpravnik() : base() {
            tip = "BLAGAJNIK";
            fupravnik = 1;
            fzaposleni = 1;
        }
    }
    public class ClanSavetaZaposleni : Osoba {
        public ClanSavetaZaposleni() : base() {
            tip = "CLAN SAVETA";
            fzaposleni = 1;
        }
    }
    public class ClanSavetaUpravnik : Osoba {
        public ClanSavetaUpravnik() : base() {
            tip = "CLAN SAVETA";
            fzaposleni = 1;
            fupravnik = 1;
        }
    }



}
