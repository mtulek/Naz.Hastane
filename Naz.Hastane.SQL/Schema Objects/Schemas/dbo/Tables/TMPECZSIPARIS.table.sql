﻿CREATE TABLE [dbo].[TMPECZSIPARIS] (
    [V]       VARCHAR (2)  NOT NULL,
    [TANIM]   VARCHAR (2)  NOT NULL,
    [GRUP]    VARCHAR (3)  NOT NULL,
    [CODE]    VARCHAR (15) NOT NULL,
    [NAME1]   VARCHAR (65) NOT NULL,
    [SIPARIS] FLOAT        NOT NULL,
    [MEVCUT]  FLOAT        NOT NULL,
    [MINIMUM] FLOAT        NOT NULL,
    [ALISF]   FLOAT        NOT NULL,
    [INFIYAT] FLOAT        NOT NULL,
    [SATISF]  FLOAT        NOT NULL,
    [TOPGIR]  FLOAT        NOT NULL,
    [TOPCIK]  FLOAT        NOT NULL,
    [KOLI]    FLOAT        NOT NULL,
    [SEVKDAT] DATETIME     NOT NULL,
    [FIRMA]   VARCHAR (4)  NOT NULL,
    [OZELF]   VARCHAR (1)  NOT NULL,
    [USER_ID] VARCHAR (20) NOT NULL
);

