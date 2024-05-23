<?php
include_once('conexao.php'); 

$nome = $_POST['nome'];
$uf = $_POST['uf'];

$sqlInsert = "INSERT INTO cidades (nome, uf)
        VALUES ('$nome', '$uf')";

$resultado = mysqli_query($conexao, $sqlInsert);

if (!$resultado) {
    die('Não foi possível cadastrar. Descrição: ' . mysqli_error($conexao));
} else {
  echo "Registro Cadastrado com Sucesso";
}
mysqli_close($conexao);
?>
