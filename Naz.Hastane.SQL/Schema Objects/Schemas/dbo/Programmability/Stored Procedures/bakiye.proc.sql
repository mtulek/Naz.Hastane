﻿
--CREATE  PROCEDURE [dbo].[bakiye] @KNR VARCHAR(6)--,@faturatutar float
--AS
--declare @MTOP FLOAT , @B FLOAT , @A FLOAT



--SELECT  @MTOP = SUM(MTOPT) FROM BEHAND
--WHERE KNR = @KNR
----SELECT @MTOP
----set @MTOP = @faturatutar

--SELECT  @B = SUM(TUTAR) FROM KASA
--WHERE KNR = @KNR AND BORCALACAK = 'B' AND ISIPTAL IS NULL
--IF @B IS NULL BEGIN SELECT @B = 0 END

--SELECT  @A = SUM(TUTAR) FROM KASA
--WHERE KNR = @KNR AND BORCALACAK = 'A' AND ISIPTAL IS NULL
--IF @A IS NULL BEGIN SET @A = 0 END

--SELECT @MTOP - (@B-@A) AS bakiye,@mtop as Borc




