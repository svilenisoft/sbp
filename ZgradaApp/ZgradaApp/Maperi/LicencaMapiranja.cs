using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Maperi
{
    class LicencaMapiranja:ClassMap<ZgradaApp.Entiteti.Licenca>
    {
        public LicencaMapiranja() {
            Table("LICENCA");
            Id(x => x.Id, "IDLICENCE").GeneratedBy.TriggerIdentity();

            Map(x => x.broj, "BROJ");
            Map(x => x.datumSticanja, "DATUM_STICANJA");
            Map(x => x.nazivInstitucije, "NAZIV_INSTITUCIJE");

            References(x => x.osoba).Column("IDOSOBE").LazyLoad();
            HasMany(x => x.obnavljanje).KeyColumn("IDLICENCE")
                  .LazyLoad().Cascade.All().Inverse();
        }
    }
}
