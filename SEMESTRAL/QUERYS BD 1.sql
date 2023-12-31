
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
SELECT Carreras.ID, Carreras.NombreCarrera, Facultades.NombreFacultad
FROM Carreras
JOIN CarrerasFacultad ON Carreras.ID = CarrerasFacultad.CarreraID
JOIN Facultades ON Facultades.ID = CarrerasFacultad.FacultadID;


-- PROCEDIMIENTOS

--PROCEDIMIENTO ALMACENADO PARA LOGIN

CREATE PROCEDURE VerificarLogin
  @usuario VARCHAR(255),
  @contraseña VARCHAR(255)
AS
BEGIN
  SET NOCOUNT ON;
  
  -- Variable para almacenar el resultado de la verificación
  DECLARE @Resultado INT;
  
  -- Verificar el inicio de sesión
  SELECT @Resultado = COUNT(*)
  FROM Usuarios
  WHERE usuario = @usuario AND contraseña = @contraseña;
  
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


SELECT ID, NombreFacultad FROM Facultades;


-- select ID DE UNA FACULTAD

SELECT ID
FROM Facultades
WHERE NombreFacultad = 'Facultad de Ingeniería Industrial';

 --('Facultad de Ingeniería Civil'),
 --   ('Facultad de Ingeniería Industrial'),
 --   ('Facultad de Ingeniería Eléctrica'),
 --   ('Facultad de Ingeniería de Sistemas Computacionales'),
 --   ('Facultad de Ciencias y Tecnología');







 -- PROCEMIENTOS CARRERAS: obtener ID de la facultad

 CREATE PROCEDURE obtenerIdFacultad
    @NombreFacultad VARCHAR(100)
AS
BEGIN
    SELECT ID
    FROM Facultades
    WHERE NombreFacultad = @NombreFacultad;
END;


 -- PROCEMIENTOS CARRERAS: agregar carrera

 CREATE PROCEDURE agregarCarrera
    @NombreCarrera VARCHAR(100)
AS
BEGIN
    DECLARE @CarreraID INT;

    INSERT INTO Carreras (NombreCarrera)
    VALUES (@NombreCarrera);

    SET @CarreraID = SCOPE_IDENTITY(); -- Obtiene el último ID insertado en la tabla Carreras

    SELECT @CarreraID AS CarreraID;
END;



 -- PROCEMIENTOS CARRERAS: RELACIONAR CARRERAS FACULTAD

CREATE PROCEDURE relacionarCarrerasFacultad
    @CarreraID INT,
    @FacultadID INT
AS
BEGIN
    INSERT INTO CarrerasFacultad (CarreraID, FacultadID)
    VALUES (@CarreraID, @FacultadID);
END;


--ACTUALIZAR

CREATE PROCEDURE ActualizarNombreCarrera
    @CarreraID INT,
    @NuevoNombreCarrera VARCHAR(100)
AS
BEGIN
    UPDATE Carreras
    SET NombreCarrera = @NuevoNombreCarrera
    WHERE ID = @CarreraID;
END;

 CREATE PROCEDURE obtenerIdFacultad
    @NombreFacultad VARCHAR(100)
AS
BEGIN
    SELECT ID
    FROM Facultades
    WHERE NombreFacultad = @NombreFacultad;
END;

CREATE PROCEDURE ActualizarFacultadID
    @CarreraID INT,
    @NuevoFacultadID INT
AS
BEGIN
    UPDATE CarrerasFacultad
    SET FacultadID = @NuevoFacultadID
    WHERE CarreraID = @CarreraID;
END;





CREATE PROCEDURE selectDatosCarrera
    @CarreraID INT,
    @NombreCarrera VARCHAR(100) OUTPUT,
    @NombreFacultad VARCHAR(100) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT @NombreCarrera = c.NombreCarrera, @NombreFacultad = f.NombreFacultad
    FROM Carreras c
    INNER JOIN CarrerasFacultad cf ON c.ID = cf.CarreraID
    INNER JOIN Facultades f ON cf.FacultadID = f.ID
    WHERE c.ID = @CarreraID;
END;
GO


-- ELIMINAR ---

