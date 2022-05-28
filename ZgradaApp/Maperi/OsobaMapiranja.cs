using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgradaApp.Maperi
{
    class OsobaMapiranja:ClassMap<ZgradaApp.Entiteti.Osoba>
    {
        public OsobaMapiranja() {
            Table("OSOBA");

            DiscriminateSubClassesOnColumn("").Formula("CASE WHEN (FZAPOSLENI=1 AND FUPRAVNIK=0 AND FSTANAR=0 AND FVLASNIK=0) THEN 'Zaposlen'" +
                "WHEN (FZAPOSLENI=1 AND FUPRAVNIK=1 AND FSTANAR=0 AND FVLASNIK=0) THEN 'Upravnik'" +
                "WHEN (FZAPOSLENI=0 AND FUPRAVNIK=0 AND FSTANAR=1 AND FVLASNIK=0) THEN 'Stanar'" +
                "WHEN (FZAPOSLENI=0 AND FUPRAVNIK=0 AND FSTANAR=1 AND FVLASNIK=1 AND TIP=\'PREDSEDNIK\') THEN 'Predsednik'" +
                "WHEN (FZAPOSLENI=0 AND FUPRAVNIK=0 AND FSTANAR=1 AND FVLASNIK=1 AND TIP=\'BLAGAJNIK\') THEN 'Blagajnik'" +
                "WHEN (FZAPOSLENI=0 AND FUPRAVNIK=0 AND FSTANAR=1 AND FVLASNIK=1 AND TIP=\'CLAN SAVETA\') THEN 'ClanSaveta'" +
                "WHEN (FZAPOSLENI=1 AND FUPRAVNIK=0 AND FSTANAR=1 AND FVLASNIK=1 AND TIP=\'PREDSEDNIK\') THEN 'PredsednikZaposleni'" +
                "WHEN (FZAPOSLENI=1 AND FUPRAVNIK=0 AND FSTANAR=1 AND FVLASNIK=1 AND TIP=\'BLAGAJNIK\') THEN 'BlagajnikZaposleni'" +
                "WHEN (FZAPOSLENI=1 AND FUPRAVNIK=0 AND FSTANAR=1 AND FVLASNIK=1 AND TIP=\'CLAN SAVETA\') THEN 'ClanSavetaZaposleni'" +
                "WHEN (FZAPOSLENI=1 AND FUPRAVNIK=1 AND FSTANAR=1 AND FVLASNIK=1 AND TIP=\'PREDSEDNIK\') THEN 'PredsednikUpravnik'" +
                "WHEN (FZAPOSLENI=1 AND FUPRAVNIK=1 AND FSTANAR=1 AND FVLASNIK=1 AND TIP=\'BLAGAJNIK\') THEN 'BlagajnikUpravnik'" +
                "WHEN (FZAPOSLENI=1 AND FUPRAVNIK=1 AND FSTANAR=1 AND FVLASNIK=1 AND TIP=\'CLAN SAVETA\') THEN 'ClanSavetaUpravnik'" +
                "WHEN (FZAPOSLENI=0 AND FUPRAVNIK=0 AND FSTANAR=0 AND FVLASNIK=1 AND TIP=\'PREDSEDNIK\') THEN 'Predsednik'" +
                "WHEN (FZAPOSLENI=0 AND FUPRAVNIK=0 AND FSTANAR=0 AND FVLASNIK=1 AND TIP=\'BLAGAJNIK\') THEN 'Blagajnik'" +
                "WHEN (FZAPOSLENI=0 AND FUPRAVNIK=0 AND FSTANAR=0 AND FVLASNIK=1 AND TIP=\'CLAN SAVETA\') THEN 'ClanSaveta'" +
                "WHEN (FZAPOSLENI=1 AND FUPRAVNIK=0 AND FSTANAR=0 AND FVLASNIK=1 AND TIP=\'PREDSEDNIK\') THEN 'PredsednikZaposleni'" +
                "WHEN (FZAPOSLENI=1 AND FUPRAVNIK=0 AND FSTANAR=0 AND FVLASNIK=1 AND TIP=\'BLAGAJNIK\') THEN 'BlagajnikZaposleni'" +
                "WHEN (FZAPOSLENI=1 AND FUPRAVNIK=0 AND FSTANAR=0 AND FVLASNIK=1 AND TIP=\'CLAN SAVETA\') THEN 'ClanSavetaZaposleni'" +
                "WHEN (FZAPOSLENI=1 AND FUPRAVNIK=1 AND FSTANAR=0 AND FVLASNIK=1 AND TIP=\'PREDSEDNIK\') THEN 'PredsednikUpravnik'" +
                "WHEN (FZAPOSLENI=1 AND FUPRAVNIK=1 AND FSTANAR=0 AND FVLASNIK=1 AND TIP=\'BLAGAJNIK\') THEN 'BlagajnikUpravnik'" +
                "WHEN (FZAPOSLENI=1 AND FUPRAVNIK=1 AND FSTANAR=0 AND FVLASNIK=1 AND TIP=\'CLAN SAVETA\') THEN 'ClanSavetaUpravnik'" +
                "END");



            Id(x => x.Id,"IDOSOBE").GeneratedBy.TriggerIdentity();
       

            Map(x => x.lIme, "LIME");
            Map(x => x.imeR, "IMER");
            Map(x => x.prezime, "PREZIME");
            Map(x => x.jmbg, "JMBG");
            Map(x => x.adresa, "ADRESA");
            Map(x => x.brlk, "BRLK");
            Map(x => x.mestoIzdavanja, "MESTOIZDAVANJA");
            Map(x => x.datumRodjenja, "DATUMRODJENJA");

          /*  Map(x => x.fzaposleni, "FZAPOSLENI");
            Map(x => x.fupravnik, "FUPRAVNIK");
            Map(x => x.fstanar, "FSTANAR");
            Map(x => x.fvlasnik, "FVLASNIK");*/

            Map(x => x.tip, "TIP");

            References(x => x.stan).Column("IDSTANA").LazyLoad();

            HasMany(x => x.zgrade).KeyColumn("IDUPRAVNIKA")
                .LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.stanovi).KeyColumn("IDVLASNIKA")
                .LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.brojeviTelefona).KeyColumn("IDOSOBE")
                  .LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.licence).KeyColumn("IDOSOBE")
                  .LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.obrazovanja).KeyColumn("IDOSOBE")
                .LazyLoad().Cascade.All().Inverse();
     





    }
}
    class ZaposleniMapiranja : SubclassMap<ZgradaApp.Entiteti.Zaposlen> {
        public ZaposleniMapiranja() {
           
        }
    }
    class UpravnikMapiranja : SubclassMap<ZgradaApp.Entiteti.Upravnik> {
        public UpravnikMapiranja(){
           


        }
    }
    class StanarMapiranja : SubclassMap<ZgradaApp.Entiteti.Stanar> {
        public StanarMapiranja() {
            
        }
    }
    class PredsednikMapiranja : SubclassMap<ZgradaApp.Entiteti.Predsednik> {
        public PredsednikMapiranja() {
            
        }
    }
    class BlagajnikMapiranja : SubclassMap<ZgradaApp.Entiteti.Blagajnik>
    {
        public BlagajnikMapiranja()
        {

        }
    }
    class ClanSavetaMapiranja : SubclassMap<ZgradaApp.Entiteti.ClanSaveta>
    {
        public ClanSavetaMapiranja()
        {

        }
    }
    class PredsednikZaposleniMapiranja : SubclassMap<ZgradaApp.Entiteti.PredsednikZaposleni>
    {
        public PredsednikZaposleniMapiranja()
        {

        }
    }
    class PredsednikUpravnikMapiranja : SubclassMap<ZgradaApp.Entiteti.PredsednikUpravnik>
    {
        public PredsednikUpravnikMapiranja()
        {

        }
    }
    class BlagajnikZaposleniMapiranja : SubclassMap<ZgradaApp.Entiteti.BlagajnikZaposleni>
    {
        public BlagajnikZaposleniMapiranja()
        {

        }
    }
    class BlagajnikUpravnikMapiranja : SubclassMap<ZgradaApp.Entiteti.BlagajnikUpravnik>
    {
        public BlagajnikUpravnikMapiranja()
        {

        }
    }
    class ClanSavetaZaposleniMapiranja : SubclassMap<ZgradaApp.Entiteti.ClanSavetaZaposleni>
    {
        public ClanSavetaZaposleniMapiranja()
        {

        }
    }
    class ClanSavetaUpravnikMapiranja : SubclassMap<ZgradaApp.Entiteti.ClanSavetaUpravnik>
    {
        public ClanSavetaUpravnikMapiranja()
        {

        }
    }
}
