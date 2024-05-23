<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Formulários</title>
</head>
<body>
  <form action="processar_formulario.php" method="post">  <!-- action: abrir arquivo - metodo de envio:post, o get pega valores na url e mostra os dados informados na url, não é seguro, é mais usado em paginação -->
      <label for="nome">Nome:</label> <!-- label para poder estilizar com css-->
      <input type="text" name="nome" required> <!-- informação requerida-->

      <label for="email">E-mail:</label>
      <input type="text" name="email" required>

      <input type="submit" value="Enviar">
  </form>
</body>
</html>

