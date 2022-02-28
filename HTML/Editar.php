<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="../Estilo/EstiloT2.css">
    <title>Parte 1</title>
</head>
<body>
    <section class="contenedor sombra">
        <h2>Registro</h2>

        <form class="formulario" action="" method="">
            <fieldset>
                <legend>Edita el registro</legend>
                <div class="contenedor-campo">
                    <div class="campo">
                        <label>Código</label>
                        <input class="input-text" type="text" name="codigo" value="">
                    </div>
                    <div class="campo">
                        <label>Nombre</label>
                        <input class="input-text" type="text" name="nombre" value="">
                    </div>
                    <div class="campo">
                        <label>Apelldio</label>
                        <input class="input-text" type="number" name="apellido" value="">
                    </div>
                    <div class="campo">
                        <label>Correo</label>
                        <input class="input-text" type="email" name="correo" value="">
                    </div>
                    <div class="campo">
                        <label>Telefono</label>
                        <input class="input-text" type="text" name="telefono" value="">
                    </div>
                    <div class="campo">
                        <label>Cedula</label>
                        <input class="input-text" type="text" name="cedula" value="">
                    </div>

                </div>
                <div class="alinear-centro flex">
                    <input class="boton enviar" type="submit" value="Actualizar">
                </div>
            </fieldset>
        </form>
    </section>
</body>
</html>