﻿CREATE TABLE [dbo].[PATOLOJIRAP] (
    [PAT_ID]         FLOAT        NOT NULL,
    [KNR]            VARCHAR (6)  NOT NULL,
    [SNR]            VARCHAR (3)  NOT NULL,
    [BIYOPSINO]      VARCHAR (10) NULL,
    [BIYOPSITARIHI]  DATETIME     NULL,
    [SERVIS]         VARCHAR (2)  NULL,
    [ARZT]           VARCHAR (4)  NULL,
    [GELISTARIHI]    DATETIME     NULL,
    [CIKISTARIHI]    DATETIME     NULL,
    [ESKIBIYOPSINO]  VARCHAR (10) NULL,
    [ASISTAN]        VARCHAR (50) NULL,
    [UZMAN]          VARCHAR (50) NULL,
    [T_MATERYAL]     VARCHAR (50) NULL,
    [MATERYAL]       VARCHAR (3)  NULL,
    [T_ALINMAYERI]   VARCHAR (50) NULL,
    [ALINMAYERI]     VARCHAR (3)  NULL,
    [T_ALINMASEKLI]  VARCHAR (50) NULL,
    [ALINMASEKLI]    VARCHAR (3)  NULL,
    [MAKROSKOPIK]    TEXT         NULL,
    [MIKROSKOPIK]    TEXT         NULL,
    [TANI]           TEXT         NULL,
    [KLINIKBULGU]    TEXT         NULL,
    [DELETED]        VARCHAR (1)  NOT NULL,
    [USER_ID]        VARCHAR (20) NULL,
    [DATE_CREATE]    DATETIME     NULL,
    [USER_ID_UPDATE] VARCHAR (20) NULL,
    [DATE_UPDATE]    DATETIME     NULL
);
