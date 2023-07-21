CREATE DATABASE baseDeDatos2;
USE baseDeDatos2;
-- Crear tabla servicios
CREATE TABLE servicios (
    id_servicios INT IDENTITY(1,1) PRIMARY KEY,
    tipo VARCHAR(255),
    evento VARCHAR(255),
    fechainicio DATE,
    fechafinal DATE,
    observacion VARCHAR(500)
);

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

-- Crear tabla inventario
CREATE TABLE inventario (
    id_inventario INT IDENTITY(1,1) PRIMARY KEY,
    tipo VARCHAR(50),
    descripcion VARCHAR(255),
    estado VARCHAR(50),
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