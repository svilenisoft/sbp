using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Maperi
{
    class ObjekatMapiranja : ClassMap<ZgradaApp.Entiteti.Objekat>
    {
        public ObjekatMapiranja()
        {

            Table("OBJEKAT");

            DiscriminateSubClassesOnColumn("TIP");

            Id(x => x.Id, "IDOBJEKTA").GeneratedBy.TriggerIdentity();

            Map(x => x.redniBr, "REDNI_BR");
            Map(x => x.imeFirma, "IME_FIRME");
            Map(x => x.status, "STATUS");
            Map(x => x.regBr, "REG_BR");

            References(x => x.nivo).Column("IDNIVOA").LazyLoad();
            References(x => x.vlasnik).Column("IDVLASNIKA").LazyLoad();
            HasMany(x => x.stanari).KeyColumn("IDSTANA").
                LazyLoad().Cascade.All().Inverse();
        }
    }
    class StanMapiranja : SubclassMap<ZgradaApp.Entiteti.Stan>
    {
        public StanMapiranja()
        {
            DiscriminatorValue("STAN");
        }
    }
    class LokalMapiranja : SubclassMap<ZgradaApp.Entiteti.Lokal>
    {
        public LokalMapiranja()
        {
            DiscriminatorValue("LOKAL");
        }
    }
    class MestoMapiranja : SubclassMap<ZgradaApp.Entiteti.Mesto>
    {
        public MestoMapiranja()
        {
            DiscriminatorValue("MESTO");
        }
    }
}
