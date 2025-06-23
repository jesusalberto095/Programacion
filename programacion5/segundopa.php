<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Evaluación del Alumno</title>
    <style>
        /* Estilo general del cuerpo de la página */
        body {
            background-color: #007BFF; /* Fondo azul */
            color: white; /* Texto en blanco */
            font-family: Arial, sans-serif; /* Fuente legible */
        }
    </style>
</head>
<body>
    <h2>Formulario de Evaluación</h2>

    <!-- Formulario que envía los datos con el método POST a esta misma página -->
    <form method="post">
        <!-- Campo de texto para el nombre del alumno -->
        <label>Nombre del Alumno:</label><br>
        <input type="text" name="nombre"><br><br>

        <!-- Opciones de género (radio buttons) -->
        <label>Género:</label><br>
        <input type="radio" name="genero" value="Masculino"> Masculino<br>
        <input type="radio" name="genero" value="Femenino"> Femenino<br><br>

        <!-- Selección de materia mediante un menú desplegable -->
        <label>Materia:</label><br>
        <select name="materia">
            <option value="Inglés">Inglés</option>
            <option value="Seguridad">Seguridad</option>
            <option value="Programación">Programación</option>
            <option value="Neumática">Neumática</option>
            <option value="Electrónica">Electrónica</option>
        </select><br><br>

        <!-- Campos numéricos para ingresar las tres calificaciones -->
        <label>Calificación 1:</label><br>
        <input type="number" name="cal1" ><br><br>

        <label>Calificación 2:</label><br>
        <input type="number" name="cal2" ><br><br>

        <label>Calificación 3:</label><br>
        <input type="number" name="cal3" ><br><br>

        <!-- Botón para enviar el formulario -->
        <input type="submit" value="Evaluar">
    </form>

    <?php
    // Si el formulario fue enviado (método POST)
    if ($_SERVER["REQUEST_METHOD"] == "POST") {

        // Recibe los valores del formulario
        $nombre = $_POST["nombre"];
        $genero = $_POST["genero"];
        $materia = $_POST["materia"];

        $cal1 = $_POST["cal1"];
        $cal2 = $_POST["cal2"];
        $cal3 = $_POST["cal3"];

        // Calcula el promedio de las 3 calificaciones
        $promedio = ($cal1 + $cal2 + $cal3) / 3;

        // Condiciones para asignar estatus según el promedio
        if ($promedio <= 69) {
            $estatus = "Reprobado";
            $color = "red"; // Rojo para reprobado
        } else if ($promedio >= 70 && $promedio <= 95) {
            $estatus = "Ordinario";
            $color = "orange"; // Naranja para ordinario
        } else if ($promedio >= 96) {
            $estatus = "Exento";
            $color = "green"; // Verde para exento
        }

        // Muestra el resultado del alumno en pantalla
        echo "<h3>Resultado de Evaluación</h3>";
        echo "<div style='border:1px solid black; padding:10px; width:300px'>";

        // Imprime los datos del formulario y el resultado del promedio
        echo "Nombre del Alumno: <strong>$nombre</strong><br>";
        echo "Género: <strong>$genero</strong><br>";
        echo "Materia: <strong>$materia</strong><br>";
        echo "Calificación 1: <strong>$cal1</strong><br>";
        echo "Calificación 2: <strong>$cal2</strong><br>";
        echo "Calificación 3: <strong>$cal3</strong><br>";
        echo "Promedio Final: <strong>" . number_format($promedio, 2) . "</strong><br>";

        // Estatus con el color correspondiente
        echo "Estatus: <strong style='color:$color'>$estatus</strong><br>";

        echo "</div>";
    }
    ?>
</body>
</html>
