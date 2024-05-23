<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=, initial-scale=1.0">
  <title>if else</title>
</head>
<body>
  <?php
  $idade = 15;

  if ($idade >= 18){
    echo "Você é maior de idade.<br>";
  } else {
    echo "Você é menor de idade.<br>";
  }
  

  $nota = 75;
  if ($nota>=90){
    echo "A";
  } elseif ($nota>=80){
    echo "B";
  } else if ($nota>=70){
    echo "C";
  } else {
    echo "D";
  }
  ?>
</body>
</html>