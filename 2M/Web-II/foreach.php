<?php

$frutas = ["Maçã","Banana","Laranja"];

foreach ($frutas as $fruta){ //array no plural, item no singular
  echo "$fruta<br>";
}

echo "<br>";

$frutas = ["Maçã","Banana","Laranja"];

foreach ($frutas as $indice => $fruta){ //declara váriavel pra obter do indíce
  echo " Índice: $indice, Fruta: $fruta<br>";
}

echo "<br>";

$informacoesPessoa = [
  "Nome" => "Vanessa",
  "Idade" => 30,
  "Cidade" => "Jaú"
];

foreach ($informacoesPessoa as $chave => $valor){
  echo "$chave: $valor<br>";
}

echo "<br>";
?>