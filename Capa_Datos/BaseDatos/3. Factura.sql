USE GS_FACT_03;
GO

--CREACION DE LA TABLA
CREATE TABLE FACTURA(
    ID_FACTURA INT,
    ID_EMPRESA INT,
    ID_CLIENTE INT,
    FECHA_FACTURACION DATE,
    ID_PAGO INT
);
