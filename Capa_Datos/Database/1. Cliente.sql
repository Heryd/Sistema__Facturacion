USE GS_FACT_03;
GO

--CREACION DE LA TABLA
CREATE TABLE CLIENTE(
    ID_CLIENTE INT,
    NOMBRES VARCHAR(30),
    APELLIDOS VARCHAR(30),
    CEDULA NUMERIC(10),
    CORREO VARCHAR(45),
    DIRECCION VARCHAR(40),
    TELEFONO  NUMERIC(10),
    GENERO VARCHAR(20),
	ESTADO VARCHAR(10) DEFAULT 'ACTIVO',
	FECHA_REGISTRO DATE
);

--SECUENCIA PARA INCREMENTAR LOS VALORES DEL ID
BEGIN
    CREATE SEQUENCE SEQ_CLIENTE
        AS INT
        START WITH 1
        INCREMENT BY 1;
END
--SP PARA OBTENER EL CODIGO_CLIENTE
BEGIN
    GO
    CREATE PROCEDURE GET_CODIGO_CLIENTE
    AS
    BEGIN
        DECLARE @UltimoID INT;

        -- Obtener el último ID_CLIENTE registrado
        SELECT @UltimoID = MAX(ID_CLIENTE) FROM CLIENTE;

        -- Verificar si existe un registro previo
        IF @UltimoID IS NULL
        BEGIN
            -- No hay registros previos, establecer el primer ID_CLIENTE como 1
            SET @UltimoID = 1;
        END
        ELSE
        BEGIN
            -- Hay registros previos, incrementar el último ID_CLIENTE en 1
            SET @UltimoID = @UltimoID + 1;
        END

        -- Devolver el valor del último ID_CLIENTE
        SELECT @UltimoID;
    END
END
--SP DE NUEVO_CLIENTE
BEGIN
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
        -- Declarar una variable para almacenar el nuevo ID_CLIENTE generado por la secuencia
        DECLARE @NuevoID INT;

        -- Generar el próximo ID_CLIENTE utilizando la secuencia
        SELECT @NuevoID = NEXT VALUE FOR SEQ_CLIENTE;

        IF EXISTS (SELECT * FROM CLIENTE WHERE CEDULA = @CEDULA)
        BEGIN
            SELECT 'ERROR: El cliente ya se encuentra registrado.';
            RETURN;
        END

        -- Si no existe una coincidencia de cliente ya registrado, entonces crea el cliente
        INSERT INTO CLIENTE (ID_CLIENTE, NOMBRES, APELLIDOS, CEDULA, CORREO, DIRECCION, TELEFONO, GENERO, FECHA_REGISTRO)
        VALUES (@NuevoID, @NOMBRES, @APELLIDOS, @CEDULA, @CORREO, @DIRECCION, @TELEFONO, @GENERO, @FECHA_REGISTRO);

        SELECT 'Se ha registrado exitosamente al cliente: [ ' +@NOMBRES+ ' ' + @APELLIDOS + ' ]';
    END
END

--SP DE CONSULTA EN FORMULARIO DE NUEVO_CLIENTE
BEGIN
    CREATE PROCEDURE GET_CLIENTES
    AS 
    BEGIN
        SELECT ID_CLIENTE, CEDULA ,GENERO,cl.NOMBRES + ' ' + cl.APELLIDOS AS NOMBRES, TELEFONO, CORREO,FECHA_REGISTRO as FECHA
        FROM CLIENTE cl
        WHERE cl.ESTADO = 'ACTIVO'
    END
END

--SP DE CONSULTA EN FORMULARIO DE CLIENTES
BEGIN
    CREATE PROCEDURE CLIENTES
    AS
    BEGIN
        SELECT ID_CLIENTE, CEDULA ,CL.NOMBRES+'-'+CL.APELLIDOS AS NOMBRES, CORREO, GENERO, FECHA_REGISTRO AS 'ULT. MODIFICACION', ESTADO
        FROM CLIENTE cl;
        WHERE cl.ESTADO = 'ACTIVO'
    END
END 

--SP DE ACTUALIZAR CLIENTE
BEGIN
    CREATE PROCEDURE ACTUALIZAR_CLIENTE
        @ID_CLIENTE INT,
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
        IF EXISTS(SELECT ID_CLIENTE FROM CLIENTE WHERE ID_CLIENTE=@ID_CLIENTE)
        BEGIN
            UPDATE CLIENTE
            SET NOMBRES=@NOMBRES,
                APELLIDOS = @APELLIDOS,
                CEDULA = @CEDULA,
                CORREO = @CORREO,
                DIRECCION = @DIRECCION,
                TELEFONO = @TELEFONO,
                GENERO = @GENERO,
                FECHA_REGISTRO = @FECHA_REGISTRO
            WHERE ID_CLIENTE=@ID_CLIENTE;
        SELECT 'Los datos del Cliente se han actualizado.';
        END
    END
END
--SP DE ELIMINAR_CLIENTE (CAMBIAR ESTADO)
BEGIN
    CREATE PROCEDURE ELIMINAR_CLIENTE
        @ID_CLIENTE INT
    AS
    BEGIN
        UPDATE CLIENTE SET ESTADO='ELIMINADO' WHERE ID_CLIENTE=@ID_CLIENTE;
    END
END

--INSERTAR DATOS
BEGIN
    EXEC NUEVO_CLIENTE 'Carlos Manuel','San-Martin', '0940852018','hemiliano.12@gmail.com','Por allá y por acá','0980829891','MASCULINO','12/07/2023';
    EXEC NUEVO_CLIENTE 'Maria Auxiliadora','Saabedra MSter', '0903745756','hemiliano.12@gmail.com','Más allá que nunca','0954365744','Femenino','01/19/2023';
    EXEC NUEVO_CLIENTE 'Helena Irene','Ureña Larrea', '0929252339','hemiliano.12@gmail.com','La P y Tirate al agua','0917515431','Femenino','12/03/2022';
    EXEC NUEVO_CLIENTE 'Ines Maria','Cordero Rivadeneira', '0962637712','hemiliano.12@gmail.com','Los últimos de dios','0932570563','Femenino','04/29/2021';
    EXEC NUEVO_CLIENTE 'ESTHER MORATA','Roma Caguana', '0914754139','hemiliano.12@gmail.com','La nueva esperanza que ya no está','0943669006','Femenino','11/01/2012';
    EXEC NUEVO_CLIENTE 'MARIA ROSARIO','GALISTEO DEL AGUILA', '0904336262','hemiliano.12@gmail.com','Coquitos','0981002864','Femenino','08/28/2020';
    EXEC NUEVO_CLIENTE 'Emilia Cristal','GONZALEZ MAURI', '0996412775','hemiliano.12@gmail.com','Tamre que rico kausa','0907491749','Femenino','07/05/2019';
    EXEC NUEVO_CLIENTE 'FELIPE LOIS','GRANDA VIZUETA', '0957849324','hemiliano.12@gmail.com','Brasil y la 14','0905150526','MASCULINO','12/03/2022';
    EXEC NUEVO_CLIENTE 'RAQUEL CAROLINA','VALLS VIEIRA', '0938709133','hemiliano.12@gmail.com','Ayacucho y la 14','0926095195','FEMENINO','12/03/2022';
    EXEC NUEVO_CLIENTE 'JOSE FRANCISCO','ALLER DEVESA', '0969018660','hemiliano.12@gmail.com','La 12+1 y Avanzando','0981811650','MASCULINO','12/03/2022';
    EXEC NUEVO_CLIENTE 'ROSA MARIA','BAENA FORNES', '0938493278','hemiliano.12@gmail.com','Alcedo','0925705320','FEMENINO','12/03/2022';
    EXEC NUEVO_CLIENTE 'PABLO CELI','BOHORQUEZ COLL', '0911695465','hemiliano.12@gmail.com','Ayacucho','0972025734','MASCULINO','12/03/2022';
    EXEC NUEVO_CLIENTE 'SILVIA','BADIA SARRIA', '0978755656','hemiliano.12@gmail.com','Barrio Nueva Esperanza','0954792884','FEMENINO','09/03/2022';
    EXEC NUEVO_CLIENTE 'ESTHER','VENEZUELA MENDOZA', '0912505455','hemiliano.12@gmail.com','Flor de Bastión Bloque 4','0959142623','FEMENINO','02/05/2021';
    EXEC NUEVO_CLIENTE 'ESPERANZA IVERRTE','GAZQUEZ CANTARERO', '0973694753','hemiliano.12@gmail.com','Trinipuerto','0955393596','FEMENINO','12/03/2022';
    EXEC NUEVO_CLIENTE 'SERGIO','MONTANER GAYA', '0965070358','hemiliano.12@gmail.com','Entrada de la 8','0934971845','MASCULINO','12/03/2022';
    EXEC NUEVO_CLIENTE 'VERONICA','BECERRA BERRIO', '0946257175','hemiliano.12@gmail.com','Puente de la A','0960486208','FEMENINO','12/03/2022';
    EXEC NUEVO_CLIENTE 'CARLITOS LUCHITO','VENEZUELA MENDOZA', '0957203710','hemiliano.12@gmail.com','Ayacucho y la 11','0941630090','MASCULINO','12/03/2023';
END


--ELIMINAR TABLA Y PROCEDIMIENTOS
DROP TABLE CLIENTE;
DROP PROCEDURE NUEVO_CLIENTE;
DROP PROCEDURE GET_CLIENTES;
DROP PROCEDURE GET_CODIGO_CLIENTE;
DROP PROCEDURE CLIENTES;
DROP PROCEDURE ELIMINAR_CLIENTE;
