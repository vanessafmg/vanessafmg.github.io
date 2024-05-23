import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

void main() {
  runApp(const MaterialApp(title: 'Flutter', home: MyHomePage()));
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key});

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(title: const Text('Flutter')), 
        body: Column(children: [
          caixaN1(),
          caixaN2(),
          botaoCalcular(),
          Text('$resultado'),
          botaoLimpar()
        ])
    );
  }

  TextEditingController txtN1 = TextEditingController();
  TextEditingController txtN2 = TextEditingController();

  caixaN1(){
    return TextField(
      controller: txtN1,
      keyboardType: TextInputType.number,
      decoration: const InputDecoration(labelText: "Digite o primeiro valor"));
  }

  caixaN2(){ //return serve para retornar as configurações, pois é uma função do tipo textField
    return TextField(
      controller: txtN2,
      keyboardType: TextInputType.number,
      decoration: const InputDecoration(labelText: "Digite o segundo valor"));
  }

  double resultado = 0;

  calcular(){
    double n1 = double.parse(txtN1.text);
    double n2 = double.parse(txtN2.text);
    resultado = n1 + n2;
  }

  limpar (){ //não precisa de return, pois apenas executa a função
    txtN1.clear();
    txtN2.clear();
    resultado = 0;
  }

  botaoCalcular(){
    return ElevatedButton(onPressed: () => setState(() => calcular()),
    child: const Text('Calcular'));
  }

  botaoLimpar(){
    return ElevatedButton(onPressed: () => setState(() => limpar ()),
    child: const Text('Limpar'));
  }


}


