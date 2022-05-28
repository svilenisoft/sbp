using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Entiteti
{
    public class BrojTelefonaOsobe
    {
        public virtual Osoba IdOsobe { get; set; }
        public virtual int Id { get; set; }

        public virtual int brojTelefona { get; set; }

        public BrojTelefonaOsobe() { 
        }

    }
}
