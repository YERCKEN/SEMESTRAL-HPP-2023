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
    ('Conferencia', 'Charla de orientación', '09:00:00', '2023-07-25', '2023-07-25', 'Charla de bienvenida y orientación para nuevos estudiantes.'),
    ('Taller', 'Taller de escritura', '14:30:00', '2023-08-02', '2023-08-04', 'Taller intensivo para mejorar habilidades de escritura académica.'),
    ('Exposición', 'Feria de carreras', '10:00:00', '2023-09-10', '2023-09-10', 'Exposición de todas las carreras ofrecidas por la universidad para futuros estudiantes.'),
    ('Reunión', 'Reunión de profesores', '15:00:00', '2023-09-20', '2023-09-20', 'Reunión del cuerpo docente para discutir el plan académico del próximo semestre.'),
    ('Actividad deportiva', 'Torneo interuniversitario', '09:00:00', '2023-10-05', '2023-10-07', 'Torneo deportivo entre diferentes universidades con múltiples disciplinas.');



-- Ejemplo 1
INSERT INTO proveedores (ruc, nombre, correo, tipo, telefono, observacion)
VALUES ('12345678901', 'Proveedor A', 'proveedorA@example.com', 'Suministros de oficina', '+1234567890', 'Proveedor confiable para suministros de oficina.');

-- Ejemplo 2
INSERT INTO proveedores (ruc, nombre, correo, tipo, telefono, observacion)
VALUES ('98765432102', 'Proveedor B', 'proveedorB@example.com', 'Catering', '+9876543210', 'Proveedor especializado en servicios de catering para eventos.');

-- Ejemplo 3
INSERT INTO proveedores (ruc, nombre, correo, tipo, telefono, observacion)
VALUES ('45678901203', 'Proveedor C', 'proveedorC@example.com', 'Servicios de limpieza', '+4567890120', 'Proveedor que ofrece servicios de limpieza para edificios y áreas comunes.');



-- Ejemplo 1
INSERT INTO clientes (nombre, apellido, residencia, lugar_trabajo, telefono1, telefono2, email, tipo, observacion)
VALUES ('Ana', 'García', 'Calle 123, Ciudad Universitaria', 'Biblioteca Central', '+1234567890', '+9876543210', 'ana.garcia@example.com', 'Prospecto', 'Estudiante de último año de Biología, interesada en la investigación de la vida marina.');

-- Ejemplo 2
INSERT INTO clientes (nombre, apellido, residencia, lugar_trabajo, telefono1, telefono2, email, tipo, observacion)
VALUES ('Juan', 'Martínez', 'Avenida Principal, Barrio Universitario', 'Departamento de Física', '+2345678901', NULL, 'juan.martinez@example.com', 'Prospecto', 'Estudiante de primer año de Física, apasionado por la astronomía.');

-- Ejemplo 3
INSERT INTO clientes (nombre, apellido, residencia, lugar_trabajo, telefono1, telefono2, email, tipo, observacion)
VALUES ('María', 'López', 'Calle Estudiantil, Residencias Universitarias', NULL, '+3456789012', NULL, 'maria.lopez@example.com', 'Estudiante', 'Estudiante de Ciencias de la Computación, líder de un grupo de desarrollo de aplicaciones móviles.');

-- Ejemplo 4
INSERT INTO clientes (nombre, apellido, residencia, lugar_trabajo, telefono1, telefono2, email, tipo, observacion)
VALUES ('Pedro', 'Ramírez', 'Avenida Universitaria, Edificio C', 'Laboratorio de Química', '+4567890123', '+8765432109', 'pedro.ramirez@example.com', 'Prospecto', 'Estudiante de tercer año de Química, interesado en la síntesis de materiales.');

-- Ejemplo 5
INSERT INTO clientes (nombre, apellido, residencia, lugar_trabajo, telefono1, telefono2, email, tipo, observacion)
VALUES ('Laura', 'González', 'Calle del Conocimiento, Residencias Estudiantiles', NULL, '+5678901234', NULL, 'laura.gonzalez@example.com', 'Estudiante', 'Estudiante de Artes Escénicas, participa en varios grupos de teatro universitario.');


-- Ejemplo 1
INSERT INTO clienteopciones (id_cliente, opcion1, opcion2, opcion3, convocatoria)
VALUES (1, 'Participar en proyecto de investigación', 'Asistir a conferencias sobre biología marina', 'Realizar prácticas en laboratorio', 'Convocatoria para estudiantes interesados en proyectos de investigación.');

-- Ejemplo 2
INSERT INTO clienteopciones (id_cliente, opcion1, opcion2, opcion3, convocatoria)
VALUES (2, 'Inscribirse en club de astronomía', 'Participar en observaciones astronómicas', 'Asistir a talleres de física', 'Convocatoria para actividades extracurriculares en el área de astronomía.');

-- Ejemplo 3
INSERT INTO clienteopciones (id_cliente, opcion1, opcion2, opcion3, convocatoria)
VALUES (3, 'Participar en desarrollo de aplicaciones móviles', 'Realizar cursos de programación', 'Unirse a equipo de robótica', 'Convocatoria para estudiantes interesados en tecnología y desarrollo de aplicaciones móviles.');

-- Ejemplo 4
INSERT INTO clienteopciones (id_cliente, opcion1, opcion2, opcion3, convocatoria)
VALUES (4, 'Realizar prácticas en laboratorio de química', 'Participar en proyectos de investigación', 'Asistir a seminarios sobre química', 'Convocatoria para estudiantes interesados en prácticas de laboratorio.');

-- Ejemplo 5
INSERT INTO clienteopciones (id_cliente, opcion1, opcion2, opcion3, convocatoria)
VALUES (5, 'Participar en grupos de teatro universitario', 'Asistir a talleres de actuación', 'Organizar eventos culturales', 'Convocatoria para estudiantes interesados en arte y teatro universitario.');





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
    (3, 'Equipo', 'Impresora', 5, 'Reparación', 'Almacén', 'Problema de papel'),
    (4, 'Recurso', 'Libro', 200, 'Disponible', 'Biblioteca', ''),
    (5, 'Recurso', 'Microscopio', 10, 'En uso', 'Laboratorio 301', 'Lente dañado'),
    (6, 'Recurso', 'Material de arte', 50, 'Disponible', 'Aula 105', ''),
    (7, 'Equipo', 'Pizarra Interactiva', 2, 'En uso', 'Aula 202', 'Calibración necesaria'),
    (8, 'Equipo', 'Cámara fotográfica', 8, 'Disponible', 'Laboratorio 401', ''),
    (9, 'Recurso', 'Mapas', 20, 'Disponible', 'Departamento de Geografía', ''),
    (10, 'Equipo', 'Escáner', 4, 'Reparación', 'Almacén', 'Atascado con papel');


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
