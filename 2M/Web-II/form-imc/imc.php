<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>IMC</title>
  <link rel="stylesheet" type="text/css" href="style.css"/>
</head>
<body>
<center><h1>Cálculo do IMC</h1>
  <form action="processar_formulario.php" method="post"> 
      <label for="nome">Nome:</label> 
      <input type="text" name="nome" required><br><br>

      <label for="peso">Peso (kg):</label>
      <input type="number" name="peso" step="0.01" required><br><br>

      <label for="altura">Altura (m):</label>
      <input type="number" name="altura" step="0.01" required><br><br>

      <input type="submit" value="Calcular">
</center></form>
</body>
</html>