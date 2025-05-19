<?php
$numero1=$_POST['numero1'];
$numero2=$_POST['numero2'];
$resultado=$_POST['calcular'];

switch($resultado) {
    case 'suma':
        $resultado=$numero1+$numero2;
        echo "Tu resultado es: $resultado";
        break;
     case 'resta':
        $resultado=$numero1-$numero2;
        echo "Tu resultado es: $resultado";
        break;
    case 'multiplicar':
        $resultado=$numero1*$numero2;
        echo "Tu resultado es: $resultado";
        break;
    case 'division':
        $resultado=$numero1 / $numero2;
        echo "Tu resultado es: $resultado";
        break;                
}
?>