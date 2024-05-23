<?php
$nome = "";
$email = "";

$erroNome = "";
$erroEmail = "";

if ($_SERVER["REQUEST_METHOD"] =="POST"){
    $nome = $_POST["nome"];
    $email = $_POST["email"];

    if (trim($nome) == ""){
        $erroNome = "Campo de preenchimento obrigatório.";
    }

    if (trim($email) == ""){
        $erroEmail = "Campo de preenchimento obrigatório.";
    } else {
        if(!filter_var($email, FILTER_VALIDATE_EMAIL)){
            $erroEmail = "O email informado não é válido";
        }
    }
}
?>
<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Bootstrap demo</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
  </head>
  <body>
    <div class="row ps-3">
        <div class="col">
        <h1>Cadastro de Usuários</h1>
            <form class="row" action="formulario.php" method="post">
                <div class="row">
                    <div class="col-3">
                        <label for="nome" class="form-label">Nome</label>
                        <input type="text" name="nome" class="form-control <?php echo ($erroNome != '' ? 'is-invalid' : '') ?>" value="<?php echo $nome ?>">
                        <div class="invalid-feedback">
                            <?php echo $erroNome ?>
                        </div>    
                    </div>                    
                </div>
                <div class="row">
                    <div class="col-3">
                        <label for="email" class="form-label">E-mail</label>
                        <input type="text" name="email" class="form-control <?php echo ($erroEmail != '' ? 'is-invalid' : '') ?>" value="<?php echo $email ?>">
                        <div class="invalid-feedback">
                            <?php echo $erroEmail ?>
                        </div>
                    
                    </div>
                </div>
                <div class="col-auto mt-3">
                    <button type="submit" class="btn btn-primary mb-3">Enviar</button>
                </div>
            </form>        
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>