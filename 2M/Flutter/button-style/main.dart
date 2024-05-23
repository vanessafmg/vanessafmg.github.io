import 'package:flutter/material.dart';

void main() {
  runApp(MaterialApp(
      title: 'Meu primeiro Aplicativo',
      home: Scaffold(
          appBar: AppBar(title: const Text('Estilizando')),
          body: Center(
            child: ElevatedButton(onPressed: (){},
            style ElevatedButton.styleFrom(
              elevation:20,
              foregroundColor: Colors.yellow,
              backgroundColor: Colors.red,
              shadowColor: Colors.green,
              padding: const EdgeInsets.all(30),
              fixedSize: const Size (200,200)
            )
              child: const Text('Botão Flutter'),
            )
            
            
            )
            

          ]
        )
    )));
}

