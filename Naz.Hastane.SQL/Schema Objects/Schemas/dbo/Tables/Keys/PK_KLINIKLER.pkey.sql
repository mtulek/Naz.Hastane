﻿ALTER TABLE [dbo].[KLINIKLER]
    ADD CONSTRAINT [PK_KLINIKLER] PRIMARY KEY CLUSTERED ([POLKODU] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
