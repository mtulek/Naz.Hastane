﻿ALTER TABLE [dbo].[DISMERKEZLER_FIYAT]
    ADD CONSTRAINT [PK_DISMERKEZLER_FIYAT] PRIMARY KEY CLUSTERED ([KNR] ASC, [TANIM] ASC, [GRUP] ASC, [CODE] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
