using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings 
{    
    
    public class PersonelHastaneBolumuMap : ClassMap<PersonelHastaneBolumu> 
    {
        
        public PersonelHastaneBolumuMap() {
			Table("PersonelHastaneBolumu");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
            References(x => x.Personel).Column("PersonelID").Not.Nullable();
            References(x => x.HastaneBolumu).Column("HastaneBolumuID").Not.Nullable();
			Map(x => x.BaslangicTarihi).Column("BaslangicTarihi").Not.Nullable();
			Map(x => x.Aciklama).Column("Aciklama");
        }
    }
}
