<?php
    include './Conexion.php';
    include './RDB.php';
    $registro = new registrodb();

    $nombre = filter_input(INPUT_POST,"nombre", FILTER_SANITIZE_ENCODED);
    $apellido = filter_input(INPUT_POST,"apellido", FILTER_SANITIZE_ENCODED);
    $correo = filter_input(INPUT_POST,"correo", FILTER_SANITIZE_ENCODED);
    $telefono = filter_input(INPUT_POST,"telefono", FILTER_SANITIZE_ENCODED);
    $cedula = filter_input(INPUT_POST,"cedula", FILTER_SANITIZE_FULL_SPECIAL_CHARS);
    $bandera = $registro -> guardar($nombre, $apellido, $correo, $telefono, $cedula);
    if ($bandera){
        header("Location: ../HTML/Registrados.php?mns-si");
    }else{
        header("Location: ../HTML/Registrados.php?mns-si");
    }