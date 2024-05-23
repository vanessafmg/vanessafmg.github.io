<?php
include_once('conexao.php'); 

$modelo = $_POST['modelo'];
$marca = $_POST['marca'];
$cor = $_POST['cor'];
$valor = $_POST['valor'];
$ano = $_POST['ano'];

$sqlInsert = "INSERT INTO carros (modelo, marca, cor, valor, ano)
        VALUES ('$modelo', '$marca', '$cor', '$valor', '$ano')";

$resultado = mysqli_query($conexao, $sqlInsert);

if (!$resultado) {
    die('Não foi possível cadastrar. Descrição: ' . mysqli_error($conexao));
} else {
  echo "Registro Cadastrado com Sucesso";
}
mysqli_close($conexao);
?>
