﻿CREATE TABLE [dbo].[TET_COC_HASTA_ASI_UYGULAMA] (
    [KNR]             VARCHAR (6)  NOT NULL,
    [ASI_KOD]         VARCHAR (10) NOT NULL,
    [SIRANO]          VARCHAR (10) NOT NULL,
    [YAPILACAK_TARIH] DATETIME     NOT NULL,
    [YAPILIS_SEKLI]   VARCHAR (10) NULL,
    [YAPILDIGI_TARIH] DATETIME     NULL,
    [YAPILACAGI_YER]  VARCHAR (50) NULL,
    [MARKASI]         VARCHAR (50) NULL
);
