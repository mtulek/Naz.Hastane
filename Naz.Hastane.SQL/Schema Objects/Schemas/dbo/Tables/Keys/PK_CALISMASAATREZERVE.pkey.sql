﻿ALTER TABLE [dbo].[CALISMASAATREZERVE]
    ADD CONSTRAINT [PK_CALISMASAATREZERVE] PRIMARY KEY NONCLUSTERED ([SLK] ASC, [SLB] ASC, [YIL] ASC, [AY] ASC, [GUNBASLA] ASC, [SAAT] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];
