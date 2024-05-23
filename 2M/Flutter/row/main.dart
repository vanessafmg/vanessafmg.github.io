import 'package:flutter/material.dart';

TextEditingController txtN1 = TextEditingController();
TextEditingController txtN2 = TextEditingController();
TextEditingController txtResultado = TextEditingController();

void main() {
  runApp(MaterialApp(
      title: 'Meu primeiro Aplicativo',
      home: Scaffold(
          appBar: AppBar(title: const Text('Operações matemáticas')),
          body: 
          Column(children: [

            const Text("Digite o primeiro valor"),
            TextField(controller: txtN1, keyboardType: TextInputType.number),
            const Text("Digite o segundo valor"),
            TextField(controller: txtN2, keyboardType: TextInputType.number),
            Row( //ctrl . remove widget row ou wrap row, retorna em row
              children: [
                ElevatedButton(onPressed: ()=> somar(), child: const Text("Somar")),
                ElevatedButton(onPressed: ()=> subtrair(), child: const Text("Subtrair")),
                ElevatedButton(onPressed: ()=> multiplicar(), child: const Text("Multiplicar")),
                ElevatedButton(onPressed: ()=> dividir(), child: const Text("Dividir")),
            ],),
            const Text("Resultado"),
            TextField(controller: txtResultado, readOnly: true),
            ElevatedButton(onPressed: ()=>limpar(), child: const Text("Limpar")),

          ]
        )

    )));
}

somar(){
  int n1 = int.parse(txtN1.text);
  int n2 = int.parse(txtN2.text);
  int resultado = n1+n2;
  txtResultado.text = resultado.toString();
}
subtrair (){
  int n1 = int.parse(txtN1.text);
  int n2 = int.parse(txtN2.text);
  int resultado = n1-n2;
  txtResultado.text = "$resultado"; //faz a mesma função do toString
}
multiplicar (){
  int n1 = int.parse(txtN1.text);
  int n2 = int.parse(txtN2.text);
  int resultado = n1*n2;
  txtResultado.text = "$resultado";
}
dividir (){
  double n1 = double.parse(txtN1.text);
  double n2 = double.parse(txtN2.text);
  double resultado = n1/n2;
  txtResultado.text = "$resultado";
}
limpar (){
  txtN1.clear();
  txtN2.clear();
  txtResultado.clear();
}


