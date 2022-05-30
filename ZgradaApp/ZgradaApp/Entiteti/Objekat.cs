using System.Collections.Generic;

namespace ZgradaApp.Entiteti {
    public abstract class Objekat {
        public virtual int Id { get; set; }
        public virtual int redniBr { get; set; }
        public virtual string tip { get; set; }
        public virtual string imeFirma { get; set; }
        public virtual int status { get; set; }
        public virtual string regBr { get; set; }

        public virtual Nivo nivo { get; set; }
        public virtual Osoba vlasnik { get; set; }

        public virtual IList<Osoba> stanari { get; set; }

        public Objekat() {
            stanari = new List<Osoba>();
        }
    }
    public class Stan : Objekat {
    }
    public class Lokal : Objekat {
    }
    public class Mesto : Objekat {
    }
}
