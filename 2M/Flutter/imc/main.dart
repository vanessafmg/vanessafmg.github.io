import 'package:flutter/material.dart';

TextEditingController txtPeso = TextEditingController();
TextEditingController txtAltura = TextEditingController();
TextEditingController txtImc = TextEditingController();
TextEditingController txtResultado = TextEditingController();

void main() {
  runApp(MaterialApp(
      title: 'Meu primeiro Aplicativo',
      home: Scaffold(
          appBar: AppBar(title: const Text('Cálculo do IMC')),
          body: 
          Column(children: [

            TextField(controller: txtPeso, keyboardType: TextInputType.number, decoration: const InputDecoration(labelText: "Digite o seu peso")),
            TextField(controller: txtAltura, keyboardType: TextInputType.number, decoration: const InputDecoration(labelText: "Digite a sua altura")),
            ElevatedButton(onPressed: ()=> calcularimc(), child: const Text("Calcular IMC")),
            TextField(controller: txtImc, readOnly: true, decoration: const InputDecoration(labelText: "IMC")),
            TextField(controller: txtResultado, readOnly: true, decoration: const InputDecoration(labelText: "Resultado")),
            ElevatedButton(onPressed: ()=>limpar(), child: const Text("Limpar")),

          ]
        )

    )));
}

calcularimc(){
  double peso = double.parse(txtPeso.text);
  double altura = double.parse(txtAltura.text);
  double imc = peso / (altura*altura);
  txtImc.text = imc.toStringAsFixed(2); //fixa exibição de 2 casas decimais
 
  if (imc > 40) {
    txtResultado.text = "Obesidade Grau III";
  } else if (imc >= 35) {
    txtResultado.text = "Obesidade Grau II";
  } else if (imc >= 30) {
    txtResultado.text = "Obesidade Grau I";
  } else if (imc >= 25) {
    txtResultado.text = "Acima do peso";
  } else if (imc >= 18.5) {
    txtResultado.text = "Peso normal";
  } else if (imc >= 17) {
    txtResultado.text = "Abaixo do peso";
  } else {
    txtResultado.text = "Muito abaixo do peso";
  }

}
  
limpar(){
  txtPeso.clear();
  txtAltura.clear();
  txtImc.clear();
  txtResultado.clear();
}


