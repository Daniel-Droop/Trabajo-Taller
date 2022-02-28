create table usuarios(
    codigo int not null auto_increment,
    nombre varchar(100) not null,
    apellido varchar (100) not null,
    correo varchar (100) not null,
    telefono int not null,
    cedula int not null,
    primary key(codigo)
);
INSERT INTO usuarios(nombre, apellido, correo, telefono, cedula)
VALUES ('Don', 'pepito', 'dospepito@ucompensar',223454334, 123456789);