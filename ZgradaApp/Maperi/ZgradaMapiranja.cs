using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ZgradaApp.Entiteti;

namespace ZgradaApp.Maperi
{
    class ZgradaMapiranja:ClassMap<Zgrada>
    {

        public ZgradaMapiranja() {
            Table("ZGRADA");
            Id(x => x.Id, "IDZGRADE").GeneratedBy.TriggerIdentity();

            Map(x => x.adresa, "ADRESA");

            References(x => x.upravnikZgrade).Column("IDUPRAVNIKA").LazyLoad();

            HasMany(x => x.liftoviUZgradi).KeyColumn("IDZGRADE")
                .LazyLoad().Cascade.All().Inverse(); 
            HasMany(x => x.nivoiZgrade ).KeyColumn("IDZGRADE")
                .LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.ulaziZgrade).KeyColumn("IDZGRADE")
                .LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.ugovoriSaZgradom).KeyColumn("IDZGRADE")
                .LazyLoad().Cascade.All().Inverse();
        }

    }
}
