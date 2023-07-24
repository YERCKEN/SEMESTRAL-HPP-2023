CREATE DATABASE baseDeDatos2;
USE baseDeDatos2;

-- Crear tabla servicios
CREATE TABLE servicios (
    id_servicios INT IDENTITY(1,1) PRIMARY KEY,
    tipo VARCHAR(255),
    evento VARCHAR(255),
	horainicio TIME,
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
    ('Conferencia', 'Charla de orientaci�n', '09:00:00', '2023-07-25', '2023-07-25', 'Charla de bienvenida y orientaci�n para nuevos estudiantes.'),
    ('Taller', 'Taller de escritura', '14:30:00', '2023-08-02', '2023-08-04', 'Taller intensivo para mejorar habilidades de escritura acad�mica.'),
    ('Exposici�n', 'Feria de carreras', '10:00:00', '2023-09-10', '2023-09-10', 'Exposici�n de todas las carreras ofrecidas por la universidad para futuros estudiantes.'),
    ('Reuni�n', 'Reuni�n de profesores', '15:00:00', '2023-09-20', '2023-09-20', 'Reuni�n del cuerpo docente para discutir el plan acad�mico del pr�ximo semestre.'),
    ('Actividad deportiva', 'Torneo interuniversitario', '09:00:00', '2023-10-05', '2023-10-07', 'Torneo deportivo entre diferentes universidades con m�ltiples disciplinas.');


-- INSERT INTO proveedores
INSERT INTO proveedores (ruc, nombre, correo, tipo, telefono, observacion)
VALUES 
    ('12345678901', 'Proveedor A', 'proveedorA@example.com', 'Suministros de oficina', '+1234567890', 'Proveedor confiable para suministros de oficina.'),
    ('98765432102', 'Proveedor B', 'proveedorB@example.com', 'Catering', '+9876543210', 'Proveedor especializado en servicios de catering para eventos.'),
    ('45678901203', 'Proveedor C', 'proveedorC@example.com', 'Servicios de limpieza', '+4567890120', 'Proveedor que ofrece servicios de limpieza para edificios y �reas comunes.');

-- INSERT INTO clientes
INSERT INTO clientes (nombre, apellido, residencia, lugar_trabajo, telefono1, telefono2, email, tipo, observacion)
VALUES 
    ('Ana', 'Garc�a', 'Calle 123, Ciudad Universitaria', 'Biblioteca Central', '+1234567890', '+9876543210', 'ana.garcia@example.com', 'Prospecto', 'Estudiante de �ltimo a�o de Biolog�a, interesada en la investigaci�n de la vida marina.'),
    ('Juan', 'Mart�nez', 'Avenida Principal, Barrio Universitario', 'Departamento de F�sica', '+2345678901', NULL, 'juan.martinez@example.com', 'Prospecto', 'Estudiante de primer a�o de F�sica, apasionado por la astronom�a.'),
    ('Mar�a', 'L�pez', 'Calle Estudiantil, Residencias Universitarias', NULL, '+3456789012', NULL, 'maria.lopez@example.com', 'Estudiante', 'Estudiante de Ciencias de la Computaci�n, l�der de un grupo de desarrollo de aplicaciones m�viles.'),
    ('Pedro', 'Ram�rez', 'Avenida Universitaria, Edificio C', 'Laboratorio de Qu�mica', '+4567890123', '+8765432109', 'pedro.ramirez@example.com', 'Prospecto', 'Estudiante de tercer a�o de Qu�mica, interesado en la s�ntesis de materiales.'),
    ('Laura', 'Gonz�lez', 'Calle del Conocimiento, Residencias Estudiantiles', NULL, '+5678901234', NULL, 'laura.gonzalez@example.com', 'Estudiante', 'Estudiante de Artes Esc�nicas, participa en varios grupos de teatro universitario.');

-- INSERT INTO clienteopciones
INSERT INTO clienteopciones (id_cliente, opcion1, opcion2, opcion3, convocatoria)
VALUES 
    (1, 'Participar en proyecto de investigaci�n', 'Asistir a conferencias sobre biolog�a marina', 'Realizar pr�cticas en laboratorio', 'Convocatoria para estudiantes interesados en proyectos de investigaci�n.'),
    (2, 'Inscribirse en club de astronom�a', 'Participar en observaciones astron�micas', 'Asistir a talleres de f�sica', 'Convocatoria para actividades extracurriculares en el �rea de astronom�a.'),
    (3, 'Participar en desarrollo de aplicaciones m�viles', 'Realizar cursos de programaci�n', 'Unirse a equipo de rob�tica', 'Convocatoria para estudiantes interesados en tecnolog�a y desarrollo de aplicaciones m�viles.'),
    (4, 'Realizar pr�cticas en laboratorio de qu�mica', 'Participar en proyectos de investigaci�n', 'Asistir a seminarios sobre qu�mica', 'Convocatoria para estudiantes interesados en pr�cticas de laboratorio.'),
    (5, 'Participar en grupos de teatro universitario', 'Asistir a talleres de actuaci�n', 'Organizar eventos culturales', 'Convocatoria para estudiantes interesados en arte y teatro universitario.');



-- INVENTARIO ==============================================================================================================
GO


CREATE TABLE Inventario (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Tipo VARCHAR(50) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Cantidad INT,
    Estado VARCHAR(50) NOT NULL,
    Ubicacion VARCHAR(100) NOT NULL,
    Fecha DATE NOT NULL,
    Observaciones VARCHAR(255)
);

GO

INSERT INTO Inventario (Tipo, Nombre, Cantidad, Estado, Ubicacion, Fecha, Observaciones)
VALUES
    ('Equipo', 'Port�til', 5, 'En uso', 'Oficina 101', '2023-07-23', 'Actualizaci�n de software'),
    ('Recurso', 'Borrador', 50, 'Disponible', 'Aula 201', '2023-07-23', ''),
    ('Equipo', 'Proyector', 2, 'Reparaci�n', 'Almac�n', '2023-07-23', 'Problema de l�mpara'),
    ('Recurso', 'Calculadora', 20, 'En uso', 'Aula 102', '2023-07-23', ''),
    ('Equipo', 'Impresora', 3, 'Disponible', 'Oficina 202', '2023-07-23', ''),
    ('Recurso', 'Cuadernos', 100, 'Disponible', 'Biblioteca', '2023-07-23', ''),
    ('Equipo', 'Escritorio', 10, 'En uso', 'Oficina 203', '2023-07-23', 'Reparar pata rota'),
    ('Recurso', 'L�pices', 200, 'Disponible', 'Aula 103', '2023-07-23', ''),
    ('Equipo', 'Monitor', 15, 'En uso', 'Laboratorio 301', '2023-07-23', ''),
    ('Recurso', 'Tijeras', 30, 'Disponible', 'Aula 104', '2023-07-23', '');

-- PROCESOS ALMACENADOS PARA LOS SELECTS ------------
GO

CREATE PROCEDURE ObtenerTodosLosRegistros
AS
BEGIN
    SELECT *
    FROM Inventario;
END;

GO

CREATE PROCEDURE ObtenerRegistrosTipoEquipo
AS
BEGIN
    SELECT *
    FROM Inventario
    WHERE Tipo = 'Equipo';
END;

GO

CREATE PROCEDURE ObtenerRegistrosTipoRecurso
AS
BEGIN
    SELECT *
    FROM Inventario
    WHERE Tipo = 'Recurso';
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
    @Cantidad INT,
    @Estado VARCHAR(50),
    @Ubicacion VARCHAR(100),
    @Fecha DATE,
    @Observaciones VARCHAR(255)
)
AS
BEGIN
    -- Insertar los datos en la tabla Inventario
    INSERT INTO Inventario (Tipo, Nombre, Cantidad, Estado, Ubicacion, Fecha, Observaciones)
    VALUES (@Tipo, @Nombre, @Cantidad, @Estado, @Ubicacion, @Fecha, @Observaciones)
END;


EXEC InsertarInventario 'TipoEjemplo', 'NombreEjemplo', 10, 'EstadoEjemplo', 'UbicacionEjemplo', '2023-07-24', 'ObservacionesEjemplo';
