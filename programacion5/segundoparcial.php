<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Evaluación del Alumno</title>
    <style>
        body {
            background-color: #007BFF; /* Azul */
            color: white;
            font-family: Arial, sans-serif;
        }
    </style>
</head>
<body>
    <h2>Formulario de Evaluación</h2>

    <form method="post">
        <label>Nombre del Alumno:</label><br>
        <input type="text" name="nombre"><br><br>

        <label>Género:</label><br>
        <input type="radio" name="genero" value="Masculino"> Masculino<br>
        <input type="radio" name="genero" value="Femenino"> Femenino<br><br>

        <label>Materia:</label><br>
        <select name="materia">
            <option value="Inglés">Inglés</option>
            <option value="Seguridad">Seguridad</option>
            <option value="Programación">Programación</option>
            <option value="Neumática">Neumática</option>
            <option value="Electrónica">Electrónica</option>
        </select><br><br>

        <label>Calificación 1:</label><br>
        <input type="number" name="cal1" ><br><br>

        <label>Calificación 2:</label><br>
        <input type="number" name="cal2" ><br><br>

        <label>Calificación 3:</label><br>
        <input type="number" name="cal3" ><br><br>

        <input type="submit" value="Evaluar">
    </form>

    <?php
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $nombre = $_POST["nombre"];
        $genero = $_POST["genero"];
        $materia = $_POST["materia"];

        $cal1 = $_POST["cal1"];
        $cal2 = $_POST["cal2"];
        $cal3 = $_POST["cal3"];

        $promedio = ($cal1 + $cal2 + $cal3) / 3;

        if ($promedio <= 69) {
            $estatus = "Reprobado";
            $color ="red";
        } else if ($promedio >= 70 && $promedio <= 95) {
            $estatus = "Ordinario";
            $color = "orange";
        } else if ($promedio >= 96) {
            $estatus = "Exento";
            $color = "green";
        }

        echo "<h3>Resultado de Evaluación</h3>";
        echo "<div style='border:1px solid black; padding:10px; width:300px'>";
        echo "Nombre del Alumno: <strong>$nombre</strong><br>";
        echo "Género: <strong>$genero</strong><br>";
        echo "Materia: <strong>$materia</strong><br>";
        echo "Calificación 1: <strong>$cal1</strong><br>";
        echo "Calificación 2: <strong>$cal2</strong><br>";
        echo "Calificación 3: <strong>$cal3</strong><br>";
        echo "Promedio Final: <strong>" . number_format($promedio, 2) . "</strong><br>";
        echo "Estatus: <strong>$estatus</strong><br>";
        echo "</div>";

    }
    ?>
</body>
</html>

