﻿ALTER TABLE [dbo].[DOKTOR_HAKEDIS_BEKLEYEN]
    ADD CONSTRAINT [DF_DOKTOR_HAKEDIS_BEKLEYEN_durum] DEFAULT ('B') FOR [durum];
