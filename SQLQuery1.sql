
/* Datenbank erzeugen, falls bereits existiert, vorher löschen */

IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'QuizSpiel') CREATE DATABASE QuizSpiel


GO

/* Im weiteren dbAdress verwenden */
USE QuizSpiel



/* Falls Tabellen bereits existieren, sollen sie vorher gelöscht werden */
IF EXISTS(SELECT * FROM Information_Schema.Tables WHERE Table_Name = 'tblBenutzer')
  DROP TABLE tblBenutzer

IF EXISTS(SELECT * FROM Information_Schema.Tables WHERE Table_Name = 'tblAntwort')
  DROP TABLE tblAntwort

IF EXISTS(SELECT * FROM Information_Schema.Tables WHERE Table_Name = 'tblFrage')
  DROP TABLE tblFrage


/* Neue Tabellen kreieren */

CREATE TABLE tblBenutzer (
       benutzerId int IDENTITY(1,1) PRIMARY KEY,
       email varchar(50),
       passwort varchar(128),
       
);

CREATE TABLE tblAntwort (
       antwortId int IDENTITY(1,1) PRIMARY KEY,
       beschreibung varchar(1000),
);

GO

CREATE TABLE tblFrage (
        frageId int IDENTITY(1,1) PRIMARY KEY,
        antwortId int FOREIGN KEY (antwortId) REFERENCES tblAntwort(antwortId),
        beschreibung varchar(1000),);




/* Tabellen mit Werten befüllen */
 

INSERT INTO tblBenutzer (email) VALUES ('Blanke@gmail.com');
INSERT INTO tblBenutzer (passwort) VALUES ('hdfgsldjfhgsdlj');


 
INSERT INTO tblFrage (beschreibung) VALUES ('Was ist sql?');


INSERT INTO tblAntwort(beschreibung) VALUES ('Das ist Test');



Select  * from tblAntwort