----------------------------------------------CREACION DE LA BD----------------------------------------------
CREATE DATABASE GS_FACT_03;

----------------------------------------------CREACION DE LAS TABLAS----------------------------------------------
USE GS_FACT_03;
GO

--TABLA USUARIO
GO
CREATE TABLE TB_SEGU_USER(
	ID_USER INT IDENTITY PRIMARY KEY,
	USERNAME VARCHAR(80) NOT NULL,
	CLAVE VARBINARY(128) NOT NULL,
	ID_ROL INT NOT NULL,
	NOMBRE_USER VARCHAR(80) NOT NULL,
	TELEFONO_CONTACTO VARCHAR(20),
	DIRECCION_CONTACTO VARCHAR(80),
	MAIL_CONTACTO VARCHAR(50),
	ESTADO CHAR DEFAULT 'A'
);

--TABLA ROL

CREATE TABLE TB_SEGU_ROL(
ID_ROL INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE_ROL VARCHAR(80) NOT NULL,
ESTADO CHAR DEFAULT 'A'
);



--Tabla Cliente
CREATE TABLE CLIENTE(
    ID_CLIENTE INT IDENTITY(1,1) NOT NULL,
    NOMBRES VARCHAR(30) NOT NULL,
    APELLIDOS VARCHAR(30) NOT NULL,
    CEDULA NUMERIC(10) NOT NULL,
    CORREO VARCHAR(45) NOT NULL,
    DIRECCION VARCHAR(40) NOT NULL,
    TELEFONO  NUMERIC(10) NOT NULL,
    GENERO VARCHAR(20) NOT NULL,
    ESTADO VARCHAR(10) DEFAULT 'ACTIVO' NOT NULL,
    FECHA_REGISTRO DATE NOT NULL
);

--Tabla Pago
CREATE TABLE PAGO(
	ID_PAGO INT IDENTITY(1,1),
	FECHA_PAGO DATE NOT NULL,
	METODO_PAGO VARCHAR(30) NOT NULL,
	EFECTIVO FLOAT NOT NULL,
	ID_CLIENTE INT,
 ESTADO VARCHAR (20) DEFAULT 'PENDIENTE' NOT NULL
);

--Tabla Factura (Cabeza)
CREATE TABLE FACTURA(
	     ID_FACTURA int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	     ID_EMPRESA int DEFAULT 1 NOT NULL,
	     ID_CLIENTE int NOT NULL,
	     FECHA_FACTURACION date NOT NULL,
	     ESTADO varchar(30) DEFAULT 'PAGADO' NOT NULL
);

--Tabla DetalleFactura (Cuerpo)
CREATE TABLE DETALLE_FACTURA(
	ID_DETALLE_FACTURA INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ID_FACTURA INT NOT NULL,
	ID_SERVICIO INT NOT NULL,
	NOMBRE_ENCARGADO VARCHAR(80) NOT NULL,
	CANTIDAD INT DEFAULT 1 NOT NULL,
	TOTAL_PAGAR FLOAT
);

--Tabla Reembolso
CREATE TABLE REEMBOLSO(
	ID_REEMBOLSO INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ID_FACTURA INT NOT NULL,
	ID_SERVICIO INT NOT NULL,
	MOTIVO_REEMBOLSO VARCHAR(180) DEFAULT 'NO ESPECIFICADO',
	FECHA DATE NOT NULL
);

--Tabla Empresa
CREATE TABLE EMPRESA(
    ID_EMPRESA INT IDENTITY(1,1),
    NOMBRE VARCHAR(20) DEFAULT 'AC. REDES',
    DESCRIPCION_EMPRESA VARCHAR (180) DEFAULT 'EMPRESA DESTINADA A GESTIONAR SISTEMAS DE FACTURACION PARA TU NEGOCIO'
);

--Tabla Servicio (Parte del Cuerpo de la Factura)
CREATE TABLE SERVICIO(
	ID_SERVICIO INT IDENTITY (1,1)PRIMARY KEY NOT NULL,
	DESCRIPCION_SERVICIO VARCHAR(180) DEFAULT 'SIN ESPECIFICAR',
	VALOR_UNITARIO FLOAT
);


----------------------------------------------PRIMARY KEY AND RESTRICTIONS----------------------------------------------
ALTER TABLE CLIENTE  ADD CONSTRAINT ID_CLIENTE_PK  PRIMARY KEY (ID_CLIENTE);
ALTER TABLE PAGO ADD CONSTRAINT ID_PAGO_PK PRIMARY KEY(ID_PAGO);
ALTER TABLE FACTURA ADD CONSTRAINT ID_FACT PRIMARY KEY(ID_FACTURA);
ALTER TABLE DETALLE_FACTURA ADD CONSTRAINT idDetFact_PK PRIMARY KEY (ID_DETALLE_FACTURA);
ALTER TABLE REEMBOLSO ADD CONSTRAINT idRem_PK PRIMARY KEY(ID_REEMBOLSO);
ALTER TABLE EMPRESA ADD CONSTRAINT idEmpresa_PK PRIMARY KEY(ID_EMPRESA);
ALTER TABLE SERVICIO ADD CONSTRAINT ID_SERVICIO_PK PRIMARY KEY (ID_SERVICIO);


----------------------------------------------FOREIGN KEY AND RESTRICTIONS----------------------------------------------
ALTER TABLE PAGO ADD CONSTRAINT FK_ID_CLIENTE foreign key (ID_CLIENTE) REFERENCES CLIENTE(ID_CLIENTE) ON DELETE CASCADE;
ALTER TABLE FACTURA ADD CONSTRAINT FK_idEmpresa FOREIGN KEY (ID_EMPRESA) REFERENCES EMPRESA(ID_EMPRESA) ON DELETE CASCADE;
ALTER TABLE FACTURA ADD CONSTRAINT FK_idCliente FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTE(ID_CLIENTE) ON DELETE CASCADE;
ALTER TABLE DETALLE_FACTURA ADD CONSTRAINT FK_idFact FOREIGN KEY (ID_FACTURA) REFERENCES FACTURA(ID_FACTURA) ON DELETE CASCADE;
ALTER TABLE DETALLE_FACTURA ADD CONSTRAINT FK_idServ FOREIGN KEY (ID_SERVICIO) REFERENCES SERVICIO(ID_SERVICIO) ON DELETE CASCADE;
ALTER TABLE REEMBOLSO ADD CONSTRAINT FK_idFactReem FOREIGN KEY(ID_FACTURA) REFERENCES FACTURA(ID_FACTURA) ON DELETE CASCADE;
ALTER TABLE REEMBOLSO ADD CONSTRAINT FK_idServReem FOREIGN KEY (ID_SERVICIO) REFERENCES SERVICIO(ID_SERVICIO) ON DELETE CASCADE;


----------------------------------------------------------------STORED PROCEDURES----------------------------------------------------------------

-------------------------------------------------------------------USUARIO----------------------------------------------------------------
--SP PARA REGISTRAR EL NUEVO USUARIO EN LA BASE DE DATOS
GO
CREATE PROCEDURE REGISTRAR_USUARIO
	@USERNAME VARCHAR(80),
	@CLAVE VARCHAR(128),
	@ID_ROL INT,
	@NOMBRE_USER VARCHAR(80),
	@TELEFONO_CONTACTO VARCHAR (20),
	@DIRECCION_CONTACTO VARCHAR (80),
	@MAIL_CONTACTO VARCHAR(50),
	@ESTADO CHAR
AS
BEGIN
	IF EXISTS ( SELECT *FROM TB_SEGU_USER WHERE NOMBRE_USER=@NOMBRE_USER AND USERNAME=@USERNAME)
	BEGIN
		SELECT 'ERROR: El usuario ['+@NOMBRE_USER+'] ya se encuentra registrado.'
		RETURN
	END
	--SI NO EXISTE UNA COINCIDENCIA DE USUARIO YA REGISTRADO, ENTONCES CREA EL USUARIO
	INSERT INTO TB_SEGU_USER 
		(USERNAME, CLAVE, ID_ROL, NOMBRE_USER, TELEFONO_CONTACTO,DIRECCION_CONTACTO, MAIL_CONTACTO, ESTADO) 
	VALUES 
		(@USERNAME,HASHBYTES('SHA2_512',@CLAVE),@ID_ROL,@NOMBRE_USER,@TELEFONO_CONTACTO,@DIRECCION_CONTACTO,@MAIL_CONTACTO,@ESTADO)
	SELECT 'Se ha registrado exitosamente el usuario: ['+@NOMBRE_USER+']'
END

--SP PARA VALIDAR LAS CREDENCIALES DE ACCESO
go
CREATE PROC Validar_Login_Usuario
	@USER_NAME VARCHAR(80),
	@PASSWORD VARCHAR(128)
AS
BEGIN
	IF NOT EXISTS(SELECT *FROM TB_SEGU_USER WHERE USERNAME=@USER_NAME AND CLAVE=HASHBYTES('SHA2_512',@PASSWORD))
		BEGIN
			SELECT 'ERROR: USUARIO O CLAVE INCORRECTA';
		END
	ELSE
		BEGIN
			SELECT 'ACCESO EXITOSO'
		END
END

--SP PARA OBTENER EL NOMBRE DEL USUARIO Y SU ROL ASIGNADO
GO
CREATE PROCEDURE OBTENER_USUARIO_Y_ROL
	@USERNAME VARCHAR(80),
    @PASSWORD VARCHAR(128)
AS
BEGIN
    SELECT u.NOMBRE_USER AS NOMBRE_USUARIO, r.NOMBRE_ROL AS NOMBRE_ROL
    FROM TB_SEGU_USER u
    INNER JOIN TB_SEGU_ROL r ON u.ID_ROL = r.ID_ROL
    WHERE u.USERNAME = @USERNAME AND u.CLAVE = HASHBYTES('SHA2_512', @PASSWORD);
END

----------------------------------------------ASIGNACION DE ROLES----------------------------------------------
INSERT INTO TB_SEGU_ROL (NOMBRE_ROL, ESTADO) VALUES ('SCRUM MASTER', 'A');
INSERT INTO TB_SEGU_ROL (NOMBRE_ROL, ESTADO) VALUES ('DISE�ADOR UX/UI', 'A');
INSERT INTO TB_SEGU_ROL (NOMBRE_ROL, ESTADO) VALUES ('ANALISTA DE NEGOCIOS', 'A');
INSERT INTO TB_SEGU_ROL (NOMBRE_ROL, ESTADO) VALUES ('DESARROLLADOR DE SOFTWARE', 'A');

----------------------------------------------CREACION DE CREDENCIALES----------------------------------------------
GO
EXEC REGISTRAR_USUARIO 'angelo.valencia','valencia',2,'ANGELO VALENCIA','0987654321','Carlos Gurumendi y Segovia','esteno@gmail.com','A';
EXEC REGISTRAR_USUARIO 'heryd14','morla',1,'HERYD MORLA','0999080996','Sta Elena 212','const.12.83@ug.edu.ec','A';
EXEC REGISTRAR_USUARIO 'bryan.sanchez','sanchez',3,'BRYAN SANCHEZ','0999080996','Sta Elena 212','const.12.83@ug.edu.ec','A';
EXEC REGISTRAR_USUARIO 'petter_solorzano','solorzano',4,'PETTER SOLORZANO','0999080996','Sta Elena 212','const.12.83@ug.edu.ec','A';

-------------------------------------------------------------------CLIENTE----------------------------------------------------------------
GO
CREATE PROCEDURE NUEVO_CLIENTE
    @NOMBRES VARCHAR(30),
    @APELLIDOS VARCHAR(30),
    @CEDULA NUMERIC(10),
    @CORREO VARCHAR(45),
    @DIRECCION VARCHAR(40),
    @TELEFONO NUMERIC(10),
    @GENERO VARCHAR(20),
     @FECHA_REGISTRO DATE
AS
BEGIN
    IF EXISTS (SELECT * FROM CLIENTE WHERE CEDULA = @CEDULA)
    BEGIN
        SELECT 'ERROR: El cliente ya se encuentra registrado.';
        RETURN;
    END

    -- Si no existe una coincidencia de cliente ya registrado, entonces crea el cliente
    INSERT INTO CLIENTE (NOMBRES, APELLIDOS, CEDULA, CORREO, DIRECCION, TELEFONO, GENERO, FECHA_REGISTRO)
    VALUES (UPPER(@NOMBRES), UPPER(@APELLIDOS), @CEDULA, @CORREO, UPPER(@DIRECCION), @TELEFONO, UPPER(@GENERO), @FECHA_REGISTRO);

    SELECT 'Se ha registrado exitosamente al cliente: [ ' + @APELLIDOS + ' ' + @NOMBRES+ ' ]';
END

--SP DE CONSULTA EN FORMULARIO DE NUEVO_CLIENTE
GO
CREATE PROCEDURE GET_CLIENTES
AS 
BEGIN
     SELECT ID_CLIENTE, CEDULA ,GENERO,cl.NOMBRES + ' ' + cl.APELLIDOS AS NOMBRES, TELEFONO, CORREO,FECHA_REGISTRO as FECHA
     FROM CLIENTE cl;
END

--SP DE CONSULTA EN FORMULARIO DE CLIENTES
GO
CREATE PROCEDURE CLIENTES
AS
BEGIN
     SELECT ID_CLIENTE, CEDULA ,CL.NOMBRES+'-'+CL.APELLIDOS AS NOMBRES, CORREO, GENERO, FECHA_REGISTRO AS 'ULT. MODIFICACION', ESTADO
     FROM CLIENTE cl;
END

--SP DE ACTUALIZAR CLIENTE
GO
CREATE PROCEDURE ACTUALIZAR_CLIENTE
	     @NOMBRES VARCHAR (30),
	     @APELLIDOS VARCHAR (30),
 	     @CEDULA NUMERIC(10),
	     @CORREO VARCHAR (45),
	     @DIRECCION VARCHAR(40),
	     @TELEFONO NUMERIC (10),
	     @GENERO VARCHAR(20),
	     @FECHA_REGISTRO DATE
AS
BEGIN
	    UPDATE CLIENTE
	    SET NOMBRES=UPPER(@NOMBRES),
		        APELLIDOS = UPPER(@APELLIDOS),
		        CORREO = @CORREO,
		        DIRECCION = UPPER(@DIRECCION),
		        TELEFONO = @TELEFONO,
		        GENERO = UPPER(@GENERO),
		        FECHA_REGISTRO = @FECHA_REGISTRO
	    WHERE CEDULA=@CEDULA;
	    SELECT 'Los datos del Cliente se han actualizado.';
END

--SP DE ELIMINAR_CLIENTE (CAMBIAR ESTADO)
GO
CREATE PROCEDURE ELIMINAR_CLIENTE
	    @ID_CLIENTE INT
AS
BEGIN
		   DELETE FROM CLIENTE WHERE ID_CLIENTE=@ID_CLIENTE;
END

-------------------------------------------------------------------PAGO----------------------------------------------------------------
GO
CREATE PROCEDURE NUEVO_PAGO
	@CODIGO_CLIENTE int,
	@FECHA DATE,
	@METODO_PAGO VARCHAR(30),
	@EFECTIVO FLOAT
AS
BEGIN
	IF EXISTS(SELECT CEDULA FROM CLIENTE WHERE ID_CLIENTE = @CODIGO_CLIENTE OR CEDULA=@CODIGO_CLIENTE)
	BEGIN
		IF NOT EXISTS(SELECT * FROM CLIENTE WHERE CEDULA =(SELECT CEDULA FROM CLIENTE WHERE ID_CLIENTE = @CODIGO_CLIENTE OR CEDULA=@CODIGO_CLIENTE) AND ESTADO = 'PAGANDO')
		BEGIN
			INSERT INTO PAGO (FECHA_PAGO,METODO_PAGO,EFECTIVO,ID_CLIENTE,ESTADO) 
			VALUES(@FECHA,UPPER(@METODO_PAGO),ROUND(@EFECTIVO,2),
				(SELECT ID_CLIENTE FROM CLIENTE WHERE ID_CLIENTE = @CODIGO_CLIENTE OR CEDULA=@CODIGO_CLIENTE),
			upper('EN PROCESO'));
			UPDATE CLIENTE SET ESTADO = 'PAGANDO' WHERE CEDULA = (SELECT CEDULA FROM CLIENTE WHERE ID_CLIENTE = @CODIGO_CLIENTE OR CEDULA=@CODIGO_CLIENTE)
			SELECT 'Pago realizado con �xito';
			RETURN;
		END
		ELSE
		BEGIN
			SELECT 'Cliente: '+(SELECT APELLIDOS+' '+NOMBRES FROM CLIENTE WHERE CEDULA = (SELECT CEDULA FROM CLIENTE WHERE ID_CLIENTE = @CODIGO_CLIENTE OR CEDULA=@CODIGO_CLIENTE))+', ya se encuentra en proceso de pago de una Factura';
		END
	END
	ELSE
	BEGIN
		SELECT 'C�digo de Cliente no encontrado';
	END
END
GO
CREATE PROCEDURE CONSULTAR_PAGOS
AS
BEGIN
	     SELECT ID_PAGO,FECHA_PAGO,METODO_PAGO,EFECTIVO
	     FROM PAGO;
END

GO
CREATE PROCEDURE ACTUALIZAR_PAGO
	     @ID_PAGO int,
	     @FECHA DATE,
	     @METODO_PAGO VARCHAR(30),
	     @VALOR FLOAT
AS
BEGIN
	     UPDATE PAGO
	     SET FECHA_PAGO = @FECHA,
		          METODO_PAGO = UPPER(@METODO_PAGO),
		          EFECTIVO = ROUND(@VALOR,2)
	     WHERE ID_PAGO=@ID_PAGO;
	     SELECT 'Los datos del Cliente se han actualizado.';
END

GO
CREATE PROCEDURE ELIMINAR_PAGO
	@ID_PAGO int
AS
BEGIN
	DELETE FROM PAGO WHERE ID_PAGO = @ID_PAGO;
END

-------------------------------------------------------------------FACTURA----------------------------------------------------------------
GO 
CREATE PROCEDURE NUEVA_FACTURA
	@idCliente int,
	@descripcionServ varchar(180),
	@cantidad int,
	@valorUnitario float,
	@nombreEncargado varchar(80),
	@fecha date,
	@total float
AS
BEGIN
	--Creacion de variables de tipo int
	DECLARE @idServ int =0 ;
	DECLARE @idFact int =0;
	DECLARE @idEmpresa int =0;
	SET @idCliente = (SELECT ID_CLIENTE FROM CLIENTE WHERE ID_CLIENTE=@idCliente OR CEDULA = @idCliente);
	--Primero se a�ade los datos del servicio a la tabla SERVICIO
	INSERT INTO SERVICIO(DESCRIPCION_SERVICIO, VALOR_UNITARIO) VALUES(upper(@descripcionServ),ROUND(@valorUnitario,2));
	--Se obtiene el valor maximo de la columna ID_SERVICIO de la tabla SERVICIO
	SET @idServ =  (SELECT MAX(ID_SERVICIO) FROM SERVICIO);
	/*Si la cantidad de registros de la tabla EMPRESA es mayor que 0 entonces obtiene el valor m�ximo de
	la columna ID_EMPRESA de la tabla y lo asigna a la variable idEmpresa.*/
	IF ((SELECT COUNT(*) EMPRESA) > 0)
	BEGIN
		SET @idEmpresa = (SELECT MAX(ID_EMPRESA) FROM EMPRESA);
	END
	ELSE
	BEGIN
	/*De lo contrario crea un registro y luego asigna ese valor a la variable idEmpresa*/
		INSERT INTO EMPRESA(NOMBRE,DESCRIPCION_EMPRESA) VALUES(UPPER('AC. REDES'),UPPER('EMPRESA DESTINADA A GESTIONAR SISTEMAS DE FACTURACION PARA TU NEGOCIO'));
		SET @idEmpresa = (SELECT MAX(ID_EMPRESA) FROM EMPRESA);
	END
	--Crea un registro del encabezado de la Factura
	INSERT INTO FACTURA(ID_EMPRESA,ID_CLIENTE,FECHA_FACTURACION,ESTADO) 
	VALUES(@idEmpresa,@idCliente,@fecha,upper('pagado'));
	--Asigna a la variable idFact el valor maximo de la columna ID_FACTURA de la tabla FACTURA
	SET @idFact = (SELECT MAX(ID_FACTURA) FROM FACTURA);
	--Sigueinte crea el cuerpo de la factura a�adiendo las variables correspondientes a los registros
	INSERT INTO DETALLE_FACTURA(ID_FACTURA, ID_SERVICIO,NOMBRE_ENCARGADO,CANTIDAD,TOTAL_PAGAR)
	VALUES(@idFact,@idServ,upper(@nombreEncargado),@cantidad,@total);

	--Por �ltimo reasigna los estados de cliente -> ACTIVO y pago relacionado con el cliente a PAGADO
	UPDATE CLIENTE SET ESTADO = 'ACTIVO' WHERE ID_CLIENTE=@idCliente;
	UPDATE PAGO SET ESTADO = 'PAGADO' WHERE ID_CLIENTE = @idCliente AND ESTADO = 'EN PROCESO';
	
	SELECT 'Factura generada con �xito';
	END

--SP para consultar las facturas
GO
CREATE PROCEDURE FACTURAS
AS
BEGIN
	SELECT f.ID_FACTURA, 
	cl.ID_CLIENTE, 
	cl.CEDULA,
	f.ID_EMPRESA, 
	f.FECHA_FACTURACION, 
	dt.ID_DETALLE_FACTURA, 
	dt.ID_SERVICIO, 
	dt.NOMBRE_ENCARGADO,
	dt.CANTIDAD,
	dt.TOTAL_PAGAR,
	s.DESCRIPCION_SERVICIO,
	s.VALOR_UNITARIO,
	f.ESTADO
	FROM SERVICIO s
	INNER JOIN DETALLE_FACTURA dt ON s.ID_SERVICIO = dt.ID_SERVICIO
	INNER JOIN FACTURA f ON dt.ID_FACTURA = f.ID_FACTURA
	INNER JOIN CLIENTE cl ON f.ID_CLIENTE = cl.ID_CLIENTE
	INNER JOIN PAGO p ON p.ID_CLIENTE = cl.ID_CLIENTE
	GROUP BY 
	f.ID_FACTURA, 
	cl.ID_CLIENTE, 
	cl.CEDULA,
	f.ID_EMPRESA, 
	f.FECHA_FACTURACION, 
	dt.ID_DETALLE_FACTURA, 
	dt.ID_SERVICIO, 
	dt.NOMBRE_ENCARGADO,
	dt.CANTIDAD,
	dt.TOTAL_PAGAR,
	s.DESCRIPCION_SERVICIO,
	s.VALOR_UNITARIO,
	f.ESTADO
END

--SP para actualizar un registro existente de una factura
GO
CREATE PROCEDURE ACTUALIZAR_FACTURA
	@idFact int,
	@descripcionServ varchar(180),
	@cantidad int,
	@valorUnitario float,
	@nombreEncargado varchar(80),
	@fecha date,
	@total float
AS
BEGIN
	--Creacion de variables de tipo int
	DECLARE @idServ int =0 ;
	SET @idServ = (SELECT ID_SERVICIO FROM FACTURA f INNER JOIN DETALLE_FACTURA dt ON f.ID_FACTURA=dt.ID_DETALLE_FACTURA WHERE f.ID_FACTURA = @idFact)

	--Primero se actualiza la descripci�n del servicio y su valor unitario
	UPDATE SERVICIO 
	SET 
		DESCRIPCION_SERVICIO = UPPER(@descripcionServ), 
		VALOR_UNITARIO = ROUND(@valorUnitario,2) 
	WHERE ID_SERVICIO=@idServ;

	--Despu�s se actualiza el cuerpo de la factura
	UPDATE DETALLE_FACTURA
	SET
		NOMBRE_ENCARGADO = UPPER(@nombreEncargado),
		CANTIDAD = @cantidad,
		TOTAL_PAGAR = ROUND(@total,2)
	WHERE ID_FACTURA = @idFact;

	--Por �ltimo se actualiza el encabezado de la factura
	UPDATE FACTURA
	SET
		FECHA_FACTURACION = @fecha
	WHERE ID_FACTURA = @idFact;

	SELECT 'Factura actualizada con �xito';
END

-------------------------------------------------------------------REEMBOLSO----------------------------------------------------------------
--SP para registrar el reembolso
GO
CREATE PROCEDURE NUEVO_REEMBOLSO
	@codigoFactura int,
	@cedula numeric(10),
	@codigoPago int,
	@motivoReembolso varchar(180),
	@fecha date
AS
BEGIN	
	IF NOT EXISTS (
		SELECT *
		FROM CLIENTE cl
		INNER JOIN PAGO p on cl.ID_CLIENTE = p.ID_CLIENTE
		INNER JOIN FACTURA f on cl.ID_CLIENTE = f.ID_CLIENTE
		where p.ESTADO = UPPER('reembolsado') and f.ESTADO = UPPER('anulado') and f.ID_FACTURA=@codigoFactura
	)
	BEGIN
		IF NOT EXISTS(SELECT * FROM CLIENTE WHERE CEDULA =@Cedula AND ESTADO = 'PAGANDO')
		BEGIN
			INSERT INTO REEMBOLSO(ID_FACTURA, ID_SERVICIO, MOTIVO_REEMBOLSO, FECHA)
			VALUES (@codigoFactura, (SELECT ID_SERVICIO FROM DETALLE_FACTURA WHERE ID_FACTURA = @codigoFactura), upper(@motivoReembolso),@fecha)
			UPDATE PAGO SET ESTADO = UPPER('REEMBOLSADO') WHERE ID_PAGO = @codigoPago;
			UPDATE FACTURA SET ESTADO = UPPER('ANULADO') WHERE ID_FACTURA = @codigoFactura;
			SELECT 'Se ha realizado correctamente el reembolso de su pago.';
			RETURN;
		END
		ELSE
		BEGIN
			SELECT 'Cliente: '+(SELECT APELLIDOS+' '+NOMBRES FROM CLIENTE WHERE CEDULA = @cedula)+', se encuentra en proceso de pago de una Factura';
		END
	END
	SELECT 'Esta factura ya fue anulada y el pago del cliente reembolsado.'
END

--SP para actualizar un reembolso
GO
CREATE PROCEDURE ACTUALIZAR_REEMBOLSO
	@codigoReembolso int,
	@Motivo varchar(180)
AS
BEGIN
	UPDATE REEMBOLSO
	SET
		MOTIVO_REEMBOLSO = upper(@Motivo)
	WHERE ID_REEMBOLSO = @codigoReembolso;

	SELECT 'Reembolso actualizado con �xito';
END


--SP para eliminar
GO
CREATE PROCEDURE ELIMINAR_REEMBOLSO
	@codigoReembolso int
AS
BEGIN
	DELETE FROM REEMBOLSO WHERE ID_REEMBOLSO= @codigoReembolso;
END