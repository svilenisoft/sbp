using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Entiteti
{
    public  abstract class Osoba
    {
        public virtual int Id { get; set; }
        public virtual string lIme { get; set; }
        public virtual string imeR { get; set; }
        public virtual string prezime { get; set; }
        public virtual long jmbg { get; set; }

        public virtual string adresa { get; set; }
        public virtual int fzaposleni { get; set; }
        public virtual int brlk { get; set; }
        public virtual string mestoIzdavanja { get; set; }
        public virtual DateTime datumRodjenja { get; set; }
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
            zgrade = new List<Zgrada>();
            stanovi = new List<Objekat>();
            brojeviTelefona = new List<BrojTelefonaOsobe>();
            licence = new List<Licenca>();
            obrazovanja = new List<Obrazovanje>();
        }
    }
    public class Zaposlen : Osoba {
        /*public Zaposlen() : base(){
            fzaposleni = 1;
        }*/
    }
    /*public class Vlasnik : Osoba {
        public Vlasnik() : base() {
            fvlasnik = 1;
        }
    }*/
    public class Stanar : Osoba {
       /* public Stanar() : base() {
            fstanar = 1;
        }*/
    }
    public class Upravnik : Osoba {
        /*public Upravnik() : base() {
            fupravnik = 1;
        }*/
    }
    public class Predsednik : Osoba
    {
    }
    public class Blagajnik: Osoba
    {
    }
    public class ClanSaveta: Osoba
    {
    }
    public class PredsednikZaposleni : Osoba
    {
    }
    public class PredsednikUpravnik : Osoba
    {
    }
    public class BlagajnikZaposleni : Osoba
    {
    }
    public class BlagajnikUpravnik : Osoba
    {
    }
    public class ClanSavetaZaposleni : Osoba
    {
    }
    public class ClanSavetaUpravnik : Osoba
    {
    }



}
