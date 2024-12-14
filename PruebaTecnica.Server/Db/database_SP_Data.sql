CREATE DATABASE [ClientDB]
GO

USE [ClientDB];
GO

INSERT INTO [Clients] (Id, Name, PhoneNumber, Contry)
VALUES 
(1,  'Pepe Labrin', '12345678901', 'Chile'),
(2,  'Juan Montero', '56987654321', 'Chile'),
(3,  'Alfonzo de ovalle', '54042342342', 'Argentina'),
(4,  'Diego Torres', '54042342348', 'Argentina'),
(5,  'Alberto Fernandes', '51942342342', 'Perú'),
(6,  'Juan Pérez', '34985551234', 'España'),
(7,  'María García', '52086665678', 'México'),
(8,  'Carlos López', '54077790132', 'Argentina'),
(9,  'Ana Rodríguez', '55688841111', 'Brasil'),
(10, 'Pedro Martínez', '56999921222', 'Chile'),
(11, 'Luis Fernández', '51955574890', 'Perú');

GO

CREATE PROCEDURE SPGetClient
(
    @NUM_PAGINA int = 1,
    @TAM_PAGINA int = 10
)
AS
BEGIN
    SET NOCOUNT ON

    SELECT  Name, PhoneNumber, Contry
    FROM Clients
    ORDER BY Name
    OFFSET (@NUM_PAGINA-1)*@TAM_PAGINA ROWS
    FETCH NEXT @TAM_PAGINA ROWS ONLY;

END
GO