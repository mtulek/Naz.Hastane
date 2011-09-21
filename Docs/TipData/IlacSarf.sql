use TIPDATA

select GRUP, CODE, NAME1, SATISF, TOPGIR-TOPCIK as MEVCUT, MINIMUM, KDV, REUSE,SKDAT,KONTROLKODU 
from ILACSARF 
where AKOD='00' and TANIM='09' and APILACSARF=1 and  GRUP like '001%' order by NAME1

select GRUP, CODE, NAME1, SATISF, TOPGIR-TOPCIK as MEVCUT, MINIMUM, KDV, REUSE,SKDAT,KONTROLKODU 
from ILACSARF 
where AKOD='10' and TANIM='16' and APILACSARF=1 and  GRUP like '001%' order by NAME1

-- �la� Kay�t
select SLT from KEYDAT where SLK='00' and SLB='FIFO'
SELECT max(SIRANO) as SIRANO1 FROM HIZIL WHERE KNR='870366' AND SNR='994'
SELECT HZLNO FROM BEHAND where KNR='870366' and SNR='994'
UPDATE BEHAND SET HZLNO=2 where KNR='870366' and SNR='994'

SELECT PSG FROM ADRES WHERE KNR='870366'
SELECT KNR FROM KURADR WHERE PSG='SGK'

SELECT INDIRIMORANI FROM KURUMINDIRIMORANLARI WHERE KNR='01035' AND TANIM='09' AND GRUP='001'
SELECT ILACINDIRIM FROM KURADR WHERE PSG='SGK'
SELECT KURUMINDIRIM FROM ILACSARF WHERE AKOD='00' AND TANIM='09' AND GRUP='001' AND CODE='8699643750056'

select NAME1, TOPGIR-TOPCIK as MEVCUT, TOPCIK, TOPSAT from ILACSARF with (UPDLOCK) where AKOD='00' and TANIM='09' and GRUP='001' and CODE='8699643750056'
select SLT from KEYDAT where SLK='00' and SLB='NEGSTOK'

UPDATE ILACSARF set TOPCIK = TOPCIK +  2,TOPSAT = TOPSAT + 9.04 WHERE AKOD='00' and TANIM='09' and GRUP='001' and CODE='8699643750056'

INSERT into HIZIL(KNR, SNR, TARIH, AKOD, TANIM, GRUP, CODE, NAME1, KDV, ADET, SATISF, KSATISF, PSG, ARZT, ARZT2, HZLNO, SIRANO, USER_ID, DATE_CREATE)
	values ( '870366','994','31.08.2011 12:04:27','00','09','001','8699643750056','5-FLUOROURACIL 500MG AMP.',8, 2,0,4.52,'SGK','0188','0188',2,3,'AYDIN SAKAR','31.08.2011 12:04:27')
INSERT into SHARK(AKOD, TANIM, GRUP, CODE, TARIH, EVRAKNO, FIRMA, ACIKLAMA, G_C, ADET, BIRIMF, TUTAR, SERVIS, ARZT, USER_ID, DATE_CREATE) 
	values ( '00','09','001','8699643750056','31.08.2011 12:04:27','870366994','P','AYDIN SAKAR','C', 2,4.52,9.04,'23','0188','AYDIN SAKAR','31.08.2011 12:04:28')
select sum(ADET * SATISF) As TOPLAM, sum(ADET * KSATISF) As KTOPLAM  from HIZIL where KNR='870366' and SNR='994'
update BEHAND set MTOPT=20.372, KTOPT=39.04  where KNR='870366' and SNR='994'
select SLT from KEYDAT where SLK='00' and SLB='ILFISSORMU'


-- Hzmet Sil
SELECT MAKNO FROM HIZIL WHERE KNR='870366' AND SNR='994' AND SIRANO=5
select HID.ESATISF from HASTAINDIRIMLER_DETAY HID, HASTAINDIRIMLER HI where HID.HI_ID = HI.HI_ID and HI.KNR='870366' and HI.SNR='994' and HID.SIRANO = 5
INSERT INTO LOGHIZILDELETED select *,'AYDIN SAKAR', getdate() from HIZIL WHERE KNR='870366' AND SNR='994' AND SIRANO =5
DELETE FROM HIZIL WHERE KNR='870366' AND SNR='994' AND SIRANO =5
UPDATE ILACSARF set TOPCIK = TOPCIK - 3, TOPSAT = TOPSAT - 20.1 WHERE AKOD='10' and TANIM='16' and GRUP='016' and CODE='50001640'
select * from SHARK where AKOD='10' and TANIM='16' and GRUP='016' and CODE='50001640' and TARIH = '31.08.2011 12:17:32'
DELETE from SHARK where EVRAKNO='870366994' and AKOD='10' and TANIM='16' and GRUP='016' and CODE='50001640' and TARIH = '31.08.2011 12:17:32'

SELECT TARIH, AKOD, TANIM, GRUP, CODE, NAME1, ADET, SATISF, KSATISF, KDV, ARZT, ARZT2, SIRANO, USER_ID,FATURAEDILSIN,HYATISTARIHI,HCIKISTARIHI, 
		REFGUNSAY,MEDONAY,MEDTUTAR,TBASLANGICSAATI,TBITISSAATI,MEDOZDURUM,MEDANOMALI, K1.SLT AS ARZT_SLT, K2.SLT AS ARZT2_SLT,H.SAAT 
	FROM HIZIL H 
		LEFT OUTER JOIN KEYDAT K1 ON K1.SLB = ARZT AND K1.SLK = '07' 
		LEFT OUTER JOIN KEYDAT K2 ON K2.SLB = ARZT2  AND K2.SLK = '07' 
		WHERE KNR='870366' AND SNR='994' ORDER BY TARIH ASC
		
select isnull(sum(ROUND(ADET*SATISF*(1+(KDV / 100)),2)),0) as BORC from HIZIL where KNR='870366' and SNR='994'
select isnull(sum(TUTAR-IADEEDILEN),0) as AVANS from AVANSLAR where KNR='870366' and SNR='994'
select SLT from KEYDAT where SLK='00' and SLB='OHUCRSNR'
select sum(ADET * SATISF) As TOPLAM, sum(ADET * KSATISF) As KTOPLAM  from HIZIL where KNR='870366' and SNR='994'
update BEHAND set MTOPT=20.372, KTOPT=39.04  where KNR='870366' and SNR='994'
