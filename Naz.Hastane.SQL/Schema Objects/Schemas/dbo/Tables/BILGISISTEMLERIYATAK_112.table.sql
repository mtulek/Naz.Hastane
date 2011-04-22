﻿CREATE TABLE [dbo].[BILGISISTEMLERIYATAK_112] (
    [SIRANO]           INT           IDENTITY (1, 1) NOT NULL,
    [BOLUMKODU]        NVARCHAR (50) NULL,
    [BOLUMADI]         NVARCHAR (50) NULL,
    [HIZMETDURUMU]     INT           NULL,
    [TOPLAMYATAK]      INT           NULL,
    [TOPLAMBOSYATAK]   INT           NULL,
    [ERKEKTOPLAMYATAK] INT           NULL,
    [ERKEKBOSYATAK]    INT           NULL,
    [KADINTOPLAMYATAK] INT           NULL,
    [KADINBOSYATAK]    INT           NULL,
    [COCUKTOPLAMYATAK] INT           NULL,
    [COCUKBOSYATAK]    INT           NULL,
    [TOPLAMVENTI]      INT           NULL,
    [BOSVENTI]         INT           NULL,
    [TOPLAMKUVEZ]      INT           NULL,
    [BOSKUVEZ]         INT           NULL,
    [ACIKLAMA]         NVARCHAR (50) NULL,
    [TARIH]            DATETIME      NULL,
    [GONDERMETARIHI]   DATETIME      NULL,
    [USER112]          NVARCHAR (50) NULL,
    [GONDERILDI]       NVARCHAR (50) NULL,
    [HATA]             VARCHAR (200) NULL
);
