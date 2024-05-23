<!DOCTYPE html>
<html lang="en">
<head>
      <meta charset="UTF-8">
      <meta name="viewport" content="width=device-width, initial-scale=1.0">
      <title>IMC</title>
      <link rel="stylesheet" type="text/css" href="style.css"/>
</head>
<body><div id="conteudo">
<?php
      $nome="";
      $email="";
      $valor="";

  if ($_SERVER["REQUEST_METHOD"]=="POST"){ 
      //identificar se veio de um post, ou se está sendo carregada pela primeira vez
      $nome = $_POST["nome"]; //super global
      $peso = $_POST["peso"];
      $altura = $_POST["altura"];

      //valor2 = str_replace(',', '.',$valor); -- converte vírgula digitada pelo usuário para ponto
      //die; 

      $imc = $peso / ($altura * $altura);

      $imc_formatado = number_format($imc, 1);

      
      echo "Olá,  $nome!<br>
      De acordo com o seu peso e a sua altura o seu IMC é: $imc_formatado<br>";

            if ($imc>40){
            echo "Obesidade Grau III";
            } elseif ($imc>=35){
            echo "Obesidade Grau II";
            } else if ($imc>=30){
            echo "Obesidade Grau I";
            } else if ($imc>=25){
            echo "Acima do peso";
            } else if ($imc>=18.5){
            echo "Peso normal";
            } else if ($imc>=17){
            echo "Abaixo do peso";            
            }else {
            echo "Muito abaixo do peso";
            }
    
} else {
      header ('Location: imc.php'); //redirecionar o usuário
      exit();
}
?>
    </div>    
</body>
</html>


