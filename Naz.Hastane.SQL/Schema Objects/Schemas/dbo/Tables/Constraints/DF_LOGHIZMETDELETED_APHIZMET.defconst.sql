﻿ALTER TABLE [dbo].[LOGHIZMETDELETED]
    ADD CONSTRAINT [DF_LOGHIZMETDELETED_APHIZMET] DEFAULT ((1)) FOR [APHIZMET];
