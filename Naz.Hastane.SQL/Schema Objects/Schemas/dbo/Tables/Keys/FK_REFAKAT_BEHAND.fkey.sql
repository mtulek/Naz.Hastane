﻿ALTER TABLE [dbo].[REFAKAT]
    ADD CONSTRAINT [FK_REFAKAT_BEHAND] FOREIGN KEY ([KNR], [SNR]) REFERENCES [dbo].[BEHAND] ([KNR], [SNR]) ON DELETE NO ACTION ON UPDATE NO ACTION;
