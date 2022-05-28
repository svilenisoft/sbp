using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Entiteti
{
    public class Obrazovanje
    {
        public virtual int Id { get; protected set; }
        public virtual string nazivInstitucije { get; set; }
        public virtual string zvanje { get; set; }
        public virtual DateTime datumSticanja { get; set; }

        public virtual Osoba osoba { get; set; }
        public Obrazovanje() { 
        }
    }
}
