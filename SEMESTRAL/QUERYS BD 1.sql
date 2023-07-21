
-- QUERYS BD #1

CREATE DATABASE dB1SemestralHPP;

GO

USE dB1SemestralHPP;

-- TABLA CARRERAS -----------------------------------------------------------------------------------

CREATE TABLE Carreras (
    ID INT PRIMARY KEY IDENTITY(1,1),
    NombreCarrera VARCHAR(100) NOT NULL
);

INSERT INTO Carreras (NombreCarrera)
VALUES
    ('Licenciatura en Ingeniería Civil'),
    ('Licenciatura en Ingeniería Industrial'),
    ('Licenciatura en Ingeniería Mecánica Industrial'),
    ('Licenciatura en Ingeniería Electromecánica'),
    ('Licenciatura en Ingeniería de Sistemas y Computación'),
    ('Licenciatura en Ingeniería en Alimentos');


-- TABLA FACULTADES -----------------------------------------------------------------------------------

CREATE TABLE Facultades (
    ID INT PRIMARY KEY IDENTITY(1,1),
    NombreFacultad VARCHAR(100) NOT NULL
);

INSERT INTO Facultades (NombreFacultad)
VALUES
    ('Facultad de Ingeniería Civil'),
    ('Facultad de Ingeniería Industrial'),
    ('Facultad de Ingeniería Eléctrica'),
    ('Facultad de Ingeniería de Sistemas Computacionales'),
    ('Facultad de Ciencias y Tecnología');


-- CARRERAS FACULTADES  (RELACIÓN)-----------------------------------------------------------------------------------------------

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
    (1, 1), -- Licenciatura en Ingeniería Civil - Facultad de Ingeniería Civil
    (2, 2), -- Licenciatura en Ingeniería Industrial - Facultad de Ingeniería Industrial
    (3, 2), -- Licenciatura en Ingeniería Mecánica Industrial - Facultad de Ingeniería Industrial
    (4, 3), -- Licenciatura en Ingeniería Electromecánica - Facultad de Ingeniería Eléctrica
    (5, 4), -- Licenciatura en Ingeniería de Sistemas y Computación - Facultad de Ingeniería de Sistemas Computacionales
    (6, 5); -- Licenciatura en Ingeniería en Alimentos - Facultad de Ciencias y Tecnología



-- USUARIOS ------------------------------------------------------------------------------------------

-- Crear la tabla Usuarios
CREATE TABLE Usuarios (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Usuario VARCHAR(50) NOT NULL,
    Contraseña VARCHAR(50) NOT NULL,
    TipoRol VARCHAR(50) NOT NULL
);

-- Insertar datos en la tabla Usuarios
INSERT INTO Usuarios (Usuario, Contraseña, TipoRol)
VALUES
    ('Administrador', 'admin2023'   , 'Admin'),
    ('Usuario'      , 'usuario2023' , 'Usuario'),
    ('Coordinador'  , 'coordina2023', 'Coordinador');


	-- TODOS LOS USUARIOS
	SELECT * FROM Usuarios;

	-- TODAS LAS CARRERAS CON SU FACULTAD
SELECT Carreras.NombreCarrera, Facultades.NombreFacultad
FROM Carreras
JOIN CarrerasFacultad ON Carreras.ID = CarrerasFacultad.CarreraID
JOIN Facultades ON Facultades.ID = CarrerasFacultad.FacultadID;