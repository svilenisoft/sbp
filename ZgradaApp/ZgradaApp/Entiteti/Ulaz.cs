using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Entiteti
{
    public class Ulaz
    {
        public virtual int Id { get; protected set; }
        public virtual int redni_broj { get; set;}

        public virtual DateTime vremeOtvaranja { get; set; }
        public virtual DateTime vremeZatvaranja { get; set; }
        public virtual int kamera { get; set; }

        public virtual Zgrada zgrada { get; set; }
        public Ulaz() { 
        
        }

    }
}
