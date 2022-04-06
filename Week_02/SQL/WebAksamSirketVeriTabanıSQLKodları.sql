CREATE DATABASE SirketAksam

USE SirketAksam

--Departman tablosu olu�turuluyor.
CREATE TABLE tblDepartman
(
	ID INT IDENTITY(1,1) NOT NULL,
	DepartmanAd VARCHAR(MAX) NOT NULL,
	PRIMARY KEY(ID)
)
--tblDepartman tablosuna veri giri�i yap�l�yor.
INSERT INTO tblDepartman
VALUES 
	('Kalite'),('Y�netim'),('Ar-Ge'),('Teknik')

--tblDepartman tablosunun DepartmanAd alan�n�n UNIQUE olmas� gerekiyor.
--Fakat ba�lang��ta bunu d���nemedik, �imdi yapaca��z.
ALTER TABLE tblDepartman
ALTER COLUMN
	DepartmanAd VARCHAR(30)

ALTER TABLE tblDepartman ADD
	UNIQUE(DepartmanAd) 

--�nvanlar tablosu olu�turuluyor
CREATE TABLE tblUnvanlar
(
	ID INT IDENTITY(1,1) NOT NULL,
	UnvanAd VARCHAR(30) UNIQUE NOT NULL,
	PRIMARY KEY(ID)
)

--tblUnvanlar tablosuna veri giri�i
INSERT INTO
	tblUnvanlar
VALUES
	('Muhendis'),
	('�K Uzman�'),
	('Teknisyen')

--�ller tablosu olu�turuluyor
CREATE TABLE tblIller
(
	ID CHAR(2) NOT NULL,
	IlAd VARCHAR(30) UNIQUE NOT NULL,
	PRIMARY KEY(ID)
)

--tblIller tablosuna veri giri�i yap�l�yor
INSERT INTO tblIller
VALUES
	('06','Ankara'),
	('34','�stanbul'),
	('35','�zmir')

--�l�e tablosu olu�turuluyor.
USE SirketAksam
CREATE TABLE tblIlceler
(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IlceAd VARCHAR(30) NOT NULL,
	IlID CHAR(2) NOT NULL REFERENCES tblIller(ID)
)

--tblIlceler tablosuna veri giri�i
INSERT INTO tblIlceler
VALUES
	('�ankaya','06'),('Yenimahalle','06'),('Sincan','06'),
	('Beylikd�z�','34'),('Bak�rk�y','34'),('Be�ikta�','34'),
	('Kar��yaka','35'),('Konak','35'),('�e�me','35')


--Projeler tablosu olu�turulacak
CREATE TABLE tblProjeler
(
	ID INT IDENTITY(1,1) NOT NULL,
	ProjeAd VARCHAR(50) UNIQUE NOT NULL,
	BaslamaTarihi DATE NOT NULL,
	PlanlananBitisTarihi DATE NULL,
	PRIMARY KEY(ID)
)

--tblProjeler tablosuna veri giri�i
INSERT INTO tblProjeler
VALUES
	('MAV� D�NYA','2022.3.5','2022.11.5'),
	('G�VENL� ALAN','2022.2.19',NULL),
	('MUTLU GEN�L�K','2022.6.1','2023.5.31'),
	('AKILLI ROBOT','2022.1.1',NULL)

--Personel tablosu olu�turuluyor.
CREATE TABLE tblPersonel
(
	ID INT IDENTITY(1,1) NOT NULL,
	Ad VARCHAR(20) NOT NULL,
	Soyad VARCHAR(20) NOT NULL,
	Cinsiyet CHAR(1) NOT NULL,
	DogumTarihi DATE NOT NULL,
	IlceID INT NOT NULL,
	IseBaslamaTarihi DATE NOT NULL,
	DepartmanID INT NOT NULL,
	UnvanID INT NOT NULL,
	Maas DECIMAL(10,2) NOT NULL,
	PRIMARY KEY(ID),
	FOREIGN KEY(IlceID) REFERENCES tblIlceler(ID),
	FOREIGN KEY(DepartmanID) REFERENCES tblDepartman(ID),
	FOREIGN KEY(UnvanID) REFERENCES tblUnvanlar(ID)
)

--tblPersonel tablosuna veri giri�i
INSERT INTO tblPersonel
VALUES
	('Ahmet','Ekinci','E','1985.4.19',2,'2011.10.5',1,1,5000),
	('Burak','Turhan','E','1989.8.12',3,'2015.5.18',2,2,4500),
	('Ceyda','Sakarya','K','1990.11.29',4,'2010.2.18',3,3,4800),
	('Demet','�OLAK','K','1982.05.05',5,'2005.06.17',3,3,2800),
	('Evrim','�ITAK','K','1987.12.05',1,'2000.01.12',2,1,4500),
	('Figen','ESMER','K','1982.10.22',4,'1998.05.07',1,2,4000),
	('Galip','TANAR','E','1983.02.28',9,'1997.05.07',1,2,5200),
	('Emir','YANIK','E','1975.05.07',2,'2010.07.17',2,2,4500),
	('Ilg�n','ACI','E','1974.05.01',2,'2000.08.18',3,2,4200),
	('�skender','TA�','E','1974.07.02',7,'1995.09.05',4,1,4400),
	('Jale','CAN','K','1976.09.18',5,'1998.10.12',2,2,3250),
	('Kamil','ALBAYRAK','E','1976.08.19',9,'2000.11.25',1,2,5200),
	('Leman','HASKIRI�','K','1978.09.20',6,'1999.10.27',1,2,4200),
	('Meltem','UYSAL','K','1985.08.04',6,'2000.05.27',1,2,2500),
	('Necati','UYSAL','E','1990.12.01',4,'2000.03.06',2,1,2000),
	('Osman','UYSAL','E','1982.02.15',6,'1995.05.12',4,3,4800),
	('�mer','BUZDA�','E','1980.10.30',5,'2001.08.10',1,2,4800),
	('Perihan','KANAT','K','1980.10.28',4,'2001.07.11',4,1,2200),
	('Ramiz','�AKIR','E','1981.11.19',7,'2001.07.30',4,3,2700),
	('Serta�','K�SEDA�','E','1981.12.20',9,'2002.12.20',3,2,2900),
	('�efik','�APANO�LU','E','1982.02.20',6,'1998.05.25',3,3,4800),
	('Taner','BOZOKLU','E','1983.07.21',5,'2005.09.05',1,2,3000),
	('Utku','DUMAN','E','1975.06.13',6,'2005.03.05',1,3,2800),
	('�mit','��R�N','E','1978.04.02',7,'1998.04.04',2,2,3300),
	('Veysel','ERT�Z�N','E','1980.07.03',3,'2002.07.18',4,3,3100),
	('Yakup','G�K�E','E','1975.06.18',2,'2002.03.25',4,3,3100),
	('Zeliha','CAN��','K','1978.03.03',5,'2005.08.13',1,3,2500)

--G�revlendirme Tablosu olu�turuluyor.
CREATE TABLE tblGorevlendirme
(
	ID INT IDENTITY(1,1) NOT NULL,
	ProjeID INT NOT NULL,
	PersonelID INT NOT NULL,
	PRIMARY KEY(ID),
	FOREIGN KEY(ProjeID) REFERENCES tblProjeler(ID),
	FOREIGN KEY(PersonelID) REFERENCES tblPersonel(ID),
	CONSTRAINT ProjePersonelTekil UNIQUE(ProjeID,PersonelID)
)	

--tblGorevlendirme tablosu veri giri�i
INSERT INTO tblGorevlendirme
VALUES 
	(1,3),(1,5),(1,17),(1,22),(1,27),
	(2,1),(2,8),(2,17),(2,24),(2,22),
	(3,6),(3,9),(3,11),(3,12),(3,19),
	(4,2),(4,3),(4,5),(4,17),(4,25)