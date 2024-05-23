<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Média</title>
</head>
<body><center>
    <h1>Cálculo de Média</h1>
    <?php
        
        $nomeAluno = "Vanessa";
        $nota_1 = 10;
        $nota_2 = 10;

        $mediaAluno = ($nota_1 + $nota_2) / 2;

        if ($mediaAluno >=6){
            echo "Nome: $nomeAluno <br>Média: $mediaAluno <br>APROVADO";
        } else {
            echo "Nome: $nomeAluno <br>Média: $mediaAluno <br>RETIDO";
        }
    ?>
</body>
</html>