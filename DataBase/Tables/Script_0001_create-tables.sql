--******************
--** Producers ***********
--******************

CREATE TABLE dbo.Producers
(
Producer_Id int IDENTITY(1,1) NOT NULL,
Producer_Name varchar(250) NOT NULL,
Producer_Bio nvarchar(max) NULL,
Company varchar(250) NOT NULL,
Producer_DOB date NOT NULL,
Gender varchar(20) NOT NULL
);

ALTER TABLE dbo.Producers ADD CONSTRAINT PK_Producers PRIMARY KEY CLUSTERED (ProducerId);


--******************
--** Movies ***********
--******************

CREATE TABLE dbo.Movies
(
Movie_Id int IDENTITY(1,1) NOT NULL,
Movie_Name varchar(250) NOT NULL,
Producer_Id int NOT NULL,
Plot nvarchar(max) NULL,
DateOfRelease date NOT NULL
);

ALTER TABLE dbo.Movies ADD CONSTRAINT PK_Movies PRIMARY KEY CLUSTERED (Movie_Id);

ALTER TABLE dbo.Movies WITH CHECK ADD FOREIGN KEY (Producer_Id) REFERENCES dbo.Producers(Producer_Id);

--******************
--** Actors ***********
--******************

CREATE TABLE dbo.Actors
(
Actor_Id int IDENTITY(1,1) NOT NULL,
Actor_Name varchar(250) NOT NULL,
Bio nvarchar(max) NULL,
Actor_DOB date NOT NULL,
Gender varchar(20) NOT NULL
);

ALTER TABLE dbo.Actor ADD CONSTRAINT PK_Actor PRIMARY KEY CLUSTERED (Actor_Id);

--******************
--** MoviesCommittedByActors ***********
--******************

CREATE TABLE dbo.MoviesComittedByActors
(
MovieCommitted_Id int IDENTITY(1,1) NOT NULL,
Actor_Id int NOT NULL,
Movie_Id int NULL
);

ALTER TABLE dbo.MoviesComittedByActors ADD CONSTRAINT PK_MoviesComittedByActors PRIMARY KEY CLUSTERED (MovieCommitted_Id);

ALTER TABLE dbo.MoviesComittedByActors WITH CHECK ADD FOREIGN KEY (Movie_Id) REFERENCES dbo.Movies(Movie_Id);

ALTER TABLE dbo.MoviesComittedByActors WITH CHECK ADD FOREIGN KEY (Actor_Id) REFERENCES dbo.Actors(Actor_Id);