﻿ALTER TABLE [dbo].[POL_PAKET]
    ADD CONSTRAINT [PK_POL_PAKET] PRIMARY KEY CLUSTERED ([POLKOD] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
