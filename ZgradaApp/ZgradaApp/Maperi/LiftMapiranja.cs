using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Maperi
{
    class LiftMapiranja:ClassMap<ZgradaApp.Entiteti.Lift>
    {
        public LiftMapiranja() {

            Table("LIFT");

            DiscriminateSubClassesOnColumn("TIP");

            Id(x => x.Id, "IDLIFTA").GeneratedBy.TriggerIdentity();

            Map(x => x.maxBrOsoba, "SERIJSKI_BROJ");
            Map(x => x.nazivProizvodjaca, "NAZIV_PROIZVODJACA");
            Map(x => x.nosivost, "NOSIVOST");
            Map(x => x.serijskiBroj, "MAX_BR_OSOBA");
            Map(x => x.brDanaKvara, "BR_DANA_KVARA");
            Map(x => x.datumKvara, "DATUM_KVARA");
            Map(x => x.datumServisa, "DATUM_SERVISA");

            References(x => x.zgrada).Column("IDZGRADE").LazyLoad();
        }
    }
    class TeretniLiftMapiranja : SubclassMap<ZgradaApp.Entiteti.TeretniLift>
    {
        public TeretniLiftMapiranja() {
            DiscriminatorValue("TERETNI");
        }
    }
    class PutnickiLiftMapiranja : SubclassMap<ZgradaApp.Entiteti.PutnickiLift> {
        public PutnickiLiftMapiranja() {
            DiscriminatorValue("PUTNICKI");
        }
    }
}
