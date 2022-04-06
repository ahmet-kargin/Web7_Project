--Ýl ve ilçeleri adlarýyla listele
USE Sirket50
SELECT tblIl.IlAd, tblIlce.IlceAd
FROM tblIl INNER JOIN tblIlce ON tblIl.ID=tblIlce.IlID

--Personellerin çalýþtýklarý departmanlarý listele
--AD            SOYAD          DEPARTMAN
USE Sirket50
SELECT tblPersonel.Ad, tblPersonel.Soyad, tblDepartman.DepartmanAd
FROM tblPersonel JOIN tblDepartman
		ON tblPersonel.DepartmanID=tblDepartman.ID

--Personellerin  ünvanlarýný listele
--AD            SOYAD          ÜNVAN
USE Sirket50
SELECT tblPersonel.Ad, tblPersonel.Soyad, tblUnvan.UnvanAd
FROM tblPersonel INNER JOIN tblUnvan
		ON tblPersonel.UnvanID=tblUnvan.ID

--Personellerin çalþtýklarý departmanlarý ve ünvanlarýný listele
--AD            SOYAD          DEPARTMAN         ÜNVAN
USE Sirket50
SELECT tblPersonel.Ad, tblPersonel.Soyad, tblDepartman.DepartmanAd, tblUnvan.UnvanAd
FROM tblPersonel INNER JOIN tblDepartman
		ON tblPersonel.DepartmanID=tblDepartman.ID INNER JOIN tblUnvan
			ON tblPersonel.UnvanID=tblUnvan.ID

--USE Sirket50
--SELECT *
--FROM tblPersonel
--		INNER JOIN tblDepartman
--			ON tblPersonel.DepartmanID=tblDepartman.ID
--		INNER JOIN tblUnvan
--			ON tblPersonel.UnvanID=tblUnvan.ID

--Projelerimin verildiði personelin yaþadýðý ilçeyle gösterilmesini
--saðlayalým.
--PROJE ADI             ÝLÇE

USE Sirket50
SELECT tblProje.ProjeAd, tblIlce.IlceAd
FROM
	tblProje
		INNER JOIN tblGorevlendirme
			ON tblProje.ID=tblGorevlendirme.ProjeID
		INNER JOIN tblPersonel
			ON tblGorevlendirme.PersonelID=tblPersonel.ID
		INNER JOIN tblIlce
			ON tblPersonel.IlceID=tblIlce.ID

--Hangi Personele, kaç kez görev vermiþim?
--PERSONEL AD                GÖREV SAYISI

USE Sirket50
SELECT tblPersonel.Ad, COUNT(tblGorevlendirme.ID)
FROM tblPersonel INNER JOIN tblGorevlendirme
		ON tblPersonel.ID = tblGorevlendirme.PersonelID
GROUP BY tblPersonel.Ad

--HAngi projeye kaç personel vermiþim?
--PROJE AD              PERSONEL SAYISI
USE Sirket50
SELECT tblProje.ProjeAd, COUNT(tblGorevlendirme.ID) AS 'Personel Sayýsý'
FROM tblProje INNER JOIN tblGorevlendirme
		ON tblProje.ID = tblGorevlendirme.ProjeID
GROUP BY tblProje.ProjeAd

--Ýstanbul'da yaþayan personelimin sayýsý
USE Sirket50
SELECT COUNT(tblPersonel.ID) AS 'Personel Sayýsý'
FROM
	tblPersonel INNER JOIN tblIlce
		ON tblPersonel.IlceID = tblIlce.ID INNER JOIN tblIl
			ON tblIlce.IlID=tblIl.ID
WHERE tblIl.IlAd='Ýstanbul'

--Ýstanbul'daki personelimin projelere göre sayýsý
USE Sirket50
SELECT tblProje.ProjeAd, COUNT(tblPersonel.ID) AS 'Sayý'
FROM 
	tblPersonel INNER JOIN tblIlce
		ON tblPersonel.IlceID = tblIlce.ID INNER JOIN tblIl
			ON tblIlce.IlID=tblIl.ID INNER JOIN tblGorevlendirme
				ON tblPersonel.ID=tblGorevlendirme.PersonelID INNER JOIN tblProje
					ON tblGorevlendirme.ProjeID=tblProje.ID
WHERE tblIl.IlAd='Ýstanbul'
GROUP BY tblProje.ProjeAd

--Cinsiyete göre maaþ toplamlarýný gösterin.
--CÝNSÝYET       TOPLAM

USE Sirket50
SELECT tblPersonel.Cinsiyet, SUM(tblPersonel.Maas)
FROM tblPersonel
GROUP BY tblPersonel.Cinsiyet

--Akýllý Robot projesinde görevlendirilen personeli listeleyelim.
--Personelin Adý, Soyadý, Ýl, Departman, Ünvan

--Akýllý Robot projesinde yer alan personelden;
--Ýstanbul ve Ankara'da yaþayan kadýnlarýn ad, soyad,yaþadýðý þehir
--ve proje adýný listeleyelim.
USE Sirket50
SELECT *
FROM
	tblPersonel INNER JOIN tblIlce
		ON tblPersonel.IlceID=tblIlce.ID
			INNER JOIN tblIl
				ON tblIlce.IlID=tblIl.ID
					INNER JOIN tblGorevlendirme
						ON tblPersonel.ID = tblGorevlendirme.PersonelID
							INNER JOIN tblProje
								ON tblGorevlendirme.ProjeID = tblProje.ID
	WHERE tblPersonel.Cinsiyet='K'
			AND (tblIl.IlAd='Ýstanbul' OR tblIl.IlAd='Ankara')
				AND tblProje.ProjeAd='Akýllý Robot'


--LEFT JOIN
--JOIN iþleminde SOLDAKÝ tablonun tüm kayýtlarýný, SAÐDAKÝ tablonun ise
--sadece eþleþen kayýtlarýný getiren birleþtirme iþlemidir.

USE Sirket50
SELECT tblIl.IlAd, tblIlce.IlceAd
FROM tblIl LEFT JOIN tblIlce ON tblIl.ID=tblIlce.IlID

--Hangi projeye kaç personel verilmiþ?
--NOT: Personel atamasý yapýlmamýþ projeler de gösterilsin.

USE Sirket50
SELECT tblProje.ProjeAd, COUNT(tblGorevlendirme.ProjeID) AS 'Proje Sayýsý'
FROM
	tblProje LEFT JOIN tblGorevlendirme 
		ON tblProje.ID=tblGorevlendirme.ProjeID 
GROUP BY tblProje.ProjeAd

--Ýllere Göre Proje Sayýsý(Proje verilmemiþ iller de görüntülensin)
--Proje->Görevlendirme->Personel->Ýlçe-Ýl

USE Sirket50
SELECT tblIl.IlAd, COUNT(tblGorevlendirme.ProjeID)
FROM
	tblProje INNER JOIN tblGorevlendirme
		ON tblProje.ID=tblGorevlendirme.ProjeID INNER JOIN tblPersonel
			ON tblGorevlendirme.PersonelID = tblPersonel.ID INNER JOIN tblIlce
				ON tblPersonel.IlceID=tblIlce.ID RIGHT JOIN tblIL
					ON tblIlce.IlID=tblIl.ID
GROUP BY tblIl.IlAd
		


USE Sirket50
SELECT tblIl.IlAd, COUNT(tblGorevlendirme.ProjeID)
FROM
	tblProje INNER JOIN tblGorevlendirme
		ON tblProje.ID=tblGorevlendirme.ProjeID INNER JOIN tblPersonel
			ON tblGorevlendirme.PersonelID = tblPersonel.ID INNER JOIN tblIlce
				ON tblPersonel.IlceID=tblIlce.ID RIGHT JOIN tblIl
					ON tblIlce.IlID=tblIl.ID
GROUP BY tblIl.IlAd
		