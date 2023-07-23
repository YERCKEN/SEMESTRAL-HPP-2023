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



-- Ejemplo 1
INSERT INTO proveedores (ruc, nombre, correo, tipo, telefono, observacion)
VALUES ('12345678901', 'Proveedor A', 'proveedorA@example.com', 'Suministros de oficina', '+1234567890', 'Proveedor confiable para suministros de oficina.');

-- Ejemplo 2
INSERT INTO proveedores (ruc, nombre, correo, tipo, telefono, observacion)
VALUES ('98765432102', 'Proveedor B', 'proveedorB@example.com', 'Catering', '+9876543210', 'Proveedor especializado en servicios de catering para eventos.');

-- Ejemplo 3
INSERT INTO proveedores (ruc, nombre, correo, tipo, telefono, observacion)
VALUES ('45678901203', 'Proveedor C', 'proveedorC@example.com', 'Servicios de limpieza', '+4567890120', 'Proveedor que ofrece servicios de limpieza para edificios y �reas comunes.');



-- Ejemplo 1
INSERT INTO clientes (nombre, apellido, residencia, lugar_trabajo, telefono1, telefono2, email, tipo, observacion)
VALUES ('Ana', 'Garc�a', 'Calle 123, Ciudad Universitaria', 'Biblioteca Central', '+1234567890', '+9876543210', 'ana.garcia@example.com', 'Prospecto', 'Estudiante de �ltimo a�o de Biolog�a, interesada en la investigaci�n de la vida marina.');

-- Ejemplo 2
INSERT INTO clientes (nombre, apellido, residencia, lugar_trabajo, telefono1, telefono2, email, tipo, observacion)
VALUES ('Juan', 'Mart�nez', 'Avenida Principal, Barrio Universitario', 'Departamento de F�sica', '+2345678901', NULL, 'juan.martinez@example.com', 'Prospecto', 'Estudiante de primer a�o de F�sica, apasionado por la astronom�a.');

-- Ejemplo 3
INSERT INTO clientes (nombre, apellido, residencia, lugar_trabajo, telefono1, telefono2, email, tipo, observacion)
VALUES ('Mar�a', 'L�pez', 'Calle Estudiantil, Residencias Universitarias', NULL, '+3456789012', NULL, 'maria.lopez@example.com', 'Estudiante', 'Estudiante de Ciencias de la Computaci�n, l�der de un grupo de desarrollo de aplicaciones m�viles.');

-- Ejemplo 4
INSERT INTO clientes (nombre, apellido, residencia, lugar_trabajo, telefono1, telefono2, email, tipo, observacion)
VALUES ('Pedro', 'Ram�rez', 'Avenida Universitaria, Edificio C', 'Laboratorio de Qu�mica', '+4567890123', '+8765432109', 'pedro.ramirez@example.com', 'Prospecto', 'Estudiante de tercer a�o de Qu�mica, interesado en la s�ntesis de materiales.');

-- Ejemplo 5
INSERT INTO clientes (nombre, apellido, residencia, lugar_trabajo, telefono1, telefono2, email, tipo, observacion)
VALUES ('Laura', 'Gonz�lez', 'Calle del Conocimiento, Residencias Estudiantiles', NULL, '+5678901234', NULL, 'laura.gonzalez@example.com', 'Estudiante', 'Estudiante de Artes Esc�nicas, participa en varios grupos de teatro universitario.');


-- Ejemplo 1
INSERT INTO clienteopciones (id_cliente, opcion1, opcion2, opcion3, convocatoria)
VALUES (1, 'Participar en proyecto de investigaci�n', 'Asistir a conferencias sobre biolog�a marina', 'Realizar pr�cticas en laboratorio', 'Convocatoria para estudiantes interesados en proyectos de investigaci�n.');

-- Ejemplo 2
INSERT INTO clienteopciones (id_cliente, opcion1, opcion2, opcion3, convocatoria)
VALUES (2, 'Inscribirse en club de astronom�a', 'Participar en observaciones astron�micas', 'Asistir a talleres de f�sica', 'Convocatoria para actividades extracurriculares en el �rea de astronom�a.');

-- Ejemplo 3
INSERT INTO clienteopciones (id_cliente, opcion1, opcion2, opcion3, convocatoria)
VALUES (3, 'Participar en desarrollo de aplicaciones m�viles', 'Realizar cursos de programaci�n', 'Unirse a equipo de rob�tica', 'Convocatoria para estudiantes interesados en tecnolog�a y desarrollo de aplicaciones m�viles.');

-- Ejemplo 4
INSERT INTO clienteopciones (id_cliente, opcion1, opcion2, opcion3, convocatoria)
VALUES (4, 'Realizar pr�cticas en laboratorio de qu�mica', 'Participar en proyectos de investigaci�n', 'Asistir a seminarios sobre qu�mica', 'Convocatoria para estudiantes interesados en pr�cticas de laboratorio.');

-- Ejemplo 5
INSERT INTO clienteopciones (id_cliente, opcion1, opcion2, opcion3, convocatoria)
VALUES (5, 'Participar en grupos de teatro universitario', 'Asistir a talleres de actuaci�n', 'Organizar eventos culturales', 'Convocatoria para estudiantes interesados en arte y teatro universitario.');





-- INVENTARIO ==============================================================================================================
GO

CREATE TABLE Inventario (
    ID INT PRIMARY KEY,
    Tipo VARCHAR(50) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Cantidad INT,
    Estado VARCHAR(50) NOT NULL,
    Ubicacion VARCHAR(100) NOT NULL,
    Observaciones VARCHAR(255)
);


GO

INSERT INTO Inventario (ID, Tipo, Nombre, Cantidad, Estado, Ubicacion, Observaciones)
VALUES
    (1, 'Equipo', 'Proyector', 3, 'En uso', 'Aula 101', 'Funciona correctamente'),
    (2, 'Equipo', 'Computadora', 30, 'En uso', 'Laboratorio 201', 'Actualizar software'),
    (3, 'Equipo', 'Impresora', 5, 'Reparaci�n', 'Almac�n', 'Problema de papel'),
    (4, 'Recurso', 'Libro', 200, 'Disponible', 'Biblioteca', ''),
    (5, 'Recurso', 'Microscopio', 10, 'En uso', 'Laboratorio 301', 'Lente da�ado'),
    (6, 'Recurso', 'Material de arte', 50, 'Disponible', 'Aula 105', ''),
    (7, 'Equipo', 'Pizarra Interactiva', 2, 'En uso', 'Aula 202', 'Calibraci�n necesaria'),
    (8, 'Equipo', 'C�mara fotogr�fica', 8, 'Disponible', 'Laboratorio 401', ''),
    (9, 'Recurso', 'Mapas', 20, 'Disponible', 'Departamento de Geograf�a', ''),
    (10, 'Equipo', 'Esc�ner', 4, 'Reparaci�n', 'Almac�n', 'Atascado con papel');


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
