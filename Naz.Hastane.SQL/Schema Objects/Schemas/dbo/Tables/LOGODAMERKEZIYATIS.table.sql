﻿CREATE TABLE [dbo].[LOGODAMERKEZIYATIS] (
    [OMY_ID]      NUMERIC (18) IDENTITY (1, 1) NOT NULL,
    [ODANO]       VARCHAR (10) NOT NULL,
    [KARNO]       VARCHAR (7)  NOT NULL,
    [ISLEM]       CHAR (1)     NOT NULL,
    [USER_ID]     VARCHAR (20) NOT NULL,
    [DATE_CREATE] DATETIME     NOT NULL
);
