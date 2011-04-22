﻿CREATE TABLE [dbo].[BILGISISTEMLERIBOLUM_112] (
    [SIRANO]          INT           IDENTITY (1, 1) NOT NULL,
    [BOLUMKOD]        NVARCHAR (50) NULL,
    [BOLUMAD]         NVARCHAR (50) NULL,
    [HIZMETDURUMU]    NVARCHAR (50) NULL,
    [BOLUMSORUMLSUSU] NVARCHAR (50) NULL,
    [IRTIBATTELNO]    NVARCHAR (50) NULL,
    [UZMANHEKIMADET]  NVARCHAR (50) NULL,
    [TOPLAMYATAKADET] NVARCHAR (50) NULL,
    [TOPLAMVANADET]   NVARCHAR (50) NULL,
    [TOPLAMKUVEZADET] NVARCHAR (50) NULL,
    [ACIKLAMA]        NVARCHAR (50) NULL,
    [TARIH]           DATETIME      NULL,
    [GONDERMETARIHI]  DATETIME      NULL,
    [USER112]         NVARCHAR (50) NULL,
    [GONDERILDI]      NVARCHAR (50) NULL,
    [HATA]            VARCHAR (200) NULL
);
