-- ========================================================
-- SCRIPT DE BASE DE DATOS - DISTRIBUIDORA DE BEBIDAS
-- Estructura completa con Usuarios, Categorías, Marcas, Métodos de Pago, Productos, Clientes y Ventas
-- ========================================================

CREATE DATABASE DistribuidoraBebidasV2;
GO

USE DistribuidoraBebidasV2;
GO

-- 1. Tabla de Categorías
CREATE TABLE Categorias (
    IdCategoria VARCHAR(10) NOT NULL,
    NombreCategoria VARCHAR(50) NOT NULL,
    Fecha DATE NULL,
    CONSTRAINT PK_Categorias PRIMARY KEY (IdCategoria)
);
GO

-- 2. Tabla de Clientes
CREATE TABLE Clientes (
    IdCliente VARCHAR(10) NOT NULL,
    NombreCliente VARCHAR(100) NOT NULL,
    IdCedula VARCHAR(16) NULL,
    Telefono VARCHAR(20) NULL,
    Direccion VARCHAR(200) NULL,
    Fecha DATE NULL,
    CONSTRAINT PK_Clientes PRIMARY KEY (IdCliente)
);
GO

-- 3. Tabla de Marcas
CREATE TABLE Marcas (
    IdMarca VARCHAR(10) NOT NULL,
    NombreMarca VARCHAR(50) NOT NULL,
    CONSTRAINT PK_Marcas PRIMARY KEY (IdMarca)
);
GO

-- 4. Tabla de Métodos de Pago
CREATE TABLE MetodosPago (
    IdMetodoPago VARCHAR(10) NOT NULL,
    NombreMetodo VARCHAR(50) NOT NULL,
    CONSTRAINT PK_MetodosPago PRIMARY KEY (IdMetodoPago)
);
GO

-- 5. Tabla de Productos
CREATE TABLE Productos (
    IdProducto VARCHAR(10) NOT NULL,
    IdMarca VARCHAR(10) NOT NULL,
    IdCategoria VARCHAR(10) NOT NULL,
    NombreProducto VARCHAR(100) NOT NULL,
    PrecioUnidad DECIMAL(10, 2) NOT NULL,
    StockActual INT NOT NULL,
    CONSTRAINT PK_Productos PRIMARY KEY (IdProducto)
);
GO

-- 6. Tabla de Usuarios
CREATE TABLE Usuarios (
    IdUsuario VARCHAR(10) NOT NULL,
    NombreUsuario VARCHAR(50) NOT NULL,
    Contraseña VARCHAR(50) NOT NULL,
    Cargo VARCHAR(30) NULL,
    Estado VARCHAR(20) NULL,
    Fecha DATE NULL,
    CONSTRAINT PK_Usuarios PRIMARY KEY (IdUsuario)
);
GO

-- 7. Tabla de Ventas (Cabecera)
CREATE TABLE Ventas (
    IdVenta VARCHAR(10) NOT NULL,
    IdCliente VARCHAR(10) NOT NULL,
    FechaVenta DATETIME NOT NULL,
    TotalVenta DECIMAL(10, 2) NOT NULL,
    IdMetodoPago VARCHAR(10) NOT NULL,
    IdUsuario VARCHAR(10) NOT NULL,
    CONSTRAINT PK_Ventas PRIMARY KEY (IdVenta)
);
GO

-- 8. Tabla de Detalle de Ventas
CREATE TABLE VentasDetalle (
    IdDetalle VARCHAR(10) NOT NULL,
    IdVenta VARCHAR(10) NOT NULL,
    IdProducto VARCHAR(10) NOT NULL,
    Cantidad INT NOT NULL,
    PrecioVenta DECIMAL(10, 2) NOT NULL,
    Subtotal DECIMAL(10, 2) NOT NULL,
    CONSTRAINT PK_VentasDetalle PRIMARY KEY (IdDetalle)
);
GO

-- ========================================================
-- RESTRICCIONES DE LLAVES FORÁNEAS (RELACIONES)
-- ========================================================

ALTER TABLE Productos
ADD CONSTRAINT FK_Productos_Categorias 
FOREIGN KEY (IdCategoria) REFERENCES Categorias(IdCategoria);
GO

ALTER TABLE Productos
ADD CONSTRAINT FK_Productos_Marcas 
FOREIGN KEY (IdMarca) REFERENCES Marcas(IdMarca);
GO

ALTER TABLE Ventas
ADD CONSTRAINT FK_Ventas_Clientes 
FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente);
GO

ALTER TABLE Ventas
ADD CONSTRAINT FK_Ventas_MetodosPago 
FOREIGN KEY (IdMetodoPago) REFERENCES MetodosPago(IdMetodoPago);
GO

ALTER TABLE Ventas
ADD CONSTRAINT FK_Ventas_Usuarios 
FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario);
GO

ALTER TABLE VentasDetalle
ADD CONSTRAINT FK_VentasDetalle_Productos 
FOREIGN KEY (IdProducto) REFERENCES Productos(IdProducto);
GO

ALTER TABLE VentasDetalle
ADD CONSTRAINT FK_VentasDetalle_Ventas 
FOREIGN KEY (IdVenta) REFERENCES Ventas(IdVenta);
GO

-- ========================================================
-- DATOS INICIALES POR DEFECTO
-- ========================================================

-- Usuarios por defecto (Administrador y Vendedor)
INSERT INTO Usuarios (IdUsuario, NombreUsuario, Contraseña, Cargo, Estado, Fecha)
VALUES 
    ('U001', 'Administrador', '1234', 'Administrador', 'Activo', GETDATE()),
    ('U002', 'Vendedor', '1234', 'Vendedor', 'Activo', GETDATE());
GO

-- Categorías por defecto
INSERT INTO Categorias (IdCategoria, NombreCategoria, Fecha)
VALUES 
    ('CAT01', 'Jugos', GETDATE()),
    ('CAT02', 'Agua', GETDATE()),
    ('CAT03', 'Gaseosas', GETDATE()),
    ('CAT04', 'Cervezas', GETDATE());
GO

-- Marcas por defecto
INSERT INTO Marcas (IdMarca, NombreMarca)
VALUES 
    ('M01', 'Coca-Cola'),
    ('M02', 'Fuente Pura');
GO

-- Métodos de Pago
INSERT INTO MetodosPago (IdMetodoPago, NombreMetodo)
VALUES 
    ('MP01', 'Efectivo'),
    ('MP02', 'Tarjeta de Débito/Crédito');
GO

-- Clientes por defecto (Incluyendo el cliente genérico C0000 y 2 clientes adicionales)
INSERT INTO Clientes (IdCliente, NombreCliente, IdCedula, Telefono, Direccion, Fecha)
VALUES 
    ('C0000', 'Cliente Genérico', NULL, NULL, 'General', GETDATE()),
    ('C001', 'Juan Pérez', '001-100195-0001A', '8888-1111', 'Managua, 7 sur', GETDATE()),
    ('C002', 'María Gómez', '001-200398-0002B', '8888-2222', 'Managua, Bolonia', GETDATE());
GO

-- Productos por defecto (3 productos)
INSERT INTO Productos (IdProducto, IdMarca, IdCategoria, NombreProducto, PrecioUnidad, StockActual)
VALUES 
    ('P001', 'M01', 'CAT03', 'Coca-Cola 2 Litros', 45.00, 50),
    ('P002', 'M02', 'CAT02', 'Agua Pura 1 Litro', 20.00, 100),
    ('P003', 'M01', 'CAT01', 'Jugo en Caja 1L', 35.00, 40);
GO

-- Ventas de ejemplo (3 ventas)
INSERT INTO Ventas (IdVenta, IdCliente, FechaVenta, TotalVenta, IdMetodoPago, IdUsuario)
VALUES 
    ('V1001', 'C0000', GETDATE(), 90.00, 'MP01', 'U002'),
    ('V1002', 'C001', GETDATE(), 100.00, 'MP02', 'U002'),
    ('V1003', 'C002', GETDATE(), 35.00, 'MP01', 'U001');
GO

-- Detalles de las ventas de ejemplo
INSERT INTO VentasDetalle (IdDetalle, IdVenta, IdProducto, Cantidad, PrecioVenta, Subtotal)
VALUES 
    -- Venta 1 (Cliente Genérico compra 2 Coca-Colas)
    ('D1001_1', 'V1001', 'P001', 2, 45.00, 90.00),
    -- Venta 2 (Juan Pérez compra 1 Coca-Cola y 2 Aguas)
    ('D1002_1', 'V1002', 'P001', 1, 45.00, 45.00),
    ('D1002_2', 'V1002', 'P002', 2, 27.50, 55.00), -- (Ajustado o directo)
    -- Venta 3 (María Gómez compra 1 Jugo)
    ('D1003_1', 'V1003', 'P003', 1, 35.00, 35.00);
GO