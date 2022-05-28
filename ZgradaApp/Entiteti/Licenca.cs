using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Entiteti
{
    public class Licenca
    {
        public virtual int Id { get; set; }
        public virtual int broj { get; set; }
        public virtual DateTime datumSticanja { get; set; }
        public virtual string nazivInstitucije { get; set; }

        public virtual Osoba osoba { get; set; }
        public virtual IList<Obnavljanje> obnavljanje { get; set; }

        public Licenca() {
            obnavljanje = new List<Obnavljanje>();
        }
    }
}
