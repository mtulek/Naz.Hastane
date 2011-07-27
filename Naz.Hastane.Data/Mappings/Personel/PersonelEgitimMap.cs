using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings 
{   
    
    public class PersonelEgitimMap : ClassMap<PersonelEgitim> 
    {
        
        public PersonelEgitimMap() {
			Table("PersonelEgitim");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			References(x => x.Personel).Column("PersonelID").Not.Nullable();
			Map(x => x.OkulTipiID).Column("OkulTipiID").Not.Nullable();
			Map(x => x.BaslangicTarihi).Column("BaslangicTarihi").Not.Nullable();
			Map(x => x.BitisTarihi).Column("BitisTarihi");
			Map(x => x.Aciklama).Column("Aciklama");
        }
    }
}