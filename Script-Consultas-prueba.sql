CREATE DATABASE empresa1 --Cambiar nombre de base de datos
GO

USE empresa1 -- usar la base de datos
GO
--Creacion de tablas
CREATE TABLE departamento
(
   codigo_departamento INT PRIMARY KEY,
   nombre_depto VARCHAR(75),
   presupuesto DECIMAL
);

CREATE TABLE empleado
(
   dpi INT PRIMARY KEY,
   nombre VARCHAR(100),
   apellidos VARCHAR(125),
   cod_depto INT,
   FOREIGN KEY (cod_depto) REFERENCES departamento(codigo_departamento)
);

-- =======================
-- INSERT DE DEPARTAMENTOS
-- =======================
INSERT INTO departamento(codigo_departamento,nombre_depto,presupuesto) VALUES
(1,'Gerencia',55000),
(2,'Administración y Finanzas',118000),
(3,'Contabilidad',63550),
(4,'RRHH',45000),
(5,'Proyectos',1305000),
(6,'Comercial',354647),
(7,'Mercadeo',556000),
(8,'Producción',13500300),
(9,'Logística',5905400),
(10,'Bodega',2566500),
(12,'Inteligencia',65000),
(14,'Informática',157000),
(77,'Investigación',157000);

-- =======================
-- INSERT DE EMPLEADOS
-- =======================
INSERT INTO empleado (dpi,nombre,apellidos,cod_depto) VALUES
(16967,'AARON ISAAC','PAR GUITZ',3),
(15251,'ADELFA VERONICA','PEREZ LOPEZ',5),
(13621,'ADELIO','PEREZ Y PEREZ',9),
(15752,'ADELSO','ZUÑIGA REGALADO',1),
(18228,'ADELY NATYNELLY','MARGOTTIUL CU',10),
(25757,'BECERA SUZZETH','OVALLE ROLDAN',7),
(22011,'BEIMER DANILO','PEREZ BAUTISTA',2),
(13382,'BELBETH YESENIA','HERNANDEZ GONZALEZ',4),
(10569,'BELGICA ANABELLA','DERAS ROMAN',77),
(18600,'BELICA ANABELA','MIRANDA MONZON',6),
(21163,'BELLANIRA DANALY','MEDRANO MORALES',12),
(13837,'BELMIN PINEDA','GONZALEZ',1),
(24367,'BELSY KORINA','ALVARADO HERNANDEZ',5),
(20561,'BELSY LORENA','DE LEON GODINEZ',8),
(17449,'BELSY YUCELA','SOLANO CRUZ',3),
(19107,'CARMEN LUCIA','ACU RECINOS',5),
(20940,'CARMEN LUCIA','NAJARRO RUANO',9),
(24517,'CARMEN MARIA','AREVALO HERNANDEZ',10),
(20784,'DAVID JOSUE','LOPHES GUZMAN',7),
(20523,'DAVID LIONEL','PIVARAL ALBUREZ',14),
(22891,'DAVID MOISES','ELIAS AGUILAR',4),
(13332,'DAVID OSWALDO','QUIYUCH TOCAY',7),
(24434,'DAVID RIGOBERTO','VILLEDA SANCHEZ',6),
(24815,'DAVID URBANO','PIVARAL GONZALEZ',6),
(13071,'DAVID YURAMBIR','RIVERA ALVARADO',5),
(15277,'DAYRIN LIZMENIA','TEO SALGUERO',1),
(16052,'DAYRIN ROCIO','MEJIA',8),
(22073,'DEBBIE DEL CARMEN','SOLOMAN ORTIZ',1),
(20252,'DEBORA CELESTE','CHAN GUERRA',3),
(16199,'DEBORA GREACE','AVILA CHACON',5),
(20391,'DEBORA GUISELA','MEJICANOS',10),
(26053,'DEBORA MARIE','ESTHERPALACIOS VALDEZ',7),
(19291,'DEBORA MISHELL','CIFUENTES ESCOBAR',14),
(20418,'DEBORA RAQUEL','JUAREZ FUENTES',4),
(23647,'DEBORA RENEE','RODRIGUEZ RECINOS',1),
(21707,'DEBORAH VIOLETA','SIERRA LOPEZ',77),
(22661,'DEBRACK INDIRA','LOYO BRAN',6),
(21112,'DEBRAH ESTHER','LOBOS TOLEDO',12),
(16194,'DEGLY LEONEL','RODERICOMORALES NOGUERA',5),
(24546,'DEICY MARILIS','PINEDA REVOLORIO',8),
(25551,'DEISY VANESSA','FRANCO CERNA',3),
(21957,'DELBERT URIEL','DOMINGUEZ MARTINEZ',14),
(11518,'DELCY NOHEMI','SALGUERO ESQUIVEL',9),
(24823,'DELINFA JEANNETTE','GARCIA MORALES',10),
(10882,'DELHI YOHANA','OROZCO JUAREZ',7),
(20930,'EDGAR ROLANDO','LOPEZ TOJES',2),
(20112,'EDGAR ROLANDO','ORTIZ GONZALEZ',4),
(10755,'EVER LIBERATO','MARTINEZ BARRIOS',14),
(22595,'EVER MANOLO','MORALES LOPEZ',6),
(15628,'EZVIN OSWALDO','GUERRA GALVEZ',12),
(19969,'EZZIO GIANCARLO','GUILLEN AYAU',1),
(12360,'FABIAN ALBERTO','RAMOS BARAHONA',8),
(24618,'FABIAN ALFONSO','GARCIA ALVARADO',14),
(13176,'FABIAN','DE LEON PEREZ',9),
(11267,'FABIAN HERIBERTO','MOLINA SOSA',2),
(18302,'FABIOLA CORINA','MANZANERO GARCIA',3),
(14055,'FRANCISCO RAUL','ALVARADO CHAVEZ',5),
(20627,'FRANCISCO RAYMUNDO','UJPAN VASQUEZ',3),
(17606,'FRANZ ROBERTO','POLANCO MEJIA',9),
(22183,'FRED ERICK','RENEGARCIA GARCIA',10),
(16423,'FREDY ESTUARDO','OGALDEZ FERNANDEZ',7),
(20963,'GABRIELA SOFIA','PORTILLO LOPEZ',2),
(23517,'GARDENIA ENEDINA','MAZA CASTELLANOS',4),
(14693,'GARY ALEXANDER','CONTRERAS NAJERA',3),
(21712,'GILMAR ALEXANDER','CUC GUERRERO',7),
(19855,'GREYS MARIANA','PINTO',6),
(11583,'GUSTAVO ADOLFO','TABIN GRAMAJO',12),
(18303,'HENRY ERNESTO','RODRIGUEZ VILLALTA',8),
(12871,'HENRY ESTEBAN','SOSOF RAMIREZ',3),
(19484,'INGRID YESENIA','CHAVARRIA MORAN',5),
(18005,'INGRID YESENIA','LOPEZ GALVEZ',3),
(24270,'JUAN CARLOS','AMARRA ROBLES',9),
(17193,'KARLA MARIELA','DE LEON LOPEZ',10),
(16970,'KARLA OLIVIA','IXMUCANEALVA ARROYO',7),
(21454,'LIDIA ELIZABETH','SOLARES',2),
(17668,'LIDIA ENCARNACION','COY MACZ',4),
(12816,'OCTAVIO','CHEGUEN GONZALEZ',1),
(15802,'ROSA ODILIA','NAVASSI DIAZ',77),
(23204,'ROSALICIA','GUZMAN ALDANA',6),
(25659,'SANDRA IVONNE','MARTINEZ AGUILAR',12),
(16407,'SANDRA LISSETTE','MORALES RAMIREZ',8),
(22263 ,'TERESA DE JESUS','GONZALEZ TELON',3),
(15112 ,'TERESA DE JESUS','VASQUEZ VILLATORO',3),
(13365 ,'WENDY LISBETH','MARROQUIN CASTILLO',5),
(11725 ,'WILFIDO','PANTALEON PACHECO',9),
(16177 ,'WILFREDO','ALDANA ARCHILA',10),
(19261 ,'YESIKA MANUELA','MACARIO TAQUIEJ',7),
(21731 ,'ZULMY RAQUEL','GARCIA CISNEROS',2),
(20275 ,'ZULY GABRIELA','ALVARADO BARRIOS',4),
(13729 ,'ZULY MAYTE','SANDOVAL SANDOVAL',77);

/********************************************************
  5) CONSULTAS (1 a 18)
********************************************************/

-- 1) Todos los apellidos de los empleados
SELECT apellidos FROM empleado

-- 2) Apellidos sin repeticiones
SELECT DISTINCT apellidos FROM empleado

-- 3) Empleados que se apellidan "Pérez"
SELECT *
FROM empleado
WHERE apellidos  LIKE '%PEREZ%'

-- 4) Empleados que se apellidan "Pérez" o "López"
SELECT *
FROM empleado
WHERE apellidos  LIKE '%PEREZ%'
   OR apellidos  LIKE '%LOPEZ%'

-- 5) Empleados del departamento "Contabilidad"
SELECT e.*
FROM empleado e
JOIN departamento d ON d.codigo_departamento = e.cod_depto
WHERE d.nombre_depto = N'Contabilidad'

-- 6) Empleados en "Contabilidad" y "Gerencia General"/"Gerencia"
SELECT e.*
FROM empleado e
JOIN departamento d ON d.codigo_departamento = e.cod_depto
WHERE d.nombre_depto IN (N'Contabilidad', N'Gerencia', N'Gerencia General')

-- 7) Empleados cuyo apellido comienza con "P"
SELECT *
FROM empleado
WHERE apellidos  LIKE 'P%'



-- 8) Presupuesto total de todos los departamentos
SELECT SUM(presupuesto) AS presupuesto_total
FROM departamento

-- 9) Número de empleados por departamento (incluye deptos sin empleados)
SELECT d.codigo_departamento,
       d.nombre_depto,
       COUNT(e.dpi) AS cantidad_empleados
FROM departamento d
LEFT JOIN empleado e ON e.cod_depto = d.codigo_departamento
GROUP BY d.codigo_departamento, d.nombre_depto
ORDER BY d.codigo_departamento

-- 10) Empleados con datos de su departamento (JOIN)
SELECT e.dpi, e.nombre, e.apellidos,
       d.codigo_departamento, d.nombre_depto, d.presupuesto
FROM empleado e
JOIN departamento d ON d.codigo_departamento = e.cod_depto

-- 11) Empleados (nombre y apellido) + nombre y presupuesto de su depto, orden por apellido DESC
SELECT e.nombre, e.apellidos,
       d.nombre_depto, d.presupuesto
FROM empleado e
JOIN departamento d ON d.codigo_departamento = e.cod_depto
ORDER BY e.apellidos DESC

-- 12) Nombres y apellidos de empleados con deptos de presupuesto >= 60,000
SELECT e.nombre, e.apellidos
FROM empleado e
JOIN departamento d ON d.codigo_departamento = e.cod_depto
WHERE d.presupuesto >= 60000

-- 13) Departamentos con presupuesto superior al promedio
SELECT *
FROM departamento
WHERE presupuesto > (SELECT AVG(presupuesto) FROM departamento)

-- 14) Nombres de los departamentos con más de 2 empleados
SELECT d.nombre_depto, COUNT(*) AS cantidad_empleados
FROM empleado e
JOIN departamento d ON d.codigo_departamento = e.cod_depto
GROUP BY d.nombre_depto
HAVING COUNT(*) > 2

-- 15) Agregar "Control de Calidad" (código 11, Q40,000) y empleada Esther Vásquez (DNI 28948238)
INSERT INTO departamento (codigo_departamento, nombre_depto, presupuesto)
VALUES (11, N'Control de Calidad', 40000)

INSERT INTO empleado (dpi, nombre, apellidos, cod_depto)
VALUES (28948238, N'ESTHER', N'VASQUEZ', 11)

-- 16) Las Estrategias para optimizar una consulta lenta en MySQL (comentado)
-- * Crear índices en columnas usadas en WHERE/JOIN/ORDER BY.
-- * Evitar SELECT * (proyectar solo lo necesario).
-- * Usar EXPLAIN para detectar full scans y reescribir consultas.
-- * Usar índices de cobertura, partición de tablas y actualización de estadísticas.
-- * Cachear resultados frecuentes y revisar cuellos de botella de I/O.

-- 17) Diferencia entre transacción y bloqueo (comentado)
-- * Transacción: unidad atómica ACID (COMMIT/ROLLBACK).
-- * Bloqueo: mecanismo de concurrencia que protege recursos mientras se ejecuta la transacción.

-- 18) Top 3 empleados mejor pagados (sin LIMIT)
-- NOTA: se necesita una columna salario. Dejo dos alternativas:
-- A) Si ya existe empleado.salario:
--    SELECT TOP (3) * FROM empleado ORDER BY salario DESC;
-- B) Con ROW_NUMBER() (también requiere salario):
--    WITH r AS (
--      SELECT e.*, ROW_NUMBER() OVER (ORDER BY salario DESC) AS rn
--      FROM empleado e
--    )
--    SELECT * FROM r WHERE rn <= 3;


/********************************************************
  5) BLOQUE OPCIONAL PARA PROBAR #18 (AGREGA SALARIOS DEMO)
     -- Ejecútalo sólo si se requiere probar
********************************************************/
--ALTER TABLE empleado ADD salario DECIMAL(12,2) NULL;
--UPDATE empleado
--SET salario = ABS(CHECKSUM(NEWID())) % 9000 + 3000;  -- sueldos aleatorios 3,000–11,999

--SELECT TOP(3) dpi, nombre, apellidos, salario
--FROM empleado
--ORDER BY salario DESC;