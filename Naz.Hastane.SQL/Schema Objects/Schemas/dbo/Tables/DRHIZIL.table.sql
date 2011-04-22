﻿CREATE TABLE [dbo].[DRHIZIL] (
    [KAYITID]        NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [KNR]            VARCHAR (6)   NOT NULL,
    [SNR]            VARCHAR (3)   NOT NULL,
    [SIRANO]         FLOAT         NULL,
    [AKOD]           VARCHAR (2)   NULL,
    [TANIM]          VARCHAR (2)   NULL,
    [GRUP]           VARCHAR (3)   NULL,
    [CODE]           VARCHAR (15)  NULL,
    [ARZT]           VARCHAR (4)   NULL,
    [ARZT2]          VARCHAR (4)   NULL,
    [ADET]           FLOAT         NULL,
    [UNITE]          VARCHAR (2)   NULL,
    [NAME1]          VARCHAR (100) NULL,
    [SATISF]         FLOAT         NULL,
    [KSATISF]        FLOAT         NULL,
    [KDV]            FLOAT         NULL,
    [TARIH]          DATETIME      NULL,
    [PSG]            VARCHAR (6)   NULL,
    [HZLNO]          SMALLINT      NULL,
    [USER_ID]        VARCHAR (20)  NULL,
    [DATE_CREATE]    DATETIME      NULL,
    [USER_ID_UPDATE] VARCHAR (20)  NULL,
    [DATE_UPDATE]    DATETIME      NULL,
    [MAKNO]          VARCHAR (8)   NULL,
    [KFATNO]         VARCHAR (7)   NULL,
    [FATURAEDILSIN]  VARCHAR (1)   NULL,
    [ISLENDIMI]      VARCHAR (1)   NULL,
    [IPTAL]          VARCHAR (1)   NULL,
    [S_ADET]         INT           NULL,
    [K_PAY]          FLOAT         NULL,
    [H_PAY]          FLOAT         NULL,
    [p_adet]         INT           NULL,
    [kfiyatyuzde]    FLOAT         NULL,
    [sfiyatyuzde]    FLOAT         NULL,
    [kfiyat]         FLOAT         NULL,
    [sfiyat]         FLOAT         NULL,
    [kurum]          VARCHAR (50)  NULL,
    [odeme_Tarih]    VARCHAR (10)  NULL,
    [mk]             BIT           NULL,
    [mkk]            BIT           NULL,
    [hsec]           BIT           NULL,
    [ksec]           BIT           NULL,
    [NAME]           VARCHAR (50)  NULL
);
