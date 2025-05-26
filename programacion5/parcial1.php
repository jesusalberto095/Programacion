<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Boletos</title>
</head>
<body>
    <h1>Cliente</h1>
    <form action="" method="post">
        <label for="nombre">Nombre completo:</label><br>
        <input type="text" id="nombre" name="nombre" required><br><br>

        <label for="edad">Edad:</label><br>
        <input type="number" id="edad" name="edad" required><br><br>

        <label for="cantidad">Cantidad de boletos:</label><br>
        <input type="number" id="cantidad" name="cantidad" min="1" required><br><br>

        <label for="opcion">Selecciona una función:</label><br>
        <select name="opcion" id="opcion" required>
            <option value="funcion 2D">Función 2D</option>
            <option value="funcion 3D">Función 3D</option>
            <option value="funcion imax">Función IMAX</option>
            <option value="sala vip">Sala VIP</option>
        </select><br><br>

        <input type="checkbox" name="casilla" id="casilla" value="si">
        <label for="casilla">Soy estudiante</label><br><br>

        <input type="submit" value="Enviar">
    </form>

    <?php 
    if ($_SERVER['REQUEST_METHOD'] == 'POST') { // en esta linia es la linea fue en la que batalle por que no declare o mas bien al declarar no lo ponia bien y chatgpy me digo que pisiera eso para solucionar 
        $nombre = $_POST['nombre'];
        $edad = (int)$_POST['edad'];
        $opcion = $_POST['opcion'];
        $cantidad = (int)$_POST['cantidad'];
        $casilla = isset($_POST['casilla']) && $_POST['casilla'] === 'si'; // es que para berificar si es estudiante o no 

        // Precio base por tipo de función
        switch ($opcion) {
            case 'funcion 2D':
                $precio = 60;
                break;
            case 'funcion 3D':
                $precio = 80;
                break;
            case 'funcion imax':
                $precio = 90; 
                break;
            case 'sala vip':
                $precio = 150; 
                break;
            default:
                $precio = 50; 
                break;
        }

        // Descuento según edad y si es estudiante
        $descuento = 0;

        if ($casilla && $edad >= 12 && $edad <= 24) {
            $descuento = 0.15;
        } elseif ($edad >= 65) {
            $descuento = 0.25;
        } elseif ($edad < 12) {
            $descuento = 0.20;
        }

        $precioFinal = $precio * (1 - $descuento); // aqui se hace el decuento
        $total = $precioFinal * $cantidad; //a qui sale ya cuanto es el precio total 

        echo "<h2>precio total :</h2>";
        echo "Nombre: $nombre<br>";
        echo "Edad: $edad<br>";
        echo "Función: $opcion<br>";
        echo "Precio individual: $precioFinal<br>";
        echo "Cantidad: $cantidad<br>";
        echo "Total a pagar: $total<br>";
    }
    ?>
</body>
</html>