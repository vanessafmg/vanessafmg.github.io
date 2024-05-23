<!doctype html>
<html lang="en">
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">
 <title>Cadastrar Cidade</title>
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
<form class="form-horizontal" action="cadastro_cidades.php" method="post">
<fieldset>
<!-- Form Name -->
<legend>Cadastrar Cidade</legend>
<!-- Text input-->
<div class="form-group">
<label class="col-md-4 control-label" for="nome">Cidade: <span style="color: red">*</span></label>
<div class="col-md-4">
<input id="nome" name="nome" type="text" placeholder="" class="form-control input-md" required="" maxlength="20">
</div>
</div>
<!-- Text input-->
<div class="form-group">
<label class="col-md-4 control-label" for="uf">UF: <span style="color: red">*</span></label>
<div class="col-md-4">
<input id="uf" name="uf" type="text" placeholder="" class="form-control input-md" required="" maxlength="20">
</div>
</div>
<!-- Button -->
<div class="form-group">
<label class="col-md-4 control-label" for="btnCadastrar"></label>
<div class="col-md-4">
<button id="btnCadastrar" name="btnCadastrar" class="btn btn-success">Salvar</button>
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