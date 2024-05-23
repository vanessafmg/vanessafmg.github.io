<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Fornatar Número</title>
</head>
<body>
  <?php
  $numero = 1234.56789;
  $numeroFormatado= number_format($numero, 2, ',', '.');
  echo $numeroFormatado . '<br>';
  ?>
</body>
</html>

