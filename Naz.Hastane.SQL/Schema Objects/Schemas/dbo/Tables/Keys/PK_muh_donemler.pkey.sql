﻿ALTER TABLE [dbo].[muh_donemler]
    ADD CONSTRAINT [PK_muh_donemler] PRIMARY KEY NONCLUSTERED ([donem] ASC, [sirket] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];
