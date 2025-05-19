<?php
$pro1=70;
$pro2=80;
$pro3=60;
$promedio=$pro1+$pro2+$pro3/3;
if($promedio >= 96){
    echo "estas exento";
}
elseif($promedio >=70 && $promedio <=95){
    echo"aprobado";
}elseif($promedio >=96){
    echo"estas reprobado";
}
?>
