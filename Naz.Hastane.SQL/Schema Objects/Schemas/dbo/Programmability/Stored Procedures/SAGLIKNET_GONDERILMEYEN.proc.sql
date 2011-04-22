﻿

CREATE PROCEDURE [dbo].[SAGLIKNET_GONDERILMEYEN] @ILKTAR VARCHAR(10),@SONTAR VARCHAR(10),@GELGIT VARCHAR(1)
AS
IF @GELGIT=0  BEGIN 
SELECT     HIZIL.KNR, HIZIL.SNR, HIZIL.SIRANO, HIZMET.BKODU, HIZIL.NAME1
FROM         HIZIL INNER JOIN
                      HIZMET ON HIZIL.TANIM = HIZMET.TANIM AND HIZIL.GRUP = HIZMET.GRUP AND HIZIL.CODE = HIZMET.CODE LEFT OUTER JOIN
                      HIZILGONSAGNET ON HIZIL.KNR = HIZILGONSAGNET.KNR AND HIZIL.SNR = HIZILGONSAGNET.SNR AND 
                      HIZIL.SIRANO = HIZILGONSAGNET.SIRANO
WHERE (HIZILGONSAGNET.GELENCEVAP IS NULL) AND CONVERT(VARCHAR(10),HIZIL.TARIH,112) BETWEEN @ILKTAR AND @SONTAR
and HIZMET.BKODU <>'401010' AND LEN(HIZMET.BKODU)>1
END




