﻿ALTER TABLE [dbo].[ECZPOLRECETELER]
    ADD CONSTRAINT [DF_ECZPOLRECETELER_YUVARLAMA] DEFAULT ((0)) FOR [YUVARLAMA];
