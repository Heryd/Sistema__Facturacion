CREATE TABLE DETALLE_FACTURA(
	ID_DETALLE_FACTURA INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ID_FACTURA INT NOT NULL,
	ID_SERVICIO INT NOT NULL,
	NOMBRE_ENCARGADO VARCHAR(80) NOT NULL,
	CANTIDAD INT DEFAULT 1 NOT NULL,
	TOTAL_PAGAR FLOAT
);