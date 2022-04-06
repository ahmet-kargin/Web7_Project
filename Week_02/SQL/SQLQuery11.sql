--�l ve il�eleri adlar�yla listele
USE Sirket50
SELECT tblIl.IlAd, tblIlce.IlceAd
FROM tblIl INNER JOIN tblIlce ON tblIl.ID=tblIlce.IlID

--Personellerin �al��t�klar� departmanlar� listele
--AD            SOYAD          DEPARTMAN
USE Sirket50
SELECT tblPersonel.Ad, tblPersonel.Soyad, tblDepartman.DepartmanAd
FROM tblPersonel JOIN tblDepartman
		ON tblPersonel.DepartmanID=tblDepartman.ID

--Personellerin  �nvanlar�n� listele
--AD            SOYAD          �NVAN
USE Sirket50
SELECT tblPersonel.Ad, tblPersonel.Soyad, tblUnvan.UnvanAd
FROM tblPersonel INNER JOIN tblUnvan
		ON tblPersonel.UnvanID=tblUnvan.ID

--Personellerin �al�t�klar� departmanlar� ve �nvanlar�n� listele
--AD            SOYAD          DEPARTMAN         �NVAN
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

--Projelerimin verildi�i personelin ya�ad��� il�eyle g�sterilmesini
--sa�layal�m.
--PROJE ADI             �L�E

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

--Hangi Personele, ka� kez g�rev vermi�im?
--PERSONEL AD                G�REV SAYISI

USE Sirket50
SELECT tblPersonel.Ad, COUNT(tblGorevlendirme.ID)
FROM tblPersonel INNER JOIN tblGorevlendirme
		ON tblPersonel.ID = tblGorevlendirme.PersonelID
GROUP BY tblPersonel.Ad

--HAngi projeye ka� personel vermi�im?
--PROJE AD              PERSONEL SAYISI
USE Sirket50
SELECT tblProje.ProjeAd, COUNT(tblGorevlendirme.ID) AS 'Personel Say�s�'
FROM tblProje INNER JOIN tblGorevlendirme
		ON tblProje.ID = tblGorevlendirme.ProjeID
GROUP BY tblProje.ProjeAd

--�stanbul'da ya�ayan personelimin say�s�
USE Sirket50
SELECT COUNT(tblPersonel.ID) AS 'Personel Say�s�'
FROM
	tblPersonel INNER JOIN tblIlce
		ON tblPersonel.IlceID = tblIlce.ID INNER JOIN tblIl
			ON tblIlce.IlID=tblIl.ID
WHERE tblIl.IlAd='�stanbul'

--�stanbul'daki personelimin projelere g�re say�s�
USE Sirket50
SELECT tblProje.ProjeAd, COUNT(tblPersonel.ID) AS 'Say�'
FROM 
	tblPersonel INNER JOIN tblIlce
		ON tblPersonel.IlceID = tblIlce.ID INNER JOIN tblIl
			ON tblIlce.IlID=tblIl.ID INNER JOIN tblGorevlendirme
				ON tblPersonel.ID=tblGorevlendirme.PersonelID INNER JOIN tblProje
					ON tblGorevlendirme.ProjeID=tblProje.ID
WHERE tblIl.IlAd='�stanbul'
GROUP BY tblProje.ProjeAd

--Cinsiyete g�re maa� toplamlar�n� g�sterin.
--C�NS�YET       TOPLAM

USE Sirket50
SELECT tblPersonel.Cinsiyet, SUM(tblPersonel.Maas)
FROM tblPersonel
GROUP BY tblPersonel.Cinsiyet

--Ak�ll� Robot projesinde g�revlendirilen personeli listeleyelim.
--Personelin Ad�, Soyad�, �l, Departman, �nvan

--Ak�ll� Robot projesinde yer alan personelden;
--�stanbul ve Ankara'da ya�ayan kad�nlar�n ad, soyad,ya�ad��� �ehir
--ve proje ad�n� listeleyelim.
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
			AND (tblIl.IlAd='�stanbul' OR tblIl.IlAd='Ankara')
				AND tblProje.ProjeAd='Ak�ll� Robot'


--LEFT JOIN
--JOIN i�leminde SOLDAK� tablonun t�m kay�tlar�n�, SA�DAK� tablonun ise
--sadece e�le�en kay�tlar�n� getiren birle�tirme i�lemidir.

USE Sirket50
SELECT tblIl.IlAd, tblIlce.IlceAd
FROM tblIl LEFT JOIN tblIlce ON tblIl.ID=tblIlce.IlID

--Hangi projeye ka� personel verilmi�?
--NOT: Personel atamas� yap�lmam�� projeler de g�sterilsin.

USE Sirket50
SELECT tblProje.ProjeAd, COUNT(tblGorevlendirme.ProjeID) AS 'Proje Say�s�'
FROM
	tblProje LEFT JOIN tblGorevlendirme 
		ON tblProje.ID=tblGorevlendirme.ProjeID 
GROUP BY tblProje.ProjeAd

--�llere G�re Proje Say�s�(Proje verilmemi� iller de g�r�nt�lensin)
--Proje->G�revlendirme->Personel->�l�e-�l

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
		