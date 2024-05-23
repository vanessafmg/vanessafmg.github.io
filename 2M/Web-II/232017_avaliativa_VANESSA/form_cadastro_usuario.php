<!doctype html>
<html lang="en">
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">
 <title>Cadastrar Usuário</title>
<link rel="stylesheet"
href="https://cdn.jsdelivr.net/npm/bootstrap@3.4.1/dist/css/bootstrap.min.css"
integrity="sha384-HSMxcRTRxnN+Bdg0JdbxYKrThecOKuH5zCYotlSAcp1+c8xmyTe9GYg1l9a69psu"
crossorigin="anonymous">
<style>
body {
padding: 20px;
}
legend {
text-align: center;
}
</style>
</head>
<body>
<form class="form-horizontal" action="cadastro_usuario.php" method="post">
<fieldset>
<!-- Form Name -->
<legend>Cadastrar Usuário</legend>
<!-- Text input-->
<div class="form-group">
<label class="col-md-4 control-label" for="usuario">Usuário <span style="color: red">*</span></label>
<div class="col-md-4">
<input id="usuario" name="usuario" type="text" placeholder="" class="form-control input-md" required="" maxlength="20">
</div>
</div>
<!-- Password input-->
<div class="form-group">
<label class="col-md-4 control-label" for="senha">Senha <span style="color: red">*</span></label>
<div class="col-md-4">
<input id="senha" name="senha" type="password" placeholder="" class="form-control input-md" required="" maxlength="20">
</div>
</div>
<!-- Text input-->
<div class="form-group">
<label class="col-md-4 control-label" for="email">E-mail <span style="color: red">*</span></label>
<div class="col-md-4">
<input id="email" name="email" type="text" placeholder="" class="form-control input-md" required="" maxlength="100">
</div>
</div>
<!-- Button -->
<div class="form-group">
<label class="col-md-4 control-label" for="btnCadastrar"></label>
<div class="col-md-4">
<button id="btnCadastrar" name="btnCadastrar" class="btn btn-success">Salvar</button>
<a href="consulta_usuarios.php" id="btnLista" name="btnLista" class="btn btn-info" role="button">Lista de Usuários</a>
</div>
</div>
</fieldset>
</form>
<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
<script src="https://code.jquery.com/jquery-1.12.4.min.js" integrity="sha384-
nvAa0+6Qg9clwYCGGPpDQLVpLNn0fRaROjHqs13t4Ggj3Ez50XnGQqc/r8MhnRDZ"
crossorigin="anonymous"></script>

<!-- Include all compiled plugins (below), or include individual files as needed -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@3.4.1/dist/js/bootstrap.min.js"
integrity="sha384-aJ21OjlMXNL5UyIl/XNwTMqvzeRMZH2w8c5cRVpzpU8Y5bApTppSuUkhZXN0VxHd"
crossorigin="anonymous"></script>

</body>
</html>