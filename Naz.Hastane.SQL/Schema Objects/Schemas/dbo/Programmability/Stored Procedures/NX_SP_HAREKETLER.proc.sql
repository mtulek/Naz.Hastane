﻿





CREATE  PROCEDURE NX_SP_HAREKETLER
	(
		@TARIH datetime 
	)
AS
	/* SET NOCOUNT ON */
	SELECT * FROM NX_HAREKETLER WHERE ISLEM_TARIHI=@TARIH






