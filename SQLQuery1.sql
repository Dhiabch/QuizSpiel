/* Datenbank erzeugen, falls bereits existiert, vorher löschen */

IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'QuizSpiel') CREATE DATABASE QuizSpiel


GO

/* Im weiteren dbAdress verwenden */
USE QuizSpiel



/* Falls Tabellen bereits existieren, sollen sie vorher gelöscht werden */
IF EXISTS(SELECT * FROM Information_Schema.Tables WHERE Table_Name = 'tblUser')
  DROP TABLE tblUser

IF EXISTS(SELECT * FROM Information_Schema.Tables WHERE Table_Name = 'tblAnswer')
  DROP TABLE tblAnswer

IF EXISTS(SELECT * FROM Information_Schema.Tables WHERE Table_Name = 'tblQuestion')
  DROP TABLE tblQuestion


/* Neue Tabellen kreieren */

CREATE TABLE tblUser (
       userID int IDENTITY(1,1) PRIMARY KEY,
       userFirstname varchar(50),
       userLastname varchar(50),
       userName varchar(50),
       password varchar(128),
       
);

CREATE TABLE tblAnswer (
       answerID int IDENTITY(1,1) PRIMARY KEY,
       answerDescription varchar(1000),
);

GO

CREATE TABLE tblQuestion (
        questionID int IDENTITY(1,1) PRIMARY KEY,
        answerID int FOREIGN KEY (answerID) REFERENCES tblAnswer(answerID),
        questionDescription varchar(1000),);




/* Tabellen mit Werten befüllen */
 

INSERT INTO tblUser (userName, password) VALUES ('aianaDzhei', 'hdfgsldjfhgsdlj');

INSERT INTO tblQuestion (questionDescription) VALUES ('Was ist sql?');


INSERT INTO tblAnswer (answerDescription) VALUES ('Das ist Test');



Select  * from tblUser