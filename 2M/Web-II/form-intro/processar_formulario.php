<?php
  if ($_SERVER["REQUEST_METHOD"]=="POST"){ 
      $nome = $_POST["nome"]; //super global
      $email = $_POST["email"];

      echo "Nome: $nome<br>";
      echo "E-mail: $email";
} else {
      header ('Location: form.php'); //redirecionar o usuário
      exit();
}
?>