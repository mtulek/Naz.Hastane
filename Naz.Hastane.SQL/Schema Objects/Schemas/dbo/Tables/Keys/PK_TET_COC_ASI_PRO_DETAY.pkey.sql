﻿ALTER TABLE [dbo].[TET_COC_ASI_PRO_DETAY]
    ADD CONSTRAINT [PK_TET_COC_ASI_PRO_DETAY] PRIMARY KEY CLUSTERED ([PRO_KOD] ASC, [SIRANO] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
