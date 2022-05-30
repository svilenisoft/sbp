using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Maperi
{
    class BrojTelefonaOsobeMapiranja:ClassMap<ZgradaApp.Entiteti.BrojTelefonaOsobe>
    {
        public BrojTelefonaOsobeMapiranja() {
            Table("BROJTELEFONA");
            Id(x => x.Id, "IDBROJA").GeneratedBy.TriggerIdentity();
            Map(x => x.brojTelefona, "BROJ");
            References(x => x.IdOsobe).Column("IDOSOBE").LazyLoad();
        }
    }
}
