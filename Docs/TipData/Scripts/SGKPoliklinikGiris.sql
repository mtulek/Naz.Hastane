select count(*) as SAYI from BEHAND_DETAY where KNR='870366' and GELISTARIHI >= '15.06.2011' and GELISTARIHI <  '16.06.2011' and SERVIS in (select SLB from KEYDAT where SLK='17' and SLY='4')
select count(*) as SAYI from BEHAND_DETAY where KNR='870366' and GELISTARIHI >= '15.06.2011' and GELISTARIHI <  '16.06.2011'
SELECT MLIMIT FROM KURADR WHERE PSG='SGK'
SELECT SLT FROM KEYDAT WHERE SLK='00' AND SLB='ACILSERVIS'
select SLT from KEYDAT where SLK='25' and SLB='ISLEMNO'
exec sp_cursoropen @p1 output,N'select SLK, SLB, SLT, SLX, SLY, SLZ, SLVV, SLXX, SLYY, SLZZ from KEYDAT where SLK=''25'' and SLB=''ISLEMNO''',@p3 output,@p4 output,@p5 output
UPDATE KEYDAT SET SLX = SLX + 1 WHERE SLK='07' AND SLB='0008'
select SLX from KEYDAT where SLK='07' and SLB='0008'
select SLT from KEYDAT where SLK='25' and SLB='ISLEMNO'
select SEVKGECSURE from KURADR where PSG='SGK'
SELECT SIRAID FROM KURADR WHERE PSG='SGK'
UPDATE KURADR SET SIRAID=1261539 where PSG='SGK '
INSERT into BEHAND (KNR, SNR, BHDAT, SEVKGECSURE, ARZT, SERVIS, SERNO, AMBU, SIRAID, HZLNO, PROVIZYONNO, USER_ID,DESTEKPSG,PSG, DATE_CREATE) values ('870366','999','15.06.2011',0,'0008','02','00001','P',1261539,0,'','AYDIN SAKAR','','SGK','15.06.2011 10:27:10')
update BEHAND set HZLNO=HZLNO + 1 where KNR='870366' and SNR='999'
select HZLNO from BEHAND where KNR='870366' and SNR='999'
INSERT into BEHAND_DETAY (KNR, SNR, GELISTARIHI, ARZT, SERVIS, SERNO, AMBU, USER_ID, DATE_CREATE) values ('870366','999','15.06.2011 10:27:10','0008','02','00001','P','AYDIN SAKAR','15.06.2011 10:27:10')
select SERVIS FROM BEHAND_DETAY Where KNR='870366' and sNR='999' ORDER BY DATE_CREATE DESC
select SLY FROM KEYDAT Where SLK='17' and SLB='02'
select  PSG FROM ADRES Where KNR='870366'
select  YFIYLIST,SEVKBASAMAK,ACILKATILIM FROM KURADR Where PSG='SGK'
select sum(ADET * SATISF) As TOPLAM, sum(ADET * KSATISF) As KTOPLAM  from HIZIL where KNR='870366' and SNR=''
update BEHAND set MTOPT=0, KTOPT=0  where KNR='870366' and SNR=''
select SLT from KEYDAT where SLK='00' and SLB='OZHASKOD'
select SLT from KEYDAT where SLK='00' and SLB='OZHASOTMUA'
exec sp_cursoropen @p1 output,N'select SERVISKODU,TANIM,GRUP,CODE,KATILIM from OTOMATIK_MUAYENELER where   SERVISKODU=''02''',@p3 output,@p4 output,@p5 output

select H.CODE, H.NAME1, H.KDV, H.SATISF93 As SATISF, H.KSATISF93 As KSATISF from HIZMET H where H.TANIM='00' and H.GRUP='002' and H.CODE = '1000'
exec sp_cursoropen @p1 output,N'SELECT PSG FROM ADRES WHERE KNR=''870366''',@p3 output,@p4 output,@p5 output
exec sp_cursoropen @p1 output,N'SELECT KNR FROM KURADR WHERE PSG=''SGK''',@p3 output,@p4 output,@p5 output
exec sp_cursoropen @p1 output,N'SELECT INDIRIMORANI FROM KURUMINDIRIMORANLARI WHERE KNR=''01035'' AND TANIM=''00'' AND GRUP=''002''',@p3 output,@p4 output,@p5 output

SELECT max(SIRANO) as SIRANO1 FROM HIZIL WHERE KNR='870366' AND SNR='999'
UPDATE  BEHAND_DETAY SET PSG='SGK'  WHERE KNR='870366' AND SNR='999'
UPDATE  BEHAND SET PSG='SGK'  WHERE KNR='870366' AND SNR='999'
UPDATE BEHAND SET DESTEKPSG='' WHERE KNR='870366' AND SNR='999' 
INSERT into HIZIL(KNR, SNR, TARIH, TANIM, GRUP, CODE, NAME1, KDV, ADET, SATISF, KSATISF, PSG, ARZT, ARZT2, HZLNO, USER_ID, DATE_CREATE, SIRANO)values ( '870366','999','15.06.2011 10:27:10','00','002','1000','�� Hastal�klar�',8,1,8.33,27,'SGK','0008','0008',1,'AYDIN SAKAR','15.06.2011 10:27:11',1)
select sum(ADET * SATISF) As TOPLAM, sum(ADET * KSATISF) As KTOPLAM  from HIZIL where KNR='870366' and SNR='999'
update BEHAND set MTOPT=8.33, KTOPT=27  where KNR='870366' and SNR='999'

select H.CODE, H.NAME1, H.KDV, H.SATISF93 As SATISF, H.KSATISF93 As KSATISF from HIZMET H where H.TANIM='53' and H.GRUP='001' and H.CODE = 'SGKKATILIM'
exec sp_cursoropen @p1 output,N'SELECT PSG FROM ADRES WHERE KNR=''870366''',@p3 output,@p4 output,@p5 output
exec sp_cursoropen @p1 output,N'SELECT KNR FROM KURADR WHERE PSG=''SGK''',@p3 output,@p4 output,@p5 output
exec sp_cursoropen @p1 output,N'SELECT INDIRIMORANI FROM KURUMINDIRIMORANLARI WHERE KNR=''01035'' AND TANIM=''53'' AND GRUP=''001''',@p3 output,@p4 output,@p5 output

SELECT max(SIRANO) as SIRANO1 FROM HIZIL WHERE KNR='870366' AND SNR='999'
UPDATE  BEHAND_DETAY SET PSG='SGK'  WHERE KNR='870366' AND SNR='999'
UPDATE  BEHAND SET PSG='SGK'  WHERE KNR='870366' AND SNR='999'
UPDATE BEHAND SET DESTEKPSG='' WHERE KNR='870366' AND SNR='999' 
INSERT into HIZIL(KNR, SNR, TARIH, TANIM, GRUP, CODE, NAME1, KDV, ADET, SATISF, KSATISF, PSG, ARZT, ARZT2, HZLNO, USER_ID, DATE_CREATE, SIRANO)values ( '870366','999','15.06.2011 10:27:10','53','001','SGKKATILIM','SGK  MUAYENE KATKI PAYI',0,1,12,0,'SGK','0008','0008',1,'AYDIN SAKAR','15.06.2011 10:27:11',2)
select sum(ADET * SATISF) As TOPLAM, sum(ADET * KSATISF) As KTOPLAM  from HIZIL where KNR='870366' and SNR='999'
update BEHAND set MTOPT=20.33, KTOPT=27  where KNR='870366' and SNR='999'

select H.CODE, H.NAME1, H.KDV, H.SATISF93 As SATISF, H.KSATISF93 As KSATISF from HIZMET H where H.TANIM='00' and H.GRUP='001' and H.CODE = '1000'
exec sp_cursoropen @p1 output,N'SELECT PSG FROM ADRES WHERE KNR=''870366''',@p3 output,@p4 output,@p5 output
exec sp_cursoropen @p1 output,N'SELECT KNR FROM KURADR WHERE PSG=''SGK''',@p3 output,@p4 output,@p5 output
exec sp_cursoropen @p1 output,N'SELECT INDIRIMORANI FROM KURUMINDIRIMORANLARI WHERE KNR=''01035'' AND TANIM=''00'' AND GRUP=''001''',@p3 output,@p4 output,@p5 output

SELECT max(SIRANO) as SIRANO1 FROM HIZIL WHERE KNR='870366' AND SNR='999'
UPDATE  BEHAND_DETAY SET PSG='SGK'  WHERE KNR='870366' AND SNR='999'
UPDATE  BEHAND SET PSG='SGK'  WHERE KNR='870366' AND SNR='999'
UPDATE BEHAND SET DESTEKPSG='' WHERE KNR='870366' AND SNR='999' 

SELECT SLT FROM KEYDAT WHERE SLK='00' AND SLB='GSS'
SELECT FIXKURUM,DURUM FROM ADRES,KURADR WHERE ADRES.PSG=KURADR.PSG AND ADRES.KNR='870366'
SELECT  BHDAT,DESTEKPSG FROM BEHAND WHERE KNR='870366' AND SNR='999'
SELECT AMBU,SERVIS FROM BEHAND WHERE KNR='870366' AND SNR='999'
SELECT  SLXA,SLT,SLYA,SLXB FROM KEYDAT WHERE  SLK='17' AND SLB='02' 
SELECT SIGORTATURU,DEVREDILENKURUM FROM ADRES WHERE KNR='870366'
SELECT AMBU FROM BEHAND WHERE KNR='870366' AND SNR='999'
SELECT  ARZT FROM BEHAND WHERE KNR='870366' AND SNR='999'
SELECT  SLXX FROM KEYDAT WHERE  SLK='07' AND SLB='0008' 
SELECT  SLXA,SLT,SLYA FROM KEYDAT WHERE  SLK='17' AND SLB='02' 
select B.SNR, B.BHDAT, B.CIKTAR, B.MTOPT, B.KTOPT,B.DTOPT,F.FATURANO, B.FATURATARIHI, B.IMPF2, B.AMBU, B.KAR_NO, B.TAKIPNO,B.PROVIZYONNO,B.SEVKTAKIPNO,B.TAKIPSEND,B.TAKIPTURU,B.HASTABASNO,B.ILISKILITAKIPNO from BEHAND B, FATURA F where B.KNR='870366' and B.FATURANO*=F.FATURA_ID order by B.SNR
select HI_ID from HASTAINDIRIMLER where KNR='870366' and SNR='999'
SELECT BEHAND.DESTEKPSG,KURADR.ADI1 FROM BEHAND,KURADR WHERE BEHAND.KNR='870366' AND BEHAND.SNR='999' AND BEHAND.DESTEKPSG=KURADR.PSG