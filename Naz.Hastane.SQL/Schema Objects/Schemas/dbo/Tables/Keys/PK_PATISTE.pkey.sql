﻿ALTER TABLE [dbo].[PATISTE]
    ADD CONSTRAINT [PK_PATISTE] PRIMARY KEY NONCLUSTERED ([TANIM] ASC, [GRUP] ASC, [CODE] ASC, [KNR] ASC, [SNR] ASC, [TARIH] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];
