import 'package:flutter/material.dart';

//cria a váriavel estilo e aplica em todos os lugares em que desejar
var estilo = const TextStyle( //constante
    fontSize: 30, //tamanho da fonte 30 pixels
    fontWeight: FontWeight.bold, //deixa fonte em negrito
    fontStyle: FontStyle.italic, //deixa fonte em itálico
    color: Colors.blue, //muda a cor d texto
    decoration: TextDecoration.underline, //sublinha o texto
    decorationColor: Colors.red, //cor do sublinhado
    height: 4, //altura do texto como sendo 4 vezes o tamanho da letra (caixa do texto)
    backgroundColor: Colors.yellow);//cor do fundo


void main() {
  runApp(MaterialApp(
      title: 'Meu primeiro Aplicativo',
      home: Scaffold(
          appBar: AppBar(title: const Text('Estilizando')),
          body: Column(children: [
            Text('Estilo em Text', style: estilo),      
          ]
        )
    )));
}

