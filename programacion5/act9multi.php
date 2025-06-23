<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>multri</title>
</head>
<body>
//For
    <form action="" method="post" name="For">
        <input type="number" placeholder="12" name="while" required>
        <button type="submit">For</button>
    </form>
//while
    <form action="" method="post">
    <input type="number" name="while" id="" required>
    <button type="submit">While</button>
    </form>
//Do-While
    <form action="" method="post" name="do-while">
        <input type="number" name="do-while" id="">
        <button type="submit">Do-While</button>
    </form>

<?php
//for
if (isset($_POST['For'])) {
    $for = $_POST['For'];
    echo"<h2>Tabla del $for </h2><table>";
    for ($i = 1; $i <=12; $i++) {
        echo "<tr><td> $for x $i = ". ($for * $i) ."</td></tr>";
    }
    echo "</table>";
}

//while
if (isset($_POST['while'])) {
    $n = (int)$_POST['while'];
    $i = 1;
    echo "<h2>Tabla del $n (While)</h2><table>";
    while ($i <= 10) {
        echo "<tr><td>$n x $i = " . ($n * $i) . "</td></tr>";
        $i++;
    }
    echo "</table>";
}

//do-while
if (isset($_POST['do-while'])) {
    $n = (int)$_POST['do-while'];
    $i = 1;
    echo "<h2>Tabla del $n (Do-While)</h2><table>";
    do {
        echo "<tr><td>$n x $i = " . ($n * $i) . "</td></tr>";
        $i++;
    } while ($i <= 10);
    echo "</table>";
}
?>
</body>
</html>