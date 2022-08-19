DROP DATABASE IF EXISTS mudanzasFiumba;
CREATE DATABASE mudanzasFiumba;
USE mudanzasFiumba;

CREATE TABLE personas(
	idPersona INT auto_increment,
	dni INT,
	nomApe varchar(70),
	telefono varchar(20),
	email varchar(50),
	direccion varchar(50),
	CONSTRAINT PK_personas_idPersona PRIMARY KEY (idPersona)
);
CREATE TABLE Clientes(
	idCliente INT auto_increment,
	idPersona INT,
	Fecha_Ingreso DATE,
	constraint PK_clientes_idCliente PRIMARY KEY (idCliente),
	constraint FK_clientes_idPersona FOREIGN KEY (idPersona) REFERENCES personas(idPersona)
);
CREATE TABLE empleados (
	idEmpleado INT AUTO_INCREMENT,
	idPersona INT,
	Fecha_Ingreso DATE,
	CONSTRAINT PK_empleados_idEmpleado PRIMARY KEY (idEmpleado),
	constraint FK_empleados_idPersona FOREIGN KEY (idPersona) REFERENCES personas(idPersona)
);
CREATE TABLE empleados_administrativos(
	idEmpleadoAdminis INT AUTO_INCREMENT,
	idEmpleado INT,
	tipoEmpleado VARCHAR(50),
	CONSTRAINT PK_empleadosAdmin_idEmpleadoAdminis PRIMARY KEY (idEmpleadoAdminis),
	constraint FK_empleadosAdmin_idEmpleado FOREIGN KEY (idEmpleado) REFERENCES empleados(idEmpleado)
);
CREATE TABLE conductores (
	idConductor INT AUTO_INCREMENT,
	idEmpleado INT,
	CONSTRAINT PK_conductores_idConductor PRIMARY KEY (idConductor),
	constraint FK_conductores_idEmpleado FOREIGN KEY (idEmpleado) REFERENCES empleados(idEmpleado)
);
CREATE TABLE preciosCamiones(
	idPrecCam INT AUTO_INCREMENT,
	tamanio VARCHAR(30),
	precio INT,
	constraint PK_precioCamiones_idPrecCam PRIMARY KEY (idPrecCam)
);
CREATE TABLE Camiones(
	IdCamion INT AUTO_INCREMENT,
	idPrecCam INT,
	Patente VARCHAR(11),
	Marca VARCHAR(30),
	Modelo VARCHAR(20),
	Estado BOOLEAN,
	constraint PK_camiones_idCamion PRIMARY KEY (idCamion),
	constraint FK_camiones_idPrecCam foreign key(idPrecCam) references preciosCamiones(idPrecCam)
);
CREATE TABLE Objetos(
	IdObjeto int auto_increment,
	tamanio varchar(20),
	constraint PK_Objetos_idObjeto primary key (idObjeto)
);
CREATE TABLE Presupuestos(
	IdPresup INT AUTO_INCREMENT,
	nomApe varchar(70),
	telefono varchar(20),
	Precio INT,
	kilometros INT,
	fecha_emision DATE,
	Fecha_vencimiento DATE,
	constraint PK_presupuestos_idPresup primary key(IdPresup)
);
INSERT INTO objetos values
	("", "Chico"),
	("", "Mediano"),
	("", "Grande");
CREATE TABLE PresupObjeto(
	IdPresup int,
	IdObjeto int,
	Cant int,
	constraint PK_PresupObjeto_idPresupObj primary key (idPresup, idObjeto),
	constraint FK_PresupObjeto_idPresup foreign key(idPresup) references Presupuestos(IdPresup),
	constraint FK_PresupObjeto_idObj foreign key(idObjeto) references Objetos(IdObjeto)
);
CREATE TABLE Contratos(
	idContrato INT AUTO_INCREMENT,
	idPresup INT,
	idConductor INT,
	idCamion INT,
	fecha_mudanza DATETIME, /*obtener hora mediante TIME*/
	fecha_Emision DATE,
	mudanzaFin boolean,
	constraint PK_constrato_idContrato PRIMARY KEY (idContrato),
	constraint FK_contratos_idConductor foreign key(idConductor) references Conductores(idConductor),
	constraint FK_contratos_idCamion foreign key(idCamion) references Camiones(idCamion),
	constraint FK_contratos_idPresup foreign key(idPresup) references Presupuestos(idPresup)
);
CREATE TABLE recibos(
	idRecibo INT auto_increment,
	idContrato INT,
	fecha_emision DATETIME,
	Precio INT,
	constraint PK_recibos_idRecibo primary key (idRecibo),
	constraint FK_recibos_idContrato foreign key(idContrato) references Contratos(idContrato)
);
/*creacion de tablas dedicadas al servicio de guardamuebles y intereses*/
CREATE TABLE preciosAlmacenes(
	idPrecAlmacen INT AUTO_INCREMENT,
	tamanio VARCHAR(30),
	precio INT,
	constraint PK_precioA PRIMARY KEY (idPrecAlmacen)
);
CREATE TABLE AlmacenesGM(
	IdAlmacen int ,
	idPrecAlmacen INT,
	estado BOOLEAN,
	constraint PK_almacenesGM_idAlmacen primary key (IdAlmacen),
	constraint FK_almacenesGM_idPrecAlmacen foreign key (idPrecAlmacen) references preciosAlmacenes(idPrecAlmacen)
);
CREATE TABLE ContratoAlmacen(
	idContratoAlmacen INT AUTO_INCREMENT,
	idAlmacen int,
	idCliente int,
	Fecha_venc DATE,
	fechaE DATE,
	vigencia BOOLEAN,
	constraint PK_ContratoAlmacen_idContratoAlmac primary key(idContratoAlmacen),
	constraint FK_ContratoAlmacen_idCliente foreign key(idCliente) references Clientes(idCliente),
	constraint FK_ContratoAlmacen_idAlmacen foreign key(idAlmacen) references AlmacenesGM(idAlmacen)
);
CREATE TABLE ReciboAlmacen(
	idReciboAlmacen int auto_increment,
	idContratoAlmacen int,
	MontoRecibo int,
	constraint PK_ReciboAlmacen_idReciboAlm primary key(idReciboAlmacen),
	constraint FK_ReciboAlmacen_idCliente foreign key (idContratoAlmacen) references ContratoAlmacen(idContratoAlmacen)
);


