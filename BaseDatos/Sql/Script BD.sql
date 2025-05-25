
CREATE DATABASE Guarderia;
GO

USE Guarderia;
GO


-- Tabla: Niños
CREATE TABLE Ninos (
    IdNino INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    NombreTutor VARCHAR(100) NOT NULL,
    TelefonoTutor VARCHAR(20),
    Direccion VARCHAR(200),
    Activo BIT NOT NULL DEFAULT 1
);
GO

-- Tabla: Servicios
CREATE TABLE Servicios (
    IdServicio INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255),
    Precio DECIMAL(10,2) NOT NULL,
    Tipo VARCHAR(50) -- Ej: 'Fijo', 'Extra'
);
GO

-- Tabla: Facturas (cabecera)
CREATE TABLE Facturas (
    IdFactura INT IDENTITY(1,1) PRIMARY KEY,
    FechaFactura DATETIME NOT NULL DEFAULT GETDATE(),
    IdNino INT NOT NULL,
    Total DECIMAL(10,2) NOT NULL,
    Estado VARCHAR(20) NOT NULL, -- Ej: 'Pendiente', 'Pagada'
    MetodoPago VARCHAR(50), -- Opcional
    Observaciones VARCHAR(255),
    FOREIGN KEY (IdNino) REFERENCES Ninos(IdNino)
);
GO

-- Tabla: DetalleFactura
CREATE TABLE DetalleFactura (
    IdDetalle INT IDENTITY(1,1) PRIMARY KEY,
    IdFactura INT NOT NULL,
    IdServicio INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    Subtotal AS (Cantidad * PrecioUnitario) PERSISTED,
    FOREIGN KEY (IdFactura) REFERENCES Facturas(IdFactura),
    FOREIGN KEY (IdServicio) REFERENCES Servicios(IdServicio)
);
GO

INSERT INTO Ninos (Nombre, Apellido, FechaNacimiento, NombreTutor, TelefonoTutor, Direccion)
VALUES
('Lucía', 'Gómez', '2020-05-15', 'Ana Gómez', '8095551234', 'Av. Central 101'),
('Mateo', 'Ramírez', '2019-10-22', 'Carlos Ramírez', '8293334455', 'Calle 2 #14'),
('Valentina', 'Fernández', '2021-01-10', 'Laura Fernández', '8097778899', 'Zona Universitaria'),
('Santiago', 'Martínez', '2020-03-05', 'Luis Martínez', '8492223344', 'Ens. Naco'),
('Isabella', 'Rodríguez', '2021-07-29', 'Paola Rodríguez', '8091112233', 'Bávaro, PC');


INSERT INTO Servicios (Nombre, Descripcion, Precio, Tipo)
VALUES
('Mensualidad base', 'Cuidado mensual estándar', 7000.00, 'Fijo'),
('Almuerzo diario', 'Comida completa durante el día', 2000.00, 'Fijo'),
('Merienda', 'Snack matutino y vespertino', 1000.00, 'Fijo'),
('Cuidado extendido', 'Horario hasta las 6:00 p.m.', 1500.00, 'Fijo'),
('Transporte escolar', 'Ida y vuelta a casa', 2500.00, 'Fijo'),
('Clases de arte', 'Taller de arte infantil', 1500.00, 'Extra'),
('Clases de inglés', 'Aprendizaje básico del idioma', 1800.00, 'Extra'),
('Campamento de verano', 'Actividades durante vacaciones', 3000.00, 'Extra');



-- Factura 1 para Lucía
INSERT INTO Facturas (IdNino, Total, Estado, MetodoPago)
VALUES (1, 11500.00, 'Pagada', 'Efectivo');

-- Factura 2 para Mateo
INSERT INTO Facturas (IdNino, Total, Estado, MetodoPago)
VALUES (2, 8500.00, 'Pendiente', 'Transferencia');

-- Factura 3 para Valentina
INSERT INTO Facturas (IdNino, Total, Estado, MetodoPago)
VALUES (3, 9000.00, 'Pagada', 'Tarjeta');

-- Factura 4 para Isabella
INSERT INTO Facturas (IdNino, Total, Estado, MetodoPago)
VALUES (5, 10500.00, 'Pagada', 'Efectivo');

--===========DETALLE FACTURA ==============
-- Factura 1 - Lucía
INSERT INTO DetalleFactura (IdFactura, IdServicio, Cantidad, PrecioUnitario)
VALUES
(1, 1, 1, 7000.00),
(1, 2, 1, 2000.00),
(1, 6, 1, 1500.00),
(1, 3, 1, 1000.00);

-- Factura 2 - Mateo
INSERT INTO DetalleFactura (IdFactura, IdServicio, Cantidad, PrecioUnitario)
VALUES
(2, 1, 1, 7000.00),
(2, 4, 1, 1500.00);

-- Factura 3 - Valentina
INSERT INTO DetalleFactura (IdFactura, IdServicio, Cantidad, PrecioUnitario)
VALUES
(3, 1, 1, 7000.00),
(3, 7, 1, 1800.00),
(3, 3, 1, 1000.00);

-- Factura 4 - Isabella
INSERT INTO DetalleFactura (IdFactura, IdServicio, Cantidad, PrecioUnitario)
VALUES
(4, 1, 1, 7000.00),
(4, 2, 1, 2000.00),
(4, 5, 1, 2500.00);

--ver la factura

SELECT 
    F.IdFactura,
    F.FechaFactura,
    N.Nombre + ' ' + N.Apellido AS NombreNino,
    F.Total,
    F.Estado,
    F.MetodoPago
FROM 
    Facturas F
INNER JOIN 
    Ninos N ON F.IdNino = N.IdNino
ORDER BY 
    F.FechaFactura DESC;


	--ver los servicios 

	SELECT 
    S.Nombre AS Servicio,
    S.Tipo,
    D.Cantidad,
    D.PrecioUnitario,
    D.Subtotal,
    F.IdFactura,
    F.FechaFactura,
    N.Nombre + ' ' + N.Apellido AS NombreNino
FROM 
    DetalleFactura D
INNER JOIN 
    Servicios S ON D.IdServicio = S.IdServicio
INNER JOIN 
    Facturas F ON D.IdFactura = F.IdFactura
INNER JOIN 
    Ninos N ON F.IdNino = N.IdNino
ORDER BY 
    F.FechaFactura DESC, S.Nombre;

--==========================PROCEDIMIENTOS ALMACENADOS===================
use Guarderia
--======TABLA NIÑOS ======================

--insertar
CREATE PROCEDURE sp_InsertarNino
    @Nombre VARCHAR(100),
    @Apellido VARCHAR(100),
    @FechaNacimiento DATE,
    @NombreTutor VARCHAR(100),
    @TelefonoTutor VARCHAR(20),
    @Direccion VARCHAR(200)
AS
BEGIN
    INSERT INTO Ninos (Nombre, Apellido, FechaNacimiento, NombreTutor, TelefonoTutor, Direccion)
    VALUES (@Nombre, @Apellido, @FechaNacimiento, @NombreTutor, @TelefonoTutor, @Direccion);
END;
GO

--
CREATE PROCEDURE sp_ObtenerNinos
AS
BEGIN
    SELECT * FROM Ninos WHERE Activo = 1;
END;
GO

---actualizar 
CREATE PROCEDURE sp_ActualizarNino
    @IdNino INT,
    @Nombre VARCHAR(100),
    @Apellido VARCHAR(100),
    @FechaNacimiento DATE,
    @NombreTutor VARCHAR(100),
    @TelefonoTutor VARCHAR(20),
    @Direccion VARCHAR(200),
    @Activo BIT
AS
BEGIN
    UPDATE Ninos
    SET Nombre = @Nombre,
        Apellido = @Apellido,
        FechaNacimiento = @FechaNacimiento,
        NombreTutor = @NombreTutor,
        TelefonoTutor = @TelefonoTutor,
        Direccion = @Direccion,
        Activo = @Activo
    WHERE IdNino = @IdNino;
END;
GO

--eliminar

CREATE PROCEDURE sp_EliminarNino
    @IdNino INT
AS
BEGIN
    UPDATE Ninos
    SET Activo = 0
    WHERE IdNino = @IdNino;
END;
GO




---==========Tabla Servicios==========================
CREATE PROCEDURE sp_InsertarServicio
    @Nombre VARCHAR(100),
    @Descripcion VARCHAR(255),
    @Precio DECIMAL(10,2),
    @Tipo VARCHAR(50)
AS
BEGIN
    INSERT INTO Servicios (Nombre, Descripcion, Precio, Tipo)
    VALUES (@Nombre, @Descripcion, @Precio, @Tipo);
END;
GO
--me quede aqui en ejecucion

CREATE PROCEDURE sp_ObtenerServicios
AS
BEGIN
    SELECT * FROM Servicios;
END;
GO


CREATE PROCEDURE sp_ActualizarServicio
    @IdServicio INT,
    @Nombre VARCHAR(100),
    @Descripcion VARCHAR(255),
    @Precio DECIMAL(10,2),
    @Tipo VARCHAR(50)
AS
BEGIN
    UPDATE Servicios
    SET Nombre = @Nombre,
        Descripcion = @Descripcion,
        Precio = @Precio,
        Tipo = @Tipo
    WHERE IdServicio = @IdServicio;
END;
GO


CREATE PROCEDURE sp_EliminarServicio
    @IdServicio INT
AS
BEGIN
    DELETE FROM Servicios
    WHERE IdServicio = @IdServicio;
END;
GO

---===========Tabla factura==============

CREATE PROCEDURE sp_InsertarFactura
    @IdNino INT,
    @Total DECIMAL(10,2),
    @Estado VARCHAR(20),
    @MetodoPago VARCHAR(50),
    @Observaciones VARCHAR(255)
AS
BEGIN
    INSERT INTO Facturas (IdNino, Total, Estado, MetodoPago, Observaciones)
    VALUES (@IdNino, @Total, @Estado, @MetodoPago, @Observaciones);

    SELECT SCOPE_IDENTITY() AS IdFactura; -- Devuelve el ID generado
END;
GO


CREATE PROCEDURE sp_ObtenerFacturas
AS
BEGIN
    SELECT F.IdFactura, F.FechaFactura, N.Nombre + ' ' + N.Apellido AS NombreNino,
           F.Total, F.Estado, F.MetodoPago, F.Observaciones
    FROM Facturas F
    INNER JOIN Ninos N ON F.IdNino = N.IdNino;
END;
GO


CREATE PROCEDURE sp_ActualizarFactura
    @IdFactura INT,
    @IdNino INT,
    @Total DECIMAL(10,2),
    @Estado VARCHAR(20),
    @MetodoPago VARCHAR(50),
    @Observaciones VARCHAR(255)
AS
BEGIN
    UPDATE Facturas
    SET IdNino = @IdNino,
        Total = @Total,
        Estado = @Estado,
        MetodoPago = @MetodoPago,
        Observaciones = @Observaciones
    WHERE IdFactura = @IdFactura;
END;
GO


CREATE PROCEDURE sp_EliminarFactura
    @IdFactura INT
AS
BEGIN
    DELETE FROM DetalleFactura WHERE IdFactura = @IdFactura; -- primero detalle
    DELETE FROM Facturas WHERE IdFactura = @IdFactura;
END;
GO


---------------===================Tabla Detalle Factura================================

CREATE PROCEDURE sp_InsertarDetalleFactura
    @IdFactura INT,
    @IdServicio INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10,2)
AS
BEGIN
    INSERT INTO DetalleFactura (IdFactura, IdServicio, Cantidad, PrecioUnitario)
    VALUES (@IdFactura, @IdServicio, @Cantidad, @PrecioUnitario);
END;
GO



CREATE PROCEDURE sp_ObtenerDetalleFactura
    @IdFactura INT
AS
BEGIN
    SELECT DF.IdDetalle, S.Nombre AS Servicio, DF.Cantidad, DF.PrecioUnitario, DF.Subtotal
    FROM DetalleFactura DF
    INNER JOIN Servicios S ON DF.IdServicio = S.IdServicio
    WHERE DF.IdFactura = @IdFactura;
END;
GO



CREATE PROCEDURE sp_EliminarDetalleFactura
    @IdDetalle INT
AS
BEGIN
    DELETE FROM DetalleFactura WHERE IdDetalle = @IdDetalle;
END;
GO


CREATE TRIGGER trg_ActualizarTotalFactura
ON DetalleFactura
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE F
    SET Total = (
        SELECT SUM(Subtotal)
        FROM DetalleFactura DF
        WHERE DF.IdFactura = F.IdFactura
    )
    FROM Facturas F
    WHERE F.IdFactura IN (
        SELECT IdFactura FROM inserted
        UNION
        SELECT IdFactura FROM deleted
    );
END;
GO




CREATE PROCEDURE sp_EditarDetalleFactura
    @IdDetalle INT,
    @IdServicio INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10,2)
AS
BEGIN
    UPDATE DetalleFactura
    SET IdServicio = @IdServicio,
        Cantidad = @Cantidad,
        PrecioUnitario = @PrecioUnitario
    WHERE IdDetalle = @IdDetalle;
END;
GO
