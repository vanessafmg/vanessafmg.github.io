<?php
include_once('conexao.php'); 

$usuario = $_POST['usuario'];
$senha = $_POST['senha'];
$senha = md5($senha);
$email = $_POST['email'];

$sqlInsert = "INSERT INTO usuarios (usuario, senha, email)
        VALUES ('$usuario', '$senha', '$email')";

$resultado = mysqli_query($conexao, $sqlInsert);

if (!$resultado) {
    die('Não foi possível cadastrar. Descrição: ' . mysqli_error($conexao));
} else {
  echo "Registro Cadastrado com Sucesso";
}
mysqli_close($conexao);
?>