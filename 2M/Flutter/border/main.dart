import 'package:flutter/material.dart';

void main() {
  runApp(MaterialApp(
      title: 'Meu primeiro Aplicativo',
      home: Scaffold(
          appBar: AppBar(title: const Text('Estilizando')),
          body: Column(children: [
           

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

