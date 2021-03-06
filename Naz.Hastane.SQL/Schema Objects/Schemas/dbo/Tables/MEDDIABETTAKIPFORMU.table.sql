﻿CREATE TABLE [dbo].[MEDDIABETTAKIPFORMU] (
    [KNR]                    VARCHAR (6)  NULL,
    [SNR]                    VARCHAR (3)  NULL,
    [TCKIMLIKNO]             VARCHAR (11) NULL,
    [AD]                     VARCHAR (50) NULL,
    [SOYAD]                  VARCHAR (50) NULL,
    [CEPTEL]                 VARCHAR (10) NULL,
    [PROTOKOLNO]             VARCHAR (20) NULL,
    [VIZITTARIHI]            DATETIME     NULL,
    [SAGLIKTESISKODU]        INT          NULL,
    [CINSIYET]               VARCHAR (1)  NULL,
    [IKAMETTURU]             INT          NULL,
    [ICD10TANI]              VARCHAR (10) NULL,
    [TANITARIHI]             DATETIME     NULL,
    [TIBBIBESLENMETEDAVISI]  INT          NULL,
    [EGZERSIZ]               INT          NULL,
    [BASVURUNEDENI]          INT          NULL,
    [GLUKOMETRE]             VARCHAR (1)  NULL,
    [KANSEKERITAKIPSAYISI]   INT          NULL,
    [SISTOLIKKANBASINICI]    INT          NULL,
    [DIYOSTOLIKKANBASINCI]   INT          NULL,
    [BOY]                    VARCHAR (10) NULL,
    [KILO]                   VARCHAR (10) NULL,
    [VKI]                    VARCHAR (10) NULL,
    [APG]                    VARCHAR (10) NULL,
    [TPG]                    VARCHAR (10) NULL,
    [HBA1C]                  VARCHAR (10) NULL,
    [KREATININ]              VARCHAR (10) NULL,
    [TRIGLISERID]            VARCHAR (10) NULL,
    [LDLKKOL]                VARCHAR (10) NULL,
    [HDLKOL]                 VARCHAR (10) NULL,
    [ALT]                    VARCHAR (10) NULL,
    [ANTIGAD]                VARCHAR (1)  NULL,
    [EKG]                    INT          NULL,
    [MIKROALBUMINURI]        VARCHAR (1)  NULL,
    [GOZMUAYENE]             INT          NULL,
    [PERIFERIKSENSORYAL]     VARCHAR (1)  NULL,
    [KRONERARTER]            VARCHAR (1)  NULL,
    [SEREBOVASKULERH]        VARCHAR (1)  NULL,
    [AYAKMUAYENSI]           VARCHAR (1)  NULL,
    [AKUTKOMLIKASYON]        INT          NULL,
    [YATISGUN]               INT          NULL,
    [INSULINPOMPASI]         VARCHAR (1)  NULL,
    [INSULINPOMPASIVERTARIH] DATETIME     NULL,
    [INSULINPOMPDEGTARIH]    DATETIME     NULL,
    [BIREYSELEGITIMSAYISI]   INT          NULL,
    [GRUPEGITIMSAYISI]       INT          NULL,
    [EGITIMDM]               VARCHAR (1)  NULL,
    [GONDERILDI]             VARCHAR (1)  NOT NULL,
    [TAKIPFORMUNO]           VARCHAR (10) NULL
);

