﻿ALTER TABLE [dbo].[RANDEVULARNOTLAR]
    ADD CONSTRAINT [PK_RANDEVULARNOTLAR] PRIMARY KEY CLUSTERED ([ISLEM_ID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
