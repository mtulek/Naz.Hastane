﻿using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("HIZMET");

            CompositeId()
                .KeyProperty(x => x.TANIM, "TANIM") //.Length(2); //0
                .KeyProperty(x => x.GRUP, "GRUP") //.Length(3); //0
                .KeyProperty(x => x.CODE, "CODE"); //.Length(15); //0;

            Map(x => x.ANAHIZ).Column("ANAHIZ").Length(1); //1
            Map(x => x.ANHIZ).Column("ANHIZ").Length(1); //1
            Map(x => x.APHIZMET).Column("APHIZMET").Length(1); //1
            Map(x => x.ARZT).Column("ARZT").Length(4); //1
            Map(x => x.BKODU).Column("BKODU").Length(15); //1
            Map(x => x.BUT).Column("BUT").Length(50); //1
            Map(x => x.CODE).Column("CODE").Length(15); //0
            Map(x => x.CODE1).Column("CODE1").Length(20); //1
            Map(x => x.DATE_CREATE).Column("DATE_CREATE").Length(8); //1
            Map(x => x.DATE_UPDATE).Column("DATE_UPDATE").Length(50); //1
            Map(x => x.DRYUZDE).Column("DRYUZDE").Length(8); //0
            Map(x => x.GELIRGRUBU).Column("GELIRGRUBU").Length(10); //1
            Map(x => x.HAVUZ).Column("HAVUZ").Length(4); //1
            Map(x => x.HKILIT).Column("HKILIT").Length(1); //1
            Map(x => x.HMALIYET).Column("HMALIYET").Length(8); //1
            Map(x => x.HREFAKAT).Column("HREFAKAT").Length(1); //0
            Map(x => x.IKINCIHIZ).Column("IKINCIHIZ").Length(1); //1
            Map(x => x.KDV).Column("KDV").Length(8); //0
            Map(x => x.KHIZMET).Column("KHIZMET").Length(1); //1
            Map(x => x.KKODU).Column("KKODU").Length(20); //1
            Map(x => x.KSATISF00).Column("KSATISF00").Length(8); //0
            Map(x => x.KSATISF01).Column("KSATISF01").Length(8); //1
            Map(x => x.KSATISF02).Column("KSATISF02").Length(8); //1
            Map(x => x.KSATISF03).Column("KSATISF03").Length(8); //1
            Map(x => x.KSATISF04).Column("KSATISF04").Length(8); //1
            Map(x => x.KSATISF05).Column("KSATISF05").Length(8); //1
            Map(x => x.KSATISF06).Column("KSATISF06").Length(8); //1
            Map(x => x.KSATISF07).Column("KSATISF07").Length(8); //1
            Map(x => x.KSATISF08).Column("KSATISF08").Length(8); //1
            Map(x => x.KSATISF09).Column("KSATISF09").Length(8); //1
            Map(x => x.KSATISF10).Column("KSATISF10").Length(8); //1
            Map(x => x.KSATISF11).Column("KSATISF11").Length(8); //1
            Map(x => x.KSATISF12).Column("KSATISF12").Length(8); //1
            Map(x => x.KSATISF13).Column("KSATISF13").Length(8); //1
            Map(x => x.KSATISF14).Column("KSATISF14").Length(8); //1
            Map(x => x.KSATISF15).Column("KSATISF15").Length(8); //1
            Map(x => x.KSATISF16).Column("KSATISF16").Length(8); //1
            Map(x => x.KSATISF17).Column("KSATISF17").Length(8); //1
            Map(x => x.KSATISF18).Column("KSATISF18").Length(8); //1
            Map(x => x.KSATISF19).Column("KSATISF19").Length(8); //1
            Map(x => x.KSATISF20).Column("KSATISF20").Length(8); //1
            Map(x => x.KSATISF21).Column("KSATISF21").Length(8); //1
            Map(x => x.KSATISF22).Column("KSATISF22").Length(8); //1
            Map(x => x.KSATISF23).Column("KSATISF23").Length(8); //1
            Map(x => x.KSATISF24).Column("KSATISF24").Length(8); //1
            Map(x => x.KSATISF25).Column("KSATISF25").Length(8); //1
            Map(x => x.KSATISF26).Column("KSATISF26").Length(8); //1
            Map(x => x.KSATISF27).Column("KSATISF27").Length(8); //1
            Map(x => x.KSATISF28).Column("KSATISF28").Length(8); //1
            Map(x => x.KSATISF29).Column("KSATISF29").Length(8); //1
            Map(x => x.KSATISF30).Column("KSATISF30").Length(8); //1
            Map(x => x.KSATISF31).Column("KSATISF31").Length(8); //1
            Map(x => x.KSATISF32).Column("KSATISF32").Length(8); //1
            Map(x => x.KSATISF33).Column("KSATISF33").Length(8); //1
            Map(x => x.KSATISF34).Column("KSATISF34").Length(8); //1
            Map(x => x.KSATISF35).Column("KSATISF35").Length(8); //1
            Map(x => x.KSATISF36).Column("KSATISF36").Length(8); //1
            Map(x => x.KSATISF37).Column("KSATISF37").Length(8); //1
            Map(x => x.KSATISF38).Column("KSATISF38").Length(8); //1
            Map(x => x.KSATISF39).Column("KSATISF39").Length(8); //1
            Map(x => x.KSATISF40).Column("KSATISF40").Length(8); //1
            Map(x => x.KSATISF41).Column("KSATISF41").Length(8); //1
            Map(x => x.KSATISF42).Column("KSATISF42").Length(8); //1
            Map(x => x.KSATISF43).Column("KSATISF43").Length(8); //1
            Map(x => x.KSATISF44).Column("KSATISF44").Length(8); //1
            Map(x => x.KSATISF45).Column("KSATISF45").Length(8); //1
            Map(x => x.KSATISF46).Column("KSATISF46").Length(8); //1
            Map(x => x.KSATISF47).Column("KSATISF47").Length(8); //1
            Map(x => x.KSATISF48).Column("KSATISF48").Length(8); //1
            Map(x => x.KSATISF49).Column("KSATISF49").Length(8); //1
            Map(x => x.KSATISF50).Column("KSATISF50").Length(8); //1
            Map(x => x.KSATISF51).Column("KSATISF51").Length(8); //1
            Map(x => x.KSATISF52).Column("KSATISF52").Length(8); //1
            Map(x => x.KSATISF53).Column("KSATISF53").Length(8); //1
            Map(x => x.KSATISF54).Column("KSATISF54").Length(8); //1
            Map(x => x.KSATISF55).Column("KSATISF55").Length(8); //1
            Map(x => x.KSATISF56).Column("KSATISF56").Length(8); //1
            Map(x => x.KSATISF57).Column("KSATISF57").Length(8); //1
            Map(x => x.KSATISF58).Column("KSATISF58").Length(8); //1
            Map(x => x.KSATISF59).Column("KSATISF59").Length(8); //1
            Map(x => x.KSATISF60).Column("KSATISF60").Length(8); //1
            Map(x => x.KSATISF61).Column("KSATISF61").Length(8); //1
            Map(x => x.KSATISF62).Column("KSATISF62").Length(8); //1
            Map(x => x.KSATISF63).Column("KSATISF63").Length(8); //1
            Map(x => x.KSATISF64).Column("KSATISF64").Length(8); //1
            Map(x => x.KSATISF65).Column("KSATISF65").Length(8); //1
            Map(x => x.KSATISF66).Column("KSATISF66").Length(8); //1
            Map(x => x.KSATISF67).Column("KSATISF67").Length(8); //1
            Map(x => x.KSATISF68).Column("KSATISF68").Length(8); //1
            Map(x => x.KSATISF69).Column("KSATISF69").Length(8); //1
            Map(x => x.KSATISF70).Column("KSATISF70").Length(8); //1
            Map(x => x.KSATISF71).Column("KSATISF71").Length(8); //1
            Map(x => x.KSATISF72).Column("KSATISF72").Length(8); //1
            Map(x => x.KSATISF73).Column("KSATISF73").Length(8); //1
            Map(x => x.KSATISF74).Column("KSATISF74").Length(8); //1
            Map(x => x.KSATISF75).Column("KSATISF75").Length(8); //1
            Map(x => x.KSATISF76).Column("KSATISF76").Length(8); //1
            Map(x => x.KSATISF77).Column("KSATISF77").Length(8); //1
            Map(x => x.KSATISF78).Column("KSATISF78").Length(8); //1
            Map(x => x.KSATISF79).Column("KSATISF79").Length(8); //1
            Map(x => x.KSATISF80).Column("KSATISF80").Length(8); //1
            Map(x => x.KSATISF81).Column("KSATISF81").Length(8); //1
            Map(x => x.KSATISF82).Column("KSATISF82").Length(8); //1
            Map(x => x.KSATISF83).Column("KSATISF83").Length(8); //1
            Map(x => x.KSATISF84).Column("KSATISF84").Length(8); //1
            Map(x => x.KSATISF85).Column("KSATISF85").Length(8); //1
            Map(x => x.KSATISF86).Column("KSATISF86").Length(8); //1
            Map(x => x.KSATISF87).Column("KSATISF87").Length(8); //1
            Map(x => x.KSATISF88).Column("KSATISF88").Length(8); //1
            Map(x => x.KSATISF89).Column("KSATISF89").Length(8); //1
            Map(x => x.KSATISF90).Column("KSATISF90").Length(8); //1
            Map(x => x.KSATISF91).Column("KSATISF91").Length(8); //1
            Map(x => x.KSATISF92).Column("KSATISF92").Length(8); //1
            Map(x => x.KSATISF93).Column("KSATISF93").Length(8); //1
            Map(x => x.KSATISF94).Column("KSATISF94").Length(8); //1
            Map(x => x.KSATISF95).Column("KSATISF95").Length(8); //1
            Map(x => x.KSATISF96).Column("KSATISF96").Length(8); //1
            Map(x => x.KSATISF97).Column("KSATISF97").Length(8); //1
            Map(x => x.KSATISF98).Column("KSATISF98").Length(8); //1
            Map(x => x.KSATISF99).Column("KSATISF99").Length(8); //1
            Map(x => x.LABTIPI).Column("LABTIPI").Length(1); //1
            Map(x => x.MATERYAL).Column("MATERYAL").Length(20); //1
            Map(x => x.MBASLIK).Column("MBASLIK").Length(2); //1
            Map(x => x.MEDGONDER).Column("MEDGONDER").Length(1); //1
            Map(x => x.MEDONAY).Column("MEDONAY").Length(1); //1
            Map(x => x.MEDSONUC).Column("MEDSONUC").Length(1); //1
            Map(x => x.NAME1).Column("NAME1").Length(100); //0
            Map(x => x.OTOISLE).Column("OTOISLE").Length(1); //0
            Map(x => x.OZELKOD).Column("OZELKOD").Length(10); //0
            Map(x => x.P).Column("P").Length(1); //1
            Map(x => x.PAKET).Column("PAKET").Length(1); //0
            Map(x => x.PAKETGRUBU).Column("PAKETGRUBU").Length(10); //1
            Map(x => x.PARSAYI).Column("PARSAYI").Length(4); //1
            Map(x => x.PDAHIL).Column("PDAHIL").Length(1); //0
            Map(x => x.PHYUZDE).Column("PHYUZDE").Length(8); //0
            Map(x => x.PYUZDE).Column("PYUZDE").Length(8); //0
            Map(x => x.SATISF00).Column("SATISF00").Length(8); //0
            Map(x => x.SATISF01).Column("SATISF01").Length(8); //1
            Map(x => x.SATISF02).Column("SATISF02").Length(8); //1
            Map(x => x.SATISF03).Column("SATISF03").Length(8); //1
            Map(x => x.SATISF04).Column("SATISF04").Length(8); //1
            Map(x => x.SATISF05).Column("SATISF05").Length(8); //1
            Map(x => x.SATISF06).Column("SATISF06").Length(8); //1
            Map(x => x.SATISF07).Column("SATISF07").Length(8); //1
            Map(x => x.SATISF08).Column("SATISF08").Length(8); //1
            Map(x => x.SATISF09).Column("SATISF09").Length(8); //1
            Map(x => x.SATISF10).Column("SATISF10").Length(8); //1
            Map(x => x.SATISF11).Column("SATISF11").Length(8); //1
            Map(x => x.SATISF12).Column("SATISF12").Length(8); //1
            Map(x => x.SATISF13).Column("SATISF13").Length(8); //1
            Map(x => x.SATISF14).Column("SATISF14").Length(8); //1
            Map(x => x.SATISF15).Column("SATISF15").Length(8); //1
            Map(x => x.SATISF16).Column("SATISF16").Length(8); //1
            Map(x => x.SATISF17).Column("SATISF17").Length(8); //1
            Map(x => x.SATISF18).Column("SATISF18").Length(8); //1
            Map(x => x.SATISF19).Column("SATISF19").Length(8); //1
            Map(x => x.SATISF20).Column("SATISF20").Length(8); //1
            Map(x => x.SATISF21).Column("SATISF21").Length(8); //1
            Map(x => x.SATISF22).Column("SATISF22").Length(8); //1
            Map(x => x.SATISF23).Column("SATISF23").Length(8); //1
            Map(x => x.SATISF24).Column("SATISF24").Length(8); //1
            Map(x => x.SATISF25).Column("SATISF25").Length(8); //1
            Map(x => x.SATISF26).Column("SATISF26").Length(8); //1
            Map(x => x.SATISF27).Column("SATISF27").Length(8); //1
            Map(x => x.SATISF28).Column("SATISF28").Length(8); //1
            Map(x => x.SATISF29).Column("SATISF29").Length(8); //1
            Map(x => x.SATISF30).Column("SATISF30").Length(8); //1
            Map(x => x.SATISF31).Column("SATISF31").Length(8); //1
            Map(x => x.SATISF32).Column("SATISF32").Length(8); //1
            Map(x => x.SATISF33).Column("SATISF33").Length(8); //1
            Map(x => x.SATISF34).Column("SATISF34").Length(8); //1
            Map(x => x.SATISF35).Column("SATISF35").Length(8); //1
            Map(x => x.SATISF36).Column("SATISF36").Length(8); //1
            Map(x => x.SATISF37).Column("SATISF37").Length(8); //1
            Map(x => x.SATISF38).Column("SATISF38").Length(8); //1
            Map(x => x.SATISF39).Column("SATISF39").Length(8); //1
            Map(x => x.SATISF40).Column("SATISF40").Length(8); //1
            Map(x => x.SATISF41).Column("SATISF41").Length(8); //1
            Map(x => x.SATISF42).Column("SATISF42").Length(8); //1
            Map(x => x.SATISF43).Column("SATISF43").Length(8); //1
            Map(x => x.SATISF44).Column("SATISF44").Length(8); //1
            Map(x => x.SATISF45).Column("SATISF45").Length(8); //1
            Map(x => x.SATISF46).Column("SATISF46").Length(8); //1
            Map(x => x.SATISF47).Column("SATISF47").Length(8); //1
            Map(x => x.SATISF48).Column("SATISF48").Length(8); //1
            Map(x => x.SATISF49).Column("SATISF49").Length(8); //1
            Map(x => x.SATISF50).Column("SATISF50").Length(8); //1
            Map(x => x.SATISF51).Column("SATISF51").Length(8); //1
            Map(x => x.SATISF52).Column("SATISF52").Length(8); //1
            Map(x => x.SATISF53).Column("SATISF53").Length(8); //1
            Map(x => x.SATISF54).Column("SATISF54").Length(8); //1
            Map(x => x.SATISF55).Column("SATISF55").Length(8); //1
            Map(x => x.SATISF56).Column("SATISF56").Length(8); //1
            Map(x => x.SATISF57).Column("SATISF57").Length(8); //1
            Map(x => x.SATISF58).Column("SATISF58").Length(8); //1
            Map(x => x.SATISF59).Column("SATISF59").Length(8); //1
            Map(x => x.SATISF60).Column("SATISF60").Length(8); //1
            Map(x => x.SATISF61).Column("SATISF61").Length(8); //1
            Map(x => x.SATISF62).Column("SATISF62").Length(8); //1
            Map(x => x.SATISF63).Column("SATISF63").Length(8); //1
            Map(x => x.SATISF64).Column("SATISF64").Length(8); //1
            Map(x => x.SATISF65).Column("SATISF65").Length(8); //1
            Map(x => x.SATISF66).Column("SATISF66").Length(8); //1
            Map(x => x.SATISF67).Column("SATISF67").Length(8); //1
            Map(x => x.SATISF68).Column("SATISF68").Length(8); //1
            Map(x => x.SATISF69).Column("SATISF69").Length(8); //1
            Map(x => x.SATISF70).Column("SATISF70").Length(8); //1
            Map(x => x.SATISF71).Column("SATISF71").Length(8); //1
            Map(x => x.SATISF72).Column("SATISF72").Length(8); //1
            Map(x => x.SATISF73).Column("SATISF73").Length(8); //1
            Map(x => x.SATISF74).Column("SATISF74").Length(8); //1
            Map(x => x.SATISF75).Column("SATISF75").Length(8); //1
            Map(x => x.SATISF76).Column("SATISF76").Length(8); //1
            Map(x => x.SATISF77).Column("SATISF77").Length(8); //1
            Map(x => x.SATISF78).Column("SATISF78").Length(8); //1
            Map(x => x.SATISF79).Column("SATISF79").Length(8); //1
            Map(x => x.SATISF80).Column("SATISF80").Length(8); //1
            Map(x => x.SATISF81).Column("SATISF81").Length(8); //1
            Map(x => x.SATISF82).Column("SATISF82").Length(8); //1
            Map(x => x.SATISF83).Column("SATISF83").Length(8); //1
            Map(x => x.SATISF84).Column("SATISF84").Length(8); //1
            Map(x => x.SATISF85).Column("SATISF85").Length(8); //1
            Map(x => x.SATISF86).Column("SATISF86").Length(8); //1
            Map(x => x.SATISF87).Column("SATISF87").Length(8); //1
            Map(x => x.SATISF88).Column("SATISF88").Length(8); //1
            Map(x => x.SATISF89).Column("SATISF89").Length(8); //1
            Map(x => x.SATISF90).Column("SATISF90").Length(8); //1
            Map(x => x.SATISF91).Column("SATISF91").Length(8); //1
            Map(x => x.SATISF92).Column("SATISF92").Length(8); //1
            Map(x => x.SATISF93).Column("SATISF93").Length(8); //1
            Map(x => x.SATISF94).Column("SATISF94").Length(8); //1
            Map(x => x.SATISF95).Column("SATISF95").Length(8); //1
            Map(x => x.SATISF96).Column("SATISF96").Length(8); //1
            Map(x => x.SATISF97).Column("SATISF97").Length(8); //1
            Map(x => x.SATISF98).Column("SATISF98").Length(8); //1
            Map(x => x.SATISF99).Column("SATISF99").Length(8); //1
            Map(x => x.SIRANO).Column("SIRANO").Length(20); //1
            Map(x => x.TANIMEk).Column("TANIMEk").Length(20); //1
            Map(x => x.TESTSAAT).Column("TESTSAAT").Length(3); //1
            Map(x => x.USER_ID).Column("USER_ID").Length(50); //1
            Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(50); //1
            Map(x => x.YTKHIZMET).Column("YTKHIZMET").Length(1); //0
        }
    }
}
