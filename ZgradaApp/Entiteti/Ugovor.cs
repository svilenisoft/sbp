using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Entiteti
{
    public class Ugovor
    {
        public virtual int Id { get; protected set; }
        public virtual int sifra { get; set; }
        public virtual int periodVazenja { get; set; }
        public virtual DateTime datum { get; set; }

        public virtual Zgrada zgrada { get; set; }

        public Ugovor() { 
        }
    }
}
