<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Dias da Semana</title>
</head>
<body>
  <?php
  $diaSemana = "Quarta";

  switch ($diaSemana){
    case "Segunda":
      echo "Hoje é segunda-feira.";
      break;
    case "Terça":
      echo "Hoje é terça-feira";
      break;
    case "Quarta":
      echo "Hoje é quarta-feira";
      break;
    case "Quinta":
      echo "Hoje é quinta-feira";
      break;
    case "Sexta":
      echo "Hoje é sexta-feira";
      break;
    default:
    echo "Final de semana!";
  }
  ?>
</body>
</html>