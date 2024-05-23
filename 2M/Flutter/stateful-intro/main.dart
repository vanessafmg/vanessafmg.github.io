import 'package:flutter/material.dart';

void main() { //metodo principal, apenas um, start no app
  runApp(const MaterialApp(title: 'Flutter', home: MyHomePage()));
}

class MyHomePage extends StatefulWidget { //ctrl. antes do class converte a class de stateless (estática) para stateful(dinâmica) 
//ou vice-versa - é uma pág.
  const MyHomePage({super.key});

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

int cont = 0;

class _MyHomePageState extends State<MyHomePage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(title: const Text('Flutter')), 
        body: Column(children: [
          Text('$cont'),
          ElevatedButton(
            onPressed: () => setState(() => cont++), //setState recompila a página atualizando o contador
            child: const Text('Somar'))
        ])
    );
  }
}


