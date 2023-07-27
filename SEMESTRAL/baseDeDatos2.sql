CREATE DATABASE baseDeDatos2;
USE baseDeDatos2;

-- Crear tabla servicios
CREATE TABLE servicios (
    id_servicios INT IDENTITY(1,1) PRIMARY KEY,
    tipo VARCHAR(255),
    evento VARCHAR(255),
	horainicio VARCHAR(50),
    fechainicio DATE,
    fechafinal DATE,
    observacion VARCHAR(500)
);


-- Eliminar la tabla "servicios"
-- Crear tabla proveedores
CREATE TABLE proveedores (
    id_proveedores INT IDENTITY(1,1) PRIMARY KEY,
    ruc VARCHAR(20),
    nombre VARCHAR(255),
    correo VARCHAR(100),
    tipo VARCHAR(50),
    telefono VARCHAR(20),
    observacion VARCHAR(500)
);



-- Crear tabla clientes
CREATE TABLE clientes (
    id_clientes INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100),
    apellido VARCHAR(100),
    residencia VARCHAR(200),
    lugar_trabajo VARCHAR(200),
    telefono1 VARCHAR(20),
    telefono2 VARCHAR(20),
    email VARCHAR(100),
	tipo VARCHAR(100),
    observacion VARCHAR(500)
);
CREATE TABLE clienteopciones (
    id_clienteopcion INT IDENTITY(1,1) PRIMARY KEY,
    id_cliente INT,
    opcion1 VARCHAR(255),
    opcion2 VARCHAR(255),
    opcion3 VARCHAR(255),
    convocatoria VARCHAR(255),
    FOREIGN KEY (id_cliente) REFERENCES clientes(id_clientes)
);

-- DATOS SERVICIOS
INSERT INTO servicios (tipo, evento, horainicio, fechainicio, fechafinal, observacion)
VALUES 
    ('Eventos especiales', 'Conferencia inaugural', '10:00:00', '2023-07-28', '2023-07-28', 'Evento de apertura del nuevo a�o acad�mico con discursos y presentaciones destacadas.'),
    ('Giras de promoci�n de carreras', 'Gira en colegios secundarios', '08:30:00', '2023-08-10', '2023-08-15', 'Visita a diferentes colegios para promocionar las carreras universitarias.'),
    ('Descuento de carreras', 'Semana de descuentos', '09:00:00', '2023-09-02', '2023-09-09', 'Semana especial con descuentos en la matr�cula de todas las carreras.'),
    ('Atenci�n al cliente', 'Jornada de puertas abiertas', '14:00:00', '2023-10-15', '2023-10-15', 'Jornada especial para recibir a futuros estudiantes y brindarles atenci�n personalizada.');


INSERT INTO proveedores (ruc, nombre, correo, tipo, telefono, observacion)
VALUES 
    ('12345678901', 'Proveedor X', 'proveedorX@example.com', 'Insumos', '+50761234567', 'Proveedor confiable para suministros de oficina.'),
    ('98765432102', 'Proveedor Y', 'proveedorY@example.com', 'Mensajer�a', '+50761234568', 'Proveedor especializado en servicios de mensajer�a y entrega de paquetes.'),
    ('45678901203', 'Proveedor Z', 'proveedorZ@example.com', 'Log�stica', '+50761234569', 'Proveedor que ofrece soluciones log�sticas y de transporte para empresas.');


INSERT INTO clientes (nombre, apellido, residencia, lugar_trabajo, telefono1, telefono2, email, tipo, observacion)
VALUES 
    ('Ana', 'Garc�a', 'Calle 123, Ciudad Universitaria', 'Biblioteca Central', '+50761234567', '+50762123456', 'ana.garcia@example.com', 'Prospecto', 'Estudiante de �ltimo a�o de Biolog�a, interesada en la investigaci�n de la vida marina.'),
    ('Juan', 'Mart�nez', 'Avenida Principal, Barrio Universitario', 'Departamento de F�sica', '+50761234568', NULL, 'juan.martinez@example.com', 'Prospecto', 'Estudiante de primer a�o de F�sica, apasionado por la astronom�a.'),
    ('Mar�a', 'L�pez', 'Calle Estudiantil, Residencias Universitarias', NULL, '+50761234569', NULL, 'maria.lopez@example.com', 'Estudiante', 'Estudiante de Ciencias de la Computaci�n, l�der de un grupo de desarrollo de aplicaciones m�viles.'),
    ('Pedro', 'Ram�rez', 'Avenida Universitaria, Edificio C', 'Laboratorio de Qu�mica', '+50761234570', '+50761234571', 'pedro.ramirez@example.com', 'Prospecto', 'Estudiante de tercer a�o de Qu�mica, interesado en la s�ntesis de materiales.'),
    ('Laura', 'Gonz�lez', 'Calle del Conocimiento, Residencias Estudiantiles', NULL, '+50761234572', NULL, 'laura.gonzalez@example.com', 'Estudiante', 'Estudiante de Artes Esc�nicas, participa en varios grupos de teatro universitario.');

INSERT INTO clienteopciones (id_cliente, opcion1, opcion2, opcion3, convocatoria)
VALUES 
    (1, 'Licenciatura en Ingenier�a Civil', 'Licenciatura en Ingenier�a Industrial', 'Licenciatura en Ingenier�a Mec�nica Industrial', 'Convocatoria 1'),
    (2, 'Licenciatura en Ingenier�a Electromec�nica', 'Licenciatura en Ingenier�a de Sistemas y Computaci�n', 'Licenciatura en Ingenier�a en Alimentos', 'Convocatoria 2'),
    (3, 'Licenciatura en Ingenier�a de Sistemas y Informaci�n Software', NULL, NULL, 'Convocatoria 1'),
    (4, 'Licenciatura en Ingenier�a Civil', 'Licenciatura en Ingenier�a Industrial', 'Licenciatura en Ingenier�a Mec�nica Industrial', 'Convocatoria 1'),
    (5, 'Licenciatura en Ingenier�a Electromec�nica', 'Licenciatura en Ingenier�a de Sistemas y Computaci�n', 'Licenciatura en Ingenier�a en Alimentos', 'Convocatoria 2');



-- INVENTARIO ==============================================================================================================
GO


CREATE TABLE Inventario (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Tipo VARCHAR(50) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Estado VARCHAR(50) NOT NULL,
    Ubicacion VARCHAR(100) NOT NULL,
    Fecha DATE NOT NULL,
    Observaciones VARCHAR(255)
);

GO

INSERT INTO Inventario (Tipo, Nombre, Estado, Ubicacion, Fecha, Observaciones)
VALUES
    ('Equipo', 'Laptop Dell XPS 15', 'En uso', 'Oficina 101', '2023-07-23', 'Actualizaci�n de software'),
    ('Recurso', 'Borrador BIC', 'Disponible', 'Aula 201', '2023-07-23', ''),
    ('Equipo', 'Proyector Epson PowerLite 2150', 'Reparaci�n', 'Almac�n', '2023-07-23', 'Problema de l�mpara'),
    ('Recurso', 'Calculadora Casio', 'En uso', 'Aula 102', '2023-07-23', ''),
    ('Equipo', 'Impresora HP LaserJet', 'Disponible', 'Oficina 202', '2023-07-23', ''),
    ('Recurso', 'Cuadernos Norma', 'Disponible', 'Biblioteca', '2023-07-23', ''),
    ('Equipo', 'Escritorio de madera', 'En uso', 'Oficina 203', '2023-07-23', 'Reparar pata rota'),
    ('Recurso', 'L�pices Faber-Castell 2B', 'Disponible', 'Aula 103', '2023-07-23', ''),
    ('Equipo', 'Monitor LG 27GL850-B', 'En uso', 'Laboratorio 301', '2023-07-23', ''),
    ('Recurso', 'Tijeras Fiskars Titanium', 'Disponible', 'Aula 104', '2023-07-23', ''),
	('Recurso', 'Tijeras Fiskars Titanium', 'Disponible', 'Aula 104', '2023-07-23', '');

INSERT INTO Inventario (Tipo, Nombre, Estado, Ubicacion, Fecha, Observaciones)
VALUES
('Recurso', 'Tijeras Fiskars Titanium', 'Disponible', 'Aula 104', '2023-07-23', '');

-- PROCESOS ALMACENADOS PARA LOS SELECTS ------------
GO

CREATE PROCEDURE ObtenerTodosLosRegistros
AS
BEGIN
       SELECT I.ID, I.Tipo, I.Nombre, C.Cantidad, I.Estado, I.Ubicacion, I.Fecha, I.Observaciones
    FROM Inventario I
    INNER JOIN (
        SELECT Nombre, COUNT(*) AS Cantidad
        FROM Inventario
        GROUP BY Nombre
    ) C ON I.Nombre = C.Nombre;
END;


  
GO

CREATE PROCEDURE ObtenerRegistrosTipoEquipo
AS
BEGIN
    SELECT I.ID, I.Tipo, I.Nombre, C.Cantidad, I.Estado, I.Ubicacion, I.Fecha, I.Observaciones
    FROM Inventario I
    INNER JOIN (
        SELECT Nombre, COUNT(*) AS Cantidad
        FROM Inventario
        GROUP BY Nombre
    ) C ON I.Nombre = C.Nombre
    WHERE I.Tipo = 'Equipo';
END;

GO

CREATE PROCEDURE ObtenerRegistrosTipoRecurso
AS
BEGIN
    SELECT I.ID, I.Tipo, I.Nombre, C.Cantidad, I.Estado, I.Ubicacion, I.Fecha, I.Observaciones
    FROM Inventario I
    INNER JOIN (
        SELECT Nombre, COUNT(*) AS Cantidad
        FROM Inventario
        GROUP BY Nombre
    ) C ON I.Nombre = C.Nombre
    WHERE I.Tipo = 'Recurso';
END;

GO

EXEC ObtenerTodosLosRegistros;
EXEC ObtenerRegistrosTipoEquipo;
EXEC ObtenerRegistrosTipoRecurso;



-- INSERT 

CREATE PROCEDURE InsertarInventario
(
    @Tipo VARCHAR(50),
    @Nombre VARCHAR(100),
    @Estado VARCHAR(50),
    @Ubicacion VARCHAR(100),
    @Fecha DATE,
    @Observaciones VARCHAR(255)
)
AS
BEGIN
    -- Insertar los datos en la tabla Inventario
    INSERT INTO Inventario (Tipo, Nombre, Estado, Ubicacion, Fecha, Observaciones)
    VALUES (@Tipo, @Nombre, @Estado, @Ubicacion, @Fecha, @Observaciones)
END;




-- provedores

SELECT *FROM proveedores;

SELECT nombre FROM proveedores;


SELECT *FROM clientes;
SELECT *FROM servicios;



  SELECT I.ID, I.Tipo, I.Nombre, C.Cantidad, I.Estado, I.Ubicacion, I.Fecha, I.Observaciones
    FROM Inventario I
    INNER JOIN (
        SELECT Nombre, COUNT(*) AS Cantidad
        FROM Inventario
        GROUP BY Nombre
    ) C ON I.Nombre = C.Nombre;


