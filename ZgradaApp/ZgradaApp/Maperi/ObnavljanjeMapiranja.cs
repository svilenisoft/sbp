using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Maperi
{
    class ObnavljanjeMapiranja:ClassMap<ZgradaApp.Entiteti.Obnavljanje>
    {
        public ObnavljanjeMapiranja() {
            Table("OBNAVLJANJE");
            Id(x => x.Id, "IDOBNAVLJANJA").GeneratedBy.TriggerIdentity();
            Map(x => x.datum, "DATUM");

            References(x => x.licenca).Column("IDLICENCE").LazyLoad();
        }
    }
}
