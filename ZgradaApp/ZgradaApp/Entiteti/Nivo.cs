using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Entiteti
{
    public abstract class Nivo
    {
        public virtual int Id { get; set; }
        public virtual string tip { get; set; }
        public virtual int broj { get; set; }

        public virtual Zgrada zgrada { get; set; }
        
        public virtual IList<Objekat> objekti { get; set; }

        public Nivo() {
            objekti = new List<Objekat>(); 
        }
    }
    public class StamenbeniNivo:Nivo{
    
    }
    public class PoslovniNivo : Nivo { 
    }
    public class GarazniNivo : Nivo { 
    }
}
