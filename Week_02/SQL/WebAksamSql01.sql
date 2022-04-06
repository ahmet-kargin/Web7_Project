USE WebAksam
SELECT BolumAd, ID FROM dbo.tblBolumler
SELECT AdSoyad, Cinsiyet FROM dbo.tblKisiler

SELECT AdSoyad,Cinsiyet
FROM dbo.tblKisiler

SELECT AdSoyad, Cinsiyet, BolumID
FROM dbo.tblKisiler

SELECT * FROM [dbo].[viwKisiler1]

USE WebAksam
SELECT AdSoyad, BolumAd, Cinsiyet
FROM dbo.viwKisiler1
WHERE BolumAd='Muhasebe'

SELECT ID, AdSoyad, Cinsiyet, BolumID
FROM dbo.tblKisiler
WHERE ID=3

SELECT * FROM tblKisiler
WHERE Maas<6000 or Maas >8000
/* Notlarýnýzý yazabilirsiniz */
--