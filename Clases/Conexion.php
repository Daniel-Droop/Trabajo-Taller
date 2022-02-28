<?php
class conexion{
    private $servidor;
    private $usuario;
    private $clave;
    private $usuarios;
    public function __construct(){
        $this -> servidor = "localhost";
        $this -> usuario = "admin1";
        $this -> clave = "123456";
        $this -> BaseDatos = "usuarios";
    }
    public function obtener(){
        $codificacion = "SET NAMES \"UTF8\"";
        $cadena = "mysql:host = {$this -> servidor}; dbname = {$this -> usuarios};";
        $arreglo = array(PDO::MYSQL_ATTR_INIT_COMMAND => $codificacion);
        $conn = new PDO($cadena, $this->usuario, $this-> clave, $arreglo);
        return $conn;
    }
}