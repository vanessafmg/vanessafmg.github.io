<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Utilizando Array</title>
</head>
<body>
    <?php
    //ctrl+; comenta um texto selecionado
    //$numeros = array (10, 20, 30, 40); //menos utilizado

    //array indexado
    $numeros = [10, 20 , 30, 40, 50];
    $numeros[] = 60; //adciona um número ao final do array
    $numeros[1] = 22; //altera um valor, neste caso, de 20 para 22
    unset($numeros[0]); //Remove um item do array

    echo "Primeiro número: $numeros[1]<br>"; //índice do número que quero mostrar, neste caso, posição 1 = 20 

   //array associativo
    $dadosPessoa = [
        'nome' => 'Vanessa',
        'idade' => 30,
        'notas' => [9, 8.5, 10, 9]
    ];
        
    echo $dadosPessoa['nome'] . ' ' . $dadosPessoa['idade'] . ' ' . $dadosPessoa['notas'][2];

    //mostrar todos os elementos do array
    $elementos = [10, 20 , 30, 40, 50]; 

    echo "<br>Todos os elementos: <br>" . implode('<br>', $elementos); //html é utilizado entre ""

    $lista = "1,2,3,4,5";
    $array = explode(',', $lista);

    $data = "21/02/2024";
    $array = explode('/', $data);




    


        

    ?>

    
</body>
</html>
