using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Entiteti
{
    public abstract class Lift
    {
        public virtual int Id { get; set; }
        public virtual int serijskiBroj { get; set; }
        public virtual string nazivProizvodjaca { get; set; }
        public virtual DateTime datumServisa { get; set; }
        public virtual DateTime datumKvara { get; set; }
        public virtual int brDanaKvara { get; set; }
        public virtual string tip { get; set; }
        public virtual int nosivost { get; set; }
        public virtual int maxBrOsoba { get; set; }

        public virtual Zgrada zgrada { get; set; }

        public Lift() { 
        }
        

    }
    public class TeretniLift : Lift { 
    
    }
    public class PutnickiLift : Lift { 
    }
}
