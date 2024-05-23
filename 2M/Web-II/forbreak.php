<?php

for ($i=0; $i<10; $i++){
  if ($i ==5){
    break; //interrompe o laço quando chega no 5
  }

  echo $i . "<br>";
}

echo "<br>";

for ($i=0; $i<10; $i++){
  if ($i ==5){
    continue; // ao atingir o continue, ele pula e segue para o próximo
  }

  echo $i . "<br>";
}

?>