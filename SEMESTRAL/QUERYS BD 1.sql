
-- QUERYS BD #1

CREATE DATABASE baseDeDatos1;

GO

USE baseDeDatos1;

-- TABLA CARRERAS -----------------------------------------------------------------------------------

CREATE TABLE Carreras (
    ID INT PRIMARY KEY IDENTITY(1,1),
    NombreCarrera VARCHAR(100) NOT NULL
);

INSERT INTO Carreras (NombreCarrera)
VALUES
    ('Licenciatura en Ingenier�a Civil'),
    ('Licenciatura en Ingenier�a Industrial'),
    ('Licenciatura en Ingenier�a Mec�nica Industrial'),
    ('Licenciatura en Ingenier�a Electromec�nica'),
    ('Licenciatura en Ingenier�a de Sistemas y Computaci�n'),
    ('Licenciatura en Ingenier�a en Alimentos');


-- TABLA FACULTADES -----------------------------------------------------------------------------------

CREATE TABLE Facultades (
    ID INT PRIMARY KEY IDENTITY(1,1),
    NombreFacultad VARCHAR(100) NOT NULL
);

INSERT INTO Facultades (NombreFacultad)
VALUES
    ('Facultad de Ingenier�a Civil'),
    ('Facultad de Ingenier�a Industrial'),
    ('Facultad de Ingenier�a El�ctrica'),
    ('Facultad de Ingenier�a de Sistemas Computacionales'),
    ('Facultad de Ciencias y Tecnolog�a');


-- CARRERAS FACULTADES  (RELACI�N)-----------------------------------------------------------------------------------------------

CREATE TABLE CarrerasFacultad (
    ID INT PRIMARY KEY IDENTITY(1,1),
    CarreraID INT NOT NULL,
    FacultadID INT NOT NULL,
    CONSTRAINT FK_CarrerasFacultad_Carreras
        FOREIGN KEY (CarreraID) REFERENCES Carreras(ID),
    CONSTRAINT FK_CarrerasFacultad_Facultades
        FOREIGN KEY (FacultadID) REFERENCES Facultades(ID)
);


INSERT INTO CarrerasFacultad (CarreraID, FacultadID)
VALUES
    (1, 1), -- Licenciatura en Ingenier�a Civil - Facultad de Ingenier�a Civil
    (2, 2), -- Licenciatura en Ingenier�a Industrial - Facultad de Ingenier�a Industrial
    (3, 2), -- Licenciatura en Ingenier�a Mec�nica Industrial - Facultad de Ingenier�a Industrial
    (4, 3), -- Licenciatura en Ingenier�a Electromec�nica - Facultad de Ingenier�a El�ctrica
    (5, 4), -- Licenciatura en Ingenier�a de Sistemas y Computaci�n - Facultad de Ingenier�a de Sistemas Computacionales
    (6, 5); -- Licenciatura en Ingenier�a en Alimentos - Facultad de Ciencias y Tecnolog�a



-- USUARIOS ------------------------------------------------------------------------------------------

-- Crear la tabla Usuarios
CREATE TABLE Usuarios (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Usuario VARCHAR(50) NOT NULL,
    Contrase�a VARCHAR(50) NOT NULL,
    TipoRol VARCHAR(50) NOT NULL
);

-- Insertar datos en la tabla Usuarios
INSERT INTO Usuarios (Usuario, Contrase�a, TipoRol)
VALUES
    ('Administrador', 'admin2023'   , 'Admin'),
    ('Usuario'      , 'usuario2023' , 'Usuario'),
    ('Coordinador'  , 'coordina2023', 'Coordinador');


	-- TODOS LOS USUARIOS
	SELECT * FROM Usuarios;

	-- TODAS LAS CARRERAS CON SU FACULTAD
SELECT Carreras.ID, Carreras.NombreCarrera, Facultades.NombreFacultad
FROM Carreras
JOIN CarrerasFacultad ON Carreras.ID = CarrerasFacultad.CarreraID
JOIN Facultades ON Facultades.ID = CarrerasFacultad.FacultadID;


-- PROCEDIMIENTOS

--PROCEDIMIENTO ALMACENADO PARA LOGIN

CREATE PROCEDURE VerificarLogin
  @usuario VARCHAR(255),
  @contrase�a VARCHAR(255)
AS
BEGIN
  SET NOCOUNT ON;
  
  -- Variable para almacenar el resultado de la verificaci�n
  DECLARE @Resultado INT;
  
  -- Verificar el inicio de sesi�n
  SELECT @Resultado = COUNT(*)
  FROM Usuarios
  WHERE usuario = @usuario AND contrase�a = @contrase�a;
  
  -- Devolver el resultado
  SELECT @Resultado AS 'Resultado';
END;

--VERIFICO
EXEC VerificarLogin 'Usuario', 'usuario2023';
EXEC VerificarLogin 'Administrador', 'admin2023';
EXEC VerificarLogin 'Coordinador', 'coordina2023';




--PROCEDIMIENTO SELECT DE DATOS==========================================================================================

CREATE PROCEDURE ObtenerRolUsuario
    @NombreUsuario VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @RolUsuario VARCHAR(50);

    -- Buscar el rol del usuario en la tabla Usuarios
    SELECT @RolUsuario = TipoRol
    FROM Usuarios
    WHERE Usuario = @NombreUsuario;

    -- Devolver el rol del usuario
    SELECT @RolUsuario AS Rol;
END;

EXEC ObtenerRolUsuario 'Usuario';
EXEC ObtenerRolUsuario 'Administrador';
EXEC ObtenerRolUsuario 'Coordinador';


SELECT NombreFacultad FROM Facultades;
