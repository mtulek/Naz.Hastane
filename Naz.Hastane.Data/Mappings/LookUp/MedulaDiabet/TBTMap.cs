﻿using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp.MedulaDiabet;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class TBTMap : ClassMap<TBT>
    {
        public TBTMap()
        {
            Table("tlkpMedulaDiabetTBT");

            Id(x => x.ID).Column("ID");

            Map(x => x.Value).Column("Value").Length(255);
            Map(x => x.Code).Column("Code").Length(255);
        }
    }
}
