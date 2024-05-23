import 'package:flutter/material.dart';

void main() {
  runApp(MaterialApp(
      title: 'Meu primeiro Aplicativo',
      home: Scaffold(
          appBar: AppBar(title: const Text('Estilizando')),
          body: Column(children: [
            TextField(decoration: InputDecoration(prefixText: 'Nome')), //alinha no começo da caixa (quando clicado)
            TextField(decoration: InputDecoration(suffixText: 'Senha')), //alinha ao final da caixa (quando clicado)
            TextField(decoration: InputDecoration(helperText: 'Digite o seu nome')),//cria indicação para o usuário
            TextField(decoration: InputDecoration(errorText: 'Erro')),//exibe msg de erro em vermelho
            TextField(decoration: InputDecoration(hintText: 'Digite o nome')), //fica o texto, some ao clicar (
            TextField(decoration: InputDecoration(hintText: 'Digite o nome',hintStyle: TextStyle(color: Colors.green))), //colore o hintText
            TextField(decoration: InputDecoration(icon:Icon(Icons.star))), //inserir icone
            TextField(decoration: InputDecoration(prefixIcon:Icon(Icons.login))), //icone no inicio
            TextField(decoration: InputDecoration(suffixIcon:Icon(Icons.login))), //icone ao final

            //BORDAS

            Padding(padding: EdgeInsets.all(20.0), //espaçamento de 20px entre a borda do cel e do componente
            child: 
            TextField(decoration:InputDecoration(border:InputBorder.none)), //sem borda
            TextField(decoration:InputDecoration(border:UnderlineInputBorder())), //borda em baixo
            TextField(decoration:InputDecoration(border:OutlineInputBorder(borderRadius: BorderRadius.all(Radius.circular(20))))), //borda ao redor arredondada
            ),


          ]
        )
    )));
}

