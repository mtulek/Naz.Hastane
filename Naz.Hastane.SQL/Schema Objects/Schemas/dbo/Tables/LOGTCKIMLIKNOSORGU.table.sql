﻿CREATE TABLE [dbo].[LOGTCKIMLIKNOSORGU] (
    [SIRA]        INT           IDENTITY (1, 1) NOT NULL,
    [TCKIMLIKNO]  NVARCHAR (50) NULL,
    [HASTAADI]    NVARCHAR (50) NULL,
    [HASTASOYADI] NVARCHAR (50) NULL,
    [TARIH]       DATETIME      NULL,
    [TCUSERID]    NVARCHAR (50) NULL
);
