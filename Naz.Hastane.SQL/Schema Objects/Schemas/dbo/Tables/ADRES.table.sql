﻿CREATE TABLE [dbo].[ADRES] (
    [KNR]              VARCHAR (6)    NOT NULL,
    [PSG]              VARCHAR (6)    NOT NULL,
    [ARSIVNO]          VARCHAR (10)   NULL,
    [ADLIARSIVNO]      VARCHAR (10)   NULL,
    [SIGORTANO]        VARCHAR (15)   NULL,
    [CINSIYETI]        VARCHAR (1)    NOT NULL,
    [MEDENI]           VARCHAR (1)    NOT NULL,
    [HASTAADI]         VARCHAR (15)   NOT NULL,
    [HASTASOYADI]      VARCHAR (30)   NOT NULL,
    [BABAADI]          VARCHAR (15)   NULL,
    [ANAADI]           VARCHAR (15)   NULL,
    [EV_ADRES]         VARCHAR (60)   NULL,
    [EV_PK]            VARCHAR (5)    NULL,
    [EV_SEHIR]         VARCHAR (20)   NULL,
    [EV_TEL1]          VARCHAR (15)   NULL,
    [EV_TEL2]          VARCHAR (15)   NULL,
    [EV_ILCE]          VARCHAR (50)   NULL,
    [EV_MAHALLE]       VARCHAR (50)   NULL,
    [EMAIL]            VARCHAR (50)   NULL,
    [DOGUMYERI]        VARCHAR (15)   NULL,
    [DOGUMTARIHI]      DATETIME       NOT NULL,
    [UYRUGU]           VARCHAR (5)    NULL,
    [TCKIMLIKNO]       VARCHAR (15)   NULL,
    [HUVIYETTIPI]      CHAR (1)       NULL,
    [HUVIYETNO]        VARCHAR (15)   NULL,
    [HUVIYETTARIHI]    VARCHAR (10)   NULL,
    [HUVIYETVYER]      VARCHAR (50)   NULL,
    [NUFUSKAYITLIIL]   VARCHAR (50)   NULL,
    [NUFUSKAYITLIILCE] VARCHAR (50)   NULL,
    [KANGRUBU]         INT            NULL,
    [KANVEREBILIR]     CHAR (1)       NOT NULL,
    [MEMUR]            VARCHAR (20)   NULL,
    [YAKINLIK]         VARCHAR (20)   NULL,
    [DURUM]            CHAR (1)       NULL,
    [MESLEK]           VARCHAR (20)   NULL,
    [EMSNO]            VARCHAR (20)   NULL,
    [PROTNO]           VARCHAR (20)   NULL,
    [BAGNO]            VARCHAR (20)   NULL,
    [BAGKARNENO]       VARCHAR (20)   NULL,
    [YKARTNO]          VARCHAR (10)   NULL,
    [GELHAST]          VARCHAR (20)   NULL,
    [BORC]             FLOAT          NOT NULL,
    [ALACAK]           FLOAT          NOT NULL,
    [SIGMUD]           VARCHAR (2)    NULL,
    [IS_ADI]           VARCHAR (25)   NULL,
    [IS_ADRESI]        VARCHAR (60)   NULL,
    [IS_PK]            VARCHAR (5)    NULL,
    [IS_SEHIR]         VARCHAR (20)   NULL,
    [IS_TEL1]          VARCHAR (15)   NULL,
    [IS_TEL2]          VARCHAR (15)   NULL,
    [IS_FAX]           VARCHAR (15)   NULL,
    [IS_YERINO]        VARCHAR (25)   NULL,
    [HASTAKATILIM]     CHAR (1)       NOT NULL,
    [HASTALIMIT]       FLOAT          NOT NULL,
    [ILACKONTROL]      CHAR (1)       NOT NULL,
    [OZGECMIS]         VARCHAR (5000) NULL,
    [SIGORTATURU]      VARCHAR (2)    NULL,
    [DEVREDILENKURUM]  VARCHAR (2)    NULL,
    [USER_ID]          VARCHAR (20)   NOT NULL,
    [DATE_CREATE]      DATETIME       NOT NULL,
    [USER_ID_UPDATE]   VARCHAR (20)   NULL,
    [DATE_UPDATE]      DATETIME       NULL,
    [SIGORTALIKARTNO]  VARCHAR (20)   NULL
);

