CREATE DATABASE coop
GO

USE coop
GO

CREATE TABLE members (
    personId int NOT NULL PRIMARY KEY IDENTITY(1,1),
    name nvarchar(255),
    city nvarchar(255) 
);

INSERT INTO members (name, city)
VALUES ('John', 'City');
INSERT INTO members (name, city)
VALUES ('Mary', 'Taichung');
INSERT INTO members (name, city)
VALUES ('Sara', 'Kaoshung');