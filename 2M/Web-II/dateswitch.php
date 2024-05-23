<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>date weekend</title>
</head>
<body>
  <?php
  $data = date ('Y-m-d');
  $diaSemana = date('w', strtotime($data)); //transforma a váriavel em string weekend

  switch ($diaSemana){
    case "0":
      echo "Hoje é Domingo.";
      break;
    case "1":
      echo "Hoje é segunda-feira.";
      break;
    case "2":
      echo "Hoje é terça-feira";
      break;
    case "3":
      echo "Hoje é quarta-feira";
      break;
    case "4":
      echo "Hoje é quinta-feira";
      break;
    case "5":
      echo "Hoje é sexta-feira";
      break;
    default:
    echo "Hoje é sábado.";
  }
  ?>
</body>
</html>