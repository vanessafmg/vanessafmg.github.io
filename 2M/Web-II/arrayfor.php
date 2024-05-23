<?php
$lista = [10,20,30,40,50];

for($i=0; $i<count($lista); $i++){ //função count conta posições de um array
  echo "Item:  $lista[$i]<br>"; 
}

$lista2 = [1,2,3,4,5];

for($i=0; $i<count($lista2); $i++){ //função count conta posições de um array
  echo "Item: " . $lista2[$i] + 2 ."<br>"; //. concatenação
}

$lista3 = [1,2,3,4,5];
$resultado=0;

for($i=0; $i<count($lista3); $i++){ //função count conta posições de um array
  $resultado += $lista3 [$i]; //somar itens da lista
}
echo "Resultado: $resultado";
?>