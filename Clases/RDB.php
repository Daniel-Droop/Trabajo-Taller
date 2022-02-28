<?php
class registrodb{
    public function datosregistro(){
        $conn = new conexion();
        $conexion = $conn -> obtener();
        $sql="SELECT codigo, nombre, apellido, correo, telefono, cedula FROM usuarios";
        $consulta = $conexion -> prepare($sql);
        $consulta->execute();
        $filas = $consulta -> fetchAll();
    return $filas;
    }
    public function guardar($nombre, $apellido, $correo, $telefono, $cedula){
        $conn = new conexion();
        $conexion = $conn -> obtener();
        $sql = $conexion -> prepare("INSERT INTO usuarios(nombre, apellido, correo, telefono, cedula) VALUES ('$nombre', '$apellido', '$correo', '$telefono', '$cedula')");
        return $sql -> execute();
    }
    public function buscar($codigo){
        $conn = new conexion();
        $conexion = $conn -> obtener();
        $sql="SELECT codigo, nombre, apellido, correo, telefono, cedula FROM usuarios WHERE codigo = $codigo";
        $sql->execute();
        $filas = $sql-> fetchALL();
        return $filas
    }
    public function editar($codigo, $nombre, $apellido, $correo, $telefono, $cedula){
        $conn = new conexion();
        $conexion = $conn -> obtener();
        $sql= $conexion "UPDATE usuarios SET codigo = '$codigo', nombre = '$nombre', apellido = '$apellido', correo = '$correo', telefono = '$telefono', cedula = '$cedula' WHERE codigo = $codigo";
        return $sql -> execute();
    }
}