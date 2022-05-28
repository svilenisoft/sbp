using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Entiteti
{
    public class Zgrada
    {
        public virtual int Id { get; set; }
        public virtual string adresa { get; set; }

        public virtual Osoba upravnikZgrade { get; set; } 
        public virtual IList<Nivo> nivoiZgrade { get; set; }
        public virtual IList<Ulaz> ulaziZgrade { get; set; }
        public virtual IList<Lift> liftoviUZgradi { get; set; }
        public virtual IList<Ugovor> ugovoriSaZgradom { get; set; }
        public Zgrada() {

            nivoiZgrade = new List<Nivo>();
            ulaziZgrade = new List<Ulaz>();
            liftoviUZgradi = new List<Lift>();
            ugovoriSaZgradom = new List<Ugovor>();
        }

    }
}
