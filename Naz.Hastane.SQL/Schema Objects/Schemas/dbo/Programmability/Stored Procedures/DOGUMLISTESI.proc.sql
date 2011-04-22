﻿CREATE PROCEDURE [dbo].[DOGUMLISTESI] @ILKTAR VARCHAR(10),@SONTAR VARCHAR(10),@DURUM VARCHAR(5)
AS
SELECT     BDOGUM.KNR, BDOGUM.SNR,BEHAND.BHDAT AS GELISTAR,BEHAND.BHDAT+10 as CIKTAR,ADRES.HASTAADI, ADRES.HASTASOYADI, ADRES.CINSIYETI, ADRES.DOGUMTARIHI, ADRES.UYRUGU, 
ADRES.TCKIMLIKNO, ADRES.BAGKARNENO, BDOGUM.BEBEKNO,BEHAND.ARZT, KEYDAT.SLVV AS DRTESCIL, KEYDAT.SLXA AS DRTC,
 SAGLIKNET_KURUMTUR.KURUMKODU, SAGLIKNET_KURUMTUR.KURUMADI,BDOGUM.GIUD,
CASE 
WHEN BDOGUM.SAGLIKNETDURUM IS NULL THEN 'Gönderilmedi'
WHEN BDOGUM.SAGLIKNETDURUM='AA:OK' THEN 'Gönderilen doküman kabul edildi'
WHEN BDOGUM.SAGLIKNETDURUM='AE:OK' THEN 'Gönderilen dokümanda hata oluştu'
WHEN BDOGUM.SAGLIKNETDURUM='AA:NF' THEN ' Yanıt bulunamadı'
end AS SAGLIKNETDURUM,
CASE 
WHEN BDOGUM.ANNEDOGUMSEKLI='01' THEN '1'
WHEN BDOGUM.ANNEDOGUMSEKLI='02' THEN '2'
WHEN BDOGUM.ANNEDOGUMSEKLI='03' THEN '3'
ELSE '8' END  AS DOGUMYONTEMI,
CASE 
WHEN BDOGUM.ANNEDOGUMSEKLI='01' THEN 'Normal doğum'
WHEN BDOGUM.ANNEDOGUMSEKLI='02' THEN 'Sezaryen müdahaleli doğum'
WHEN BDOGUM.ANNEDOGUMSEKLI='03' THEN 'Vakum / forseps müdahaleli doğum'
ELSE 'Diğer' END  AS DOGUMYONTEMIAD 

FROM BDOGUM 
INNER JOIN  ADRES ON BDOGUM.KNR = ADRES.KNR
INNER JOIN   BEHAND ON BDOGUM.KNR = BEHAND.KNR AND BDOGUM.SNR = BEHAND.SNR
INNER JOIN  (SELECT   SLB, SLVV, SLXA   FROM      KEYDAT  WHERE      (SLK = '07') and LEN(SLXA)=11 AND SLXA IS NOT NULL) AS KEYDAT ON BEHAND.ARZT = KEYDAT.SLB
INNER JOIN   KURADR ON ADRES.PSG = KURADR.PSG 
INNER JOIN SAGLIKNET_KURUMTUR ON KURADR.KURUMTIPI = SAGLIKNET_KURUMTUR.SLB 
WHERE  (CONVERT(VARCHAR, BEHAND.BHDAT, 112) BETWEEN @ILKTAR AND @SONTAR) --AND LEN(ADRES.TCKIMLIKNO)=11 AND ISNULL(BDOGUM.SAGLIKNETDURUM,0)=@DURUM
--and  AMBU IN ('Y')  AND LEN(ISNULL(KEYDAT.SLXA,0))=11




