using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Maperi
{
    class UgovorMapiranja:ClassMap<ZgradaApp.Entiteti.Ugovor>
    {
        public UgovorMapiranja() {

            Table("UGOVOR");

            Id(x => x.Id, "IDUGOVORA").GeneratedBy.TriggerIdentity();
            Map(x => x.periodVazenja, "PERIOD_VAZENJA");
            Map(x => x.datum, "DATUM");
            Map(x => x.sifra, "SIFRA");
            References(x => x.zgrada).Column("IDZGRADE").LazyLoad();
        }
    }
}
