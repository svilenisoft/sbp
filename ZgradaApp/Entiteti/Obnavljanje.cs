using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Entiteti
{
    public class Obnavljanje
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime datum { get; set; }

        public virtual Licenca licenca { get; set; }

        public Obnavljanje() { 
        }
    }
}
