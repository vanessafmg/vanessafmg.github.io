
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Comissões</title>
  <style>
    body 
      {
        font-family: Arial, sans-serif;
        background-color: #f0f0f0; /* Cor de fundo do corpo da página */
      }

      h1 {
        text-align: center; /* Centraliza o título */
      }

      .form-container {
        text-align: center; /* Centraliza o formulário */
        margin: 20px auto; /* Centraliza na página */
        width: 30%; /* Largura do formulário */
        background-color: #f9f9f9; /* Cor de fundo do formulário */
        padding: 20px; /* Espaçamento interno do formulário */
        border: 1px solid #ddd; /* Borda do formulário */
        border-radius: 8px; /* Arredondamento das bordas do formulário */
      }

      .response-container {
        text-align: center; /* Centraliza a resposta */
        margin: 20px auto;
        margin-top: 20px; /* Espaçamento superior para separar a resposta do formulário */
        width: 35%; /* Largura da resposta */
        background-color: #f9f9f9; /* Cor de fundo da resposta */
        padding: 10px; /* Espaçamento interno da resposta */
        border: 1px solid #ddd; /* Borda da resposta */
        border-radius: 8px; /* Arredondamento das bordas da resposta */
      }
  </style>
</head>
<body>
<h1>Cálculo de Comissão</h1>
<div class="form-container">
  <form action="vendas.php" method="post"> 
      <label for="nome">Nome do Funcionário:</label> 
      <input type="text" name="nome" required><br><br>
      
      <label for="venda1">Venda Semana 01:</label>
      <input type="number" name="venda1" step="0.01" required><br><br>

      <label for="venda2">Venda Semana 02:</label>
      <input type="number" name="venda2" step="0.01" required><br><br>

      <label for="venda3">Venda Semana 03:</label>
      <input type="number" name="venda3" step="0.01" required><br><br>

      <label for="venda4">Venda Semana 04:</label>
      <input type="number" name="venda4" step="0.01" required><br><br>      

      <input type="submit" value="Total de Vendas">
  </form>
</div>
<div class="response-container">
  <?php
        $nome="";
        $venda1="";
        $venda2="";
        $venda3="";
        $venda4="";      

        $totalvendas = 0;
        $comissao = 0;
        $valorfinal = 0;
        $temErro = false;

        $erroNome = "";
        $errovenda1 = "";
        $errovenda2 = "";
        $errovenda3 = "";
        $errovenda4 = "";

    if ($_SERVER["REQUEST_METHOD"]=="POST"){
        //identificar se veio de um post, ou se está sendo carregada pela primeira vez
        $nome = $_POST["nome"]; //super global
        $venda1 = $_POST["venda1"];
        $venda2 = $_POST["venda2"];
        $venda3 = $_POST["venda3"];
        $venda4 = $_POST["venda4"];

        if (trim($nome) == ""){
          $erroNome = "Campo de preenchimento obrigatório";
          $temErro = true;
        }

        if (trim($venda1) == ""){
          $errovenda1 = "Campo de preenchimento obrigatório";
          $temErro = true;
        }

        if (trim($venda2) == ""){
          $errovenda2= "Campo de preenchimento obrigatório";
          $temErro = true;
        }

        if (trim($venda3) == ""){
          $errovenda3= "Campo de preenchimento obrigatório";
          $temErro = true;
        }

        if (trim($venda4) == ""){
          $errovenda4 = "Campo de preenchimento obrigatório";
          $temErro = true;
        }

        if($temErro == false) {

        $totalvendas = $venda1+$venda2+$venda3+$venda4;

        $total_formatado = number_format($totalvendas, 2, ',', '.');

              if ($totalvendas>1500){
                $comissao = $totalvendas * (25/100);
                $valorfinal = $comissao+$totalvendas;       
              }
              else {
                $comissao = $totalvendas * (15/100);
                $valorfinal = $comissao+$totalvendas;
              }
              
        $comissao_formatado = number_format($comissao, 2, ',', '.');
        $valorfinal_formatado = number_format($valorfinal,2, ',', '.');
        
        echo "<br>Nome do Funcionário: $nome <br>Total das Vendas: $total_formatado <br>Comissão: $comissao_formatado <br>Valor Final: $valorfinal_formatado";  
            }        
    }

  ?>
</div>
</body>
</html>