DROP DATABASE IF EXISTS dbConsulta;

CREATE DATABASE dbConsulta;
USE dbConsulta;

DROP VIEW IF EXISTS vwDetalleCompras;
DROP VIEW IF EXISTS vwComprasPorProveedor;
DROP VIEW IF EXISTS vwComprasPorProducto;
DROP TABLE IF EXISTS tblCompra;
DROP TABLE IF EXISTS tblProducto;
DROP TABLE IF EXISTS tblProveedor;
DROP TABLE IF EXISTS tblConsulta;

-- =========================================================
-- TABLA PRINCIPAL DEL COMPONENTE CONSULTAS
-- =========================================================

CREATE TABLE tblConsulta (
    Pk_Consulta INT AUTO_INCREMENT,
    nombreConsulta VARCHAR(100) NOT NULL,
    tablaConsulta VARCHAR(255) NOT NULL,
    queryConsulta TEXT NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
        ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_Consulta PRIMARY KEY (Pk_Consulta),
    CONSTRAINT Uq_NombreConsulta UNIQUE (nombreConsulta)
);


-- =========================================================
-- TABLAS ERP DE PRUEBA
-- =========================================================


-- =========================================================
-- TABLA: PROVEEDORES
-- MODULO: COMPRAS Y CUENTAS POR PAGAR
-- 31 REGISTROS
-- =========================================================

CREATE TABLE tblProveedor (
    Pk_Proveedor INT AUTO_INCREMENT,
    nombreProveedor VARCHAR(150) NOT NULL,
    nitProveedor VARCHAR(20) NOT NULL,
    telefonoProveedor VARCHAR(20),
    correoProveedor VARCHAR(150),
    saldoProveedor DECIMAL(12,2) NOT NULL DEFAULT 0.00,
    estadoProveedor VARCHAR(20) NOT NULL DEFAULT 'Activo',

    CONSTRAINT Pk_Proveedor PRIMARY KEY (Pk_Proveedor),
    CONSTRAINT Uq_NitProveedor UNIQUE (nitProveedor)
);


INSERT INTO tblProveedor
(
    nombreProveedor,
    nitProveedor,
    telefonoProveedor,
    correoProveedor,
    saldoProveedor,
    estadoProveedor
)
VALUES
(
    'Carnes Selectas de Guatemala',
    '1000001-1',
    '2234-1001',
    'ventas@carnesselectas.com',
    18500.00,
    'Activo'
),
(
    'Empaques Industriales S.A.',
    '1000002-2',
    '2234-1002',
    'ventas@empaquesindustriales.com',
    12400.00,
    'Activo'
),
(
    'Condimentos del Pacifico',
    '1000003-3',
    '2234-1003',
    'ventas@condimentospacifico.com',
    8300.50,
    'Activo'
),
(
    'Distribuidora Central Guatemala',
    '1000004-4',
    '2234-1004',
    'ventas@distribuidoracentral.com',
    15200.00,
    'Activo'
),
(
    'Suministros Alimenticios del Norte',
    '1000005-5',
    '2234-1005',
    'ventas@suministrosnorte.com',
    9200.75,
    'Activo'
),
(
    'Productos Refrigerados Maya',
    '1000006-6',
    '2234-1006',
    'ventas@refrigeradosmaya.com',
    11400.00,
    'Activo'
),
(
    'Soluciones de Empaque Integral',
    '1000007-7',
    '2234-1007',
    'ventas@empaqueintegral.com',
    7300.00,
    'Activo'
),
(
    'Especias Centroamericanas',
    '1000008-8',
    '2234-1008',
    'ventas@especiasca.com',
    6100.00,
    'Activo'
),
(
    'Distribuciones La Hacienda',
    '1000009-9',
    '2234-1009',
    'ventas@lahacienda.com',
    17800.00,
    'Activo'
),
(
    'Materias Primas del Sur',
    '1000010-1',
    '2234-1010',
    'ventas@materiasprimasur.com',
    13300.00,
    'Activo'
),
(
    'Frigorificos Nacionales',
    '1000011-2',
    '2234-1011',
    'ventas@frigorificosnacionales.com',
    22500.00,
    'Activo'
),
(
    'Empaques Modernos',
    '1000012-3',
    '2234-1012',
    'ventas@empaquesmodernos.com',
    5800.00,
    'Activo'
),
(
    'Aditivos Alimentarios GT',
    '1000013-4',
    '2234-1013',
    'ventas@aditivosgt.com',
    7700.00,
    'Activo'
),
(
    'Comercializadora San Marcos',
    '1000014-5',
    '2234-1014',
    'ventas@comercialsanmarcos.com',
    9800.00,
    'Activo'
),
(
    'Proveedora Industrial Quetzal',
    '1000015-6',
    '2234-1015',
    'ventas@proveedoraquetzal.com',
    11900.00,
    'Activo'
),
(
    'Alimentos y Materias Primas S.A.',
    '1000016-7',
    '2234-1016',
    'ventas@alimentosymaterias.com',
    16400.00,
    'Activo'
),
(
    'Etiquetas Profesionales',
    '1000017-8',
    '2234-1017',
    'ventas@etiquetasprofesionales.com',
    4500.00,
    'Activo'
),
(
    'Distribuidora Los Altos',
    '1000018-9',
    '2234-1018',
    'ventas@distribuidoralosaltos.com',
    10300.00,
    'Activo'
),
(
    'Servicios Alimentarios Unidos',
    '1000019-1',
    '2234-1019',
    'ventas@serviciosalimentarios.com',
    7200.00,
    'Activo'
),
(
    'Insumos Industriales del Caribe',
    '1000020-2',
    '2234-1020',
    'ventas@insumoscaribe.com',
    8800.00,
    'Activo'
),
(
    'Productos Selectos Chapines',
    '1000021-3',
    '2234-1021',
    'ventas@selectoschapines.com',
    14100.00,
    'Activo'
),
(
    'Empacadora Nacional',
    '1000022-4',
    '2234-1022',
    'ventas@empacadoranacional.com',
    9600.00,
    'Activo'
),
(
    'Soluciones de Refrigeracion',
    '1000023-5',
    '2234-1023',
    'ventas@refrigeraciongt.com',
    12700.00,
    'Activo'
),
(
    'Distribuciones El Progreso',
    '1000024-6',
    '2234-1024',
    'ventas@distribucionesprogreso.com',
    6900.00,
    'Activo'
),
(
    'Comercializadora del Oriente',
    '1000025-7',
    '2234-1025',
    'ventas@comercialoriente.com',
    8200.00,
    'Activo'
),
(
    'Insumos de Calidad S.A.',
    '1000026-8',
    '2234-1026',
    'ventas@insumoscalidad.com',
    10900.00,
    'Activo'
),
(
    'Proveedores Integrales GT',
    '1000027-9',
    '2234-1027',
    'ventas@proveedoresintegrales.com',
    15400.00,
    'Activo'
),
(
    'Abastecimientos del Centro',
    '1000028-1',
    '2234-1028',
    'ventas@abastecimientoscentro.com',
    9100.00,
    'Activo'
),
(
    'Importadora Alimenticia Maya',
    '1000029-2',
    '2234-1029',
    'ventas@importadoramaya.com',
    13800.00,
    'Activo'
),
(
    'Distribuidora Valle Verde',
    '1000030-3',
    '2234-1030',
    'ventas@valleverde.com',
    7500.00,
    'Activo'
),
(
    'Suministros Profesionales GT',
    '1000031-4',
    '2234-1031',
    'ventas@suministrosgt.com',
    0.00,
    'Inactivo'
);


-- =========================================================
-- TABLA: PRODUCTOS
-- MODULO: LOGISTICA / INVENTARIOS
-- 31 REGISTROS
-- =========================================================

CREATE TABLE tblProducto (
    Pk_Producto INT AUTO_INCREMENT,
    nombreProducto VARCHAR(150) NOT NULL,
    marcaProducto VARCHAR(100) NOT NULL,
    categoriaProducto VARCHAR(100) NOT NULL,
    precioCompra DECIMAL(10,2) NOT NULL,
    existenciaProducto INT NOT NULL DEFAULT 0,
    estadoProducto VARCHAR(20) NOT NULL DEFAULT 'Activo',

    CONSTRAINT Pk_Producto PRIMARY KEY (Pk_Producto)
);


INSERT INTO tblProducto
(
    nombreProducto,
    marcaProducto,
    categoriaProducto,
    precioCompra,
    existenciaProducto,
    estadoProducto
)
VALUES
(
    'Carne de Cerdo',
    'Selecta',
    'Materia Prima',
    24.50,
    850,
    'Activo'
),
(
    'Carne de Res',
    'Selecta',
    'Materia Prima',
    32.75,
    620,
    'Activo'
),
(
    'Carne de Pollo',
    'Selecta',
    'Materia Prima',
    18.90,
    740,
    'Activo'
),
(
    'Grasa de Cerdo',
    'Selecta',
    'Materia Prima',
    14.25,
    420,
    'Activo'
),
(
    'Sal Refinada',
    'Del Pacifico',
    'Condimentos',
    4.25,
    300,
    'Activo'
),
(
    'Pimienta Negra',
    'Del Pacifico',
    'Condimentos',
    18.90,
    120,
    'Activo'
),
(
    'Ajo en Polvo',
    'Del Pacifico',
    'Condimentos',
    15.75,
    95,
    'Activo'
),
(
    'Cebolla en Polvo',
    'Del Pacifico',
    'Condimentos',
    13.50,
    110,
    'Activo'
),
(
    'Paprika',
    'Del Pacifico',
    'Condimentos',
    17.60,
    85,
    'Activo'
),
(
    'Comino Molido',
    'Del Pacifico',
    'Condimentos',
    12.80,
    100,
    'Activo'
),
(
    'Empaque al Vacio 250g',
    'PackPro',
    'Empaque',
    1.45,
    2800,
    'Activo'
),
(
    'Empaque al Vacio 500g',
    'PackPro',
    'Empaque',
    1.85,
    2500,
    'Activo'
),
(
    'Empaque al Vacio 1kg',
    'PackPro',
    'Empaque',
    2.30,
    1800,
    'Activo'
),
(
    'Bolsa Termoencogible Pequena',
    'PackPro',
    'Empaque',
    1.20,
    3200,
    'Activo'
),
(
    'Bolsa Termoencogible Grande',
    'PackPro',
    'Empaque',
    1.75,
    2100,
    'Activo'
),
(
    'Etiqueta Producto Premium',
    'LabelGT',
    'Etiquetado',
    0.45,
    5000,
    'Activo'
),
(
    'Etiqueta Producto Clasico',
    'LabelGT',
    'Etiquetado',
    0.40,
    4800,
    'Activo'
),
(
    'Etiqueta Codigo de Barras',
    'LabelGT',
    'Etiquetado',
    0.25,
    6000,
    'Activo'
),
(
    'Caja Corrugada Pequena',
    'Empaque Nacional',
    'Embalaje',
    4.50,
    650,
    'Activo'
),
(
    'Caja Corrugada Mediana',
    'Empaque Nacional',
    'Embalaje',
    5.75,
    500,
    'Activo'
),
(
    'Caja Corrugada Grande',
    'Empaque Nacional',
    'Embalaje',
    7.20,
    350,
    'Activo'
),
(
    'Hielo Industrial',
    'FrioGT',
    'Refrigeracion',
    2.40,
    700,
    'Activo'
),
(
    'Gel Refrigerante',
    'FrioGT',
    'Refrigeracion',
    3.80,
    420,
    'Activo'
),
(
    'Tripas Sinteticas 20mm',
    'EmbutiPack',
    'Produccion',
    8.25,
    800,
    'Activo'
),
(
    'Tripas Sinteticas 30mm',
    'EmbutiPack',
    'Produccion',
    9.40,
    650,
    'Activo'
),
(
    'Tripas Naturales',
    'EmbutiPack',
    'Produccion',
    14.50,
    340,
    'Activo'
),
(
    'Conservante Alimentario',
    'FoodSafe',
    'Aditivos',
    22.80,
    90,
    'Activo'
),
(
    'Antioxidante Alimentario',
    'FoodSafe',
    'Aditivos',
    25.40,
    75,
    'Activo'
),
(
    'Colorante Natural Rojo',
    'FoodSafe',
    'Aditivos',
    19.90,
    68,
    'Activo'
),
(
    'Fosfato Alimentario',
    'FoodSafe',
    'Aditivos',
    21.75,
    80,
    'Activo'
),
(
    'Mezcla Especial Embutidos',
    'FoodSafe',
    'Aditivos',
    28.90,
    0,
    'Inactivo'
);


-- =========================================================
-- TABLA: COMPRAS
-- MODULO: COMPRAS Y CUENTAS POR PAGAR
-- 31 REGISTROS
-- =========================================================

CREATE TABLE tblCompra (
    Pk_Compra INT AUTO_INCREMENT,
    Fk_Proveedor INT NOT NULL,
    Fk_Producto INT NOT NULL,
    fechaCompra DATE NOT NULL,
    cantidadCompra INT NOT NULL,
    precioUnitario DECIMAL(10,2) NOT NULL,
    estadoCompra VARCHAR(30) NOT NULL,
    fechaVencimiento DATE,

    CONSTRAINT Pk_Compra PRIMARY KEY (Pk_Compra),

    CONSTRAINT Fk_CompraProveedor
        FOREIGN KEY (Fk_Proveedor)
        REFERENCES tblProveedor (Pk_Proveedor),

    CONSTRAINT Fk_CompraProducto
        FOREIGN KEY (Fk_Producto)
        REFERENCES tblProducto (Pk_Producto)
);


INSERT INTO tblCompra
(
    Fk_Proveedor,
    Fk_Producto,
    fechaCompra,
    cantidadCompra,
    precioUnitario,
    estadoCompra,
    fechaVencimiento
)
VALUES
(1, 1, '2026-07-01', 300, 24.50, 'Pagada', '2026-07-31'),
(2, 2, '2026-07-03', 200, 32.75, 'Pagada', '2026-08-02'),
(3, 3, '2026-07-05', 250, 18.90, 'Pagada', '2026-08-04'),
(4, 4, '2026-07-07', 180, 14.25, 'Pagada', '2026-08-06'),
(5, 5, '2026-07-09', 150, 4.25, 'Pagada', '2026-08-08'),
(6, 6, '2026-07-11', 50, 18.90, 'Pagada', '2026-08-10'),
(7, 7, '2026-07-13', 40, 15.75, 'Pagada', '2026-08-12'),
(8, 8, '2026-07-15', 60, 13.50, 'Pagada', '2026-08-14'),
(9, 9, '2026-07-17', 55, 17.60, 'Pagada', '2026-08-16'),
(10, 10, '2026-07-19', 65, 12.80, 'Pagada', '2026-08-18'),

(11, 11, '2026-08-01', 1200, 1.45, 'Pagada', '2026-08-31'),
(12, 12, '2026-08-03', 1000, 1.85, 'Pagada', '2026-09-02'),
(13, 13, '2026-08-05', 800, 2.30, 'Pagada', '2026-09-04'),
(14, 14, '2026-08-07', 900, 1.20, 'Pagada', '2026-09-06'),
(15, 15, '2026-08-09', 750, 1.75, 'Pendiente', '2026-09-08'),
(16, 16, '2026-08-11', 2000, 0.45, 'Pendiente', '2026-09-10'),
(17, 17, '2026-08-13', 1800, 0.40, 'Pendiente', '2026-09-12'),
(18, 18, '2026-08-15', 2500, 0.25, 'Pendiente', '2026-09-14'),
(19, 19, '2026-08-17', 300, 4.50, 'Pagada', '2026-09-16'),
(20, 20, '2026-08-19', 250, 5.75, 'Pagada', '2026-09-18'),

(21, 21, '2026-09-01', 200, 7.20, 'Pendiente', '2026-10-01'),
(22, 22, '2026-09-02', 500, 2.40, 'Pendiente', '2026-10-02'),
(23, 23, '2026-09-03', 300, 3.80, 'Pendiente', '2026-10-03'),
(24, 24, '2026-09-04', 400, 8.25, 'Pendiente', '2026-10-04'),
(25, 25, '2026-09-05', 350, 9.40, 'Pendiente', '2026-10-05'),
(26, 26, '2026-09-06', 180, 14.50, 'Pendiente', '2026-10-06'),
(27, 27, '2026-09-07', 60, 22.80, 'Pendiente', '2026-10-07'),
(28, 28, '2026-09-08', 55, 25.40, 'Pendiente', '2026-10-08'),
(29, 29, '2026-09-09', 45, 19.90, 'Pendiente', '2026-10-09'),
(30, 30, '2026-09-10', 50, 21.75, 'Pendiente', '2026-10-10'),
(31, 31, '2026-09-11', 40, 28.90, 'Cancelada', '2026-10-11');


-- =========================================================
-- VISTAS
-- =========================================================


-- =========================================================
-- VISTA 1
-- DETALLE COMPLETO DE COMPRAS
-- UTILIZA LAS 3 TABLAS
-- =========================================================

CREATE VIEW vwDetalleCompras AS
SELECT
    C.Pk_Compra AS IdCompra,
    C.fechaCompra AS FechaCompra,

    P.Pk_Proveedor AS IdProveedor,
    P.nombreProveedor AS Proveedor,
    P.nitProveedor AS NitProveedor,

    PR.Pk_Producto AS IdProducto,
    PR.nombreProducto AS Producto,
    PR.marcaProducto AS Marca,
    PR.categoriaProducto AS Categoria,

    C.cantidadCompra AS Cantidad,
    C.precioUnitario AS PrecioUnitario,

    (
        C.cantidadCompra * C.precioUnitario
    ) AS TotalCompra,

    C.estadoCompra AS EstadoCompra,
    C.fechaVencimiento AS FechaVencimiento

FROM tblCompra AS C

INNER JOIN tblProveedor AS P
    ON C.Fk_Proveedor = P.Pk_Proveedor

INNER JOIN tblProducto AS PR
    ON C.Fk_Producto = PR.Pk_Producto;


-- =========================================================
-- VISTA 2
-- COMPRAS POR PROVEEDOR
-- =========================================================

CREATE VIEW vwComprasPorProveedor AS
SELECT
    P.Pk_Proveedor AS IdProveedor,
    P.nombreProveedor AS Proveedor,
    P.nitProveedor AS Nit,

    COUNT(C.Pk_Compra) AS CantidadCompras,

    SUM(C.cantidadCompra) AS UnidadesCompradas,

    SUM(
        C.cantidadCompra * C.precioUnitario
    ) AS TotalComprado,

    P.saldoProveedor AS SaldoProveedor,
    P.estadoProveedor AS EstadoProveedor

FROM tblProveedor AS P

LEFT JOIN tblCompra AS C
    ON P.Pk_Proveedor = C.Fk_Proveedor

GROUP BY
    P.Pk_Proveedor,
    P.nombreProveedor,
    P.nitProveedor,
    P.saldoProveedor,
    P.estadoProveedor;


-- =========================================================
-- VISTA 3
-- COMPRAS POR PRODUCTO
-- =========================================================

CREATE VIEW vwComprasPorProducto AS
SELECT
    PR.Pk_Producto AS IdProducto,
    PR.nombreProducto AS Producto,
    PR.marcaProducto AS Marca,
    PR.categoriaProducto AS Categoria,

    COUNT(C.Pk_Compra) AS CantidadCompras,

    SUM(C.cantidadCompra) AS TotalUnidadesCompradas,

    AVG(C.precioUnitario) AS PrecioPromedioCompra,

    SUM(
        C.cantidadCompra * C.precioUnitario
    ) AS TotalInvertido,

    PR.existenciaProducto AS ExistenciaActual,
    PR.estadoProducto AS EstadoProducto

FROM tblProducto AS PR

LEFT JOIN tblCompra AS C
    ON PR.Pk_Producto = C.Fk_Producto

GROUP BY
    PR.Pk_Producto,
    PR.nombreProducto,
    PR.marcaProducto,
    PR.categoriaProducto,
    PR.existenciaProducto,
    PR.estadoProducto;


-- =========================================================
-- REGISTROS PARA tblConsulta
-- =========================================================

INSERT INTO tblConsulta
(
    nombreConsulta,
    tablaConsulta,
    queryConsulta
)
VALUES
(
    'Listar todas las consultas',
    'tblConsulta',
    'SELECT * FROM tblConsulta;'
),
(
    'Listar proveedores',
    'tblProveedor',
    'SELECT * FROM tblProveedor;'
),
(
    'Listar productos',
    'tblProducto',
    'SELECT * FROM tblProducto;'
),
(
    'Listar compras',
    'tblCompra',
    'SELECT * FROM tblCompra;'
),
(
    'Proveedores activos',
    'tblProveedor',
    'SELECT * FROM tblProveedor WHERE estadoProveedor = ''Activo'';'
),
(
    'Productos activos',
    'tblProducto',
    'SELECT * FROM tblProducto WHERE estadoProducto = ''Activo'';'
),
(
    'Compras pendientes',
    'tblCompra',
    'SELECT * FROM tblCompra WHERE estadoCompra = ''Pendiente'';'
),
(
    'Compras pagadas',
    'tblCompra',
    'SELECT * FROM tblCompra WHERE estadoCompra = ''Pagada'';'
),
(
    'Productos por existencia',
    'tblProducto',
    'SELECT * FROM tblProducto ORDER BY existenciaProducto DESC;'
),
(
    'Proveedores por saldo',
    'tblProveedor',
    'SELECT * FROM tblProveedor ORDER BY saldoProveedor DESC;'
),
(
    'Detalle general de compras',
    'vwDetalleCompras',
    'SELECT * FROM vwDetalleCompras;'
),
(
    'Compras pendientes detalladas',
    'vwDetalleCompras',
    'SELECT * FROM vwDetalleCompras WHERE EstadoCompra = ''Pendiente'';'
),
(
    'Compras de materia prima',
    'vwDetalleCompras',
    'SELECT * FROM vwDetalleCompras WHERE Categoria = ''Materia Prima'';'
),
(
    'Compras mayores a cinco mil',
    'vwDetalleCompras',
    'SELECT * FROM vwDetalleCompras WHERE TotalCompra > 5000;'
),
(
    'Compras ordenadas por total',
    'vwDetalleCompras',
    'SELECT * FROM vwDetalleCompras ORDER BY TotalCompra DESC;'
),
(
    'Resumen por proveedor',
    'vwComprasPorProveedor',
    'SELECT * FROM vwComprasPorProveedor;'
),
(
    'Proveedores por total comprado',
    'vwComprasPorProveedor',
    'SELECT * FROM vwComprasPorProveedor ORDER BY TotalComprado DESC;'
),
(
    'Resumen por producto',
    'vwComprasPorProducto',
    'SELECT * FROM vwComprasPorProducto;'
),
(
    'Productos por unidades compradas',
    'vwComprasPorProducto',
    'SELECT * FROM vwComprasPorProducto ORDER BY TotalUnidadesCompradas DESC;'
),
(
    'Productos con existencia baja',
    'tblProducto',
    'SELECT * FROM tblProducto WHERE existenciaProducto < 100;'
);


-- =========================================================
-- VALIDACION DE CANTIDAD DE REGISTROS
-- =========================================================

SELECT
    COUNT(*) AS TotalProveedores
FROM tblProveedor;


SELECT
    COUNT(*) AS TotalProductos
FROM tblProducto;


SELECT
    COUNT(*) AS TotalCompras
FROM tblCompra;


-- =========================================================
-- PRUEBAS DE LAS VISTAS
-- =========================================================

SELECT *
FROM vwDetalleCompras;


SELECT *
FROM vwComprasPorProveedor;


SELECT *
FROM vwComprasPorProducto;
