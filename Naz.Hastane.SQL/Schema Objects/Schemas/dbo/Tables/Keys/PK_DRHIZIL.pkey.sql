﻿ALTER TABLE [dbo].[DRHIZIL]
    ADD CONSTRAINT [PK_DRHIZIL] PRIMARY KEY NONCLUSTERED ([KAYITID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];
