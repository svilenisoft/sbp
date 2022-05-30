using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ZgradaApp.Maperi
{
    class UlazMapiranja:ClassMap<ZgradaApp.Entiteti.Ulaz>
    {
        public UlazMapiranja() {

            Table("ULAZ");

            Id(x => x.Id, "IDULAZA").GeneratedBy.TriggerIdentity();


            Map(x => x.redni_broj, "REDNI_BROJ");
            Map(x => x.vremeOtvaranja, "VREMEOTVARANJA");
            Map(x => x.vremeZatvaranja, "VREMEZATVARANJA");
            Map(x => x.kamera, "KAMERA");
            References(x => x.zgrada).Column("IDZGRADE");
        }
    }
}
