import 'package:flutter/material.dart';

var rotulo1 = const Text('Digite o primeiro valor');
var rotulo2 = const Text('Digite o segundo valor');
var rotulo3 = const Text ('Resultado');

var caixa1 = const TextField(keyboardType: TextInputType.number);
var caixa2 = const TextField(keyboardType: TextInputType.number);

void main() {
  runApp(MaterialApp(
      title: 'Meu primeiro Aplicativo',
      home: Scaffold(
          appBar: AppBar(title: const Text('Texto da barra de título')),
          body: 
            Column(children: [
              rotulo1,
              caixa1,
              rotulo2,
              caixa2,
              ElevatedButton(onPressed: (){}, child: const Text ('Calcular')),
              ElevatedButton(onPressed: (){}, child: const Text ('Limpar')),
              rotulo3,
              const TextField(enabled:false),

            ],
            ),
            


      )
  ));
}
