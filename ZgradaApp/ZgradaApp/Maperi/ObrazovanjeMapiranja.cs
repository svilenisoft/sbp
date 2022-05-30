using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Maperi
{
    class ObrazovanjeMapiranja:ClassMap<ZgradaApp.Entiteti.Obrazovanje>
    {
        public ObrazovanjeMapiranja() {

            Table("OBRAZOVANJE");

            Id(x => x.Id, "IDOBRAZOVANJA").GeneratedBy.TriggerIdentity();

            Map(x => x.datumSticanja, "DATUM_STICANJA");
            Map(x => x.nazivInstitucije, "NAZIV_INSTITUCIJE");
            Map(x => x.zvanje, "ZVANJE");
            References(x => x.osoba).Column("IDOSOBE").LazyLoad();
        }
    }
}
