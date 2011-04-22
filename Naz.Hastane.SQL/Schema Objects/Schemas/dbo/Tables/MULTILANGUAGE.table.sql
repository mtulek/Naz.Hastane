﻿CREATE TABLE [dbo].[MULTILANGUAGE] (
    [FORMNAME]      VARCHAR (50)  NOT NULL,
    [FORMTAG]       VARCHAR (50)  NOT NULL,
    [OBJECTNAME]    VARCHAR (50)  NOT NULL,
    [OBJECTTYPE]    VARCHAR (20)  NOT NULL,
    [TABNUMBER]     SMALLINT      NOT NULL,
    [OBJECTCAPTION] VARCHAR (400) NULL,
    [INGCAPTION]    VARCHAR (150) NOT NULL,
    [ARNCAPTION]    VARCHAR (150) NOT NULL,
    [TARIH]         DATETIME      NOT NULL
);
