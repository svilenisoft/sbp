using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Maperi
{
    class NivoMapiranja : ClassMap<ZgradaApp.Entiteti.Nivo>
    {
        public NivoMapiranja()
        {

            Table("NIVO");

            DiscriminateSubClassesOnColumn("TIP");

            Id(x => x.Id, "IDNIVOA").GeneratedBy.TriggerIdentity();

            Map(x => x.broj, "BROJ");
            References(x => x.zgrada).Column("IDZGRADE").LazyLoad();
            HasMany(x => x.objekti).KeyColumn("IDNIVOA")
                .LazyLoad().Cascade.All().Inverse();

        }
    }
    class StambeniNivoMapiranja : SubclassMap<ZgradaApp.Entiteti.StamenbeniNivo>
    {
        public StambeniNivoMapiranja()
        {
            DiscriminatorValue("STAMBENI");
        }
    }
    class PoslovniNivoMapiranja : SubclassMap<ZgradaApp.Entiteti.PoslovniNivo>
    {
        public PoslovniNivoMapiranja()
        {
            DiscriminatorValue("POSLOVNI");
        }
    }
    class GarazniNivoMapiranja: SubclassMap<ZgradaApp.Entiteti.GarazniNivo>
    {
        public GarazniNivoMapiranja()
        {
            DiscriminatorValue("GARAZNI");
        }
    }
}
