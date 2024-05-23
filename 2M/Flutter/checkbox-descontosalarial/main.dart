import 'dart:math';

import 'package:flutter/material.dart';

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
        appBar: AppBar(title: const Text('Descontos Salariais')), 
        body: Column(children: [
          caixaSalario(),          
          chkSaude(),
          chkAlimentacao(),
          chkSindical(),
          chkSocial(),
          btnCalcular(),
          Text(salario.toStringAsFixed(2)),
          btnLimpar(),
          
          ]));
  }
  
  
TextEditingController txtSalario = TextEditingController();

caixaSalario(){
    return TextField(
      controller: txtSalario,
      keyboardType: TextInputType.number,
      decoration: const InputDecoration(labelText: "Salário Bruto"));
  }

  bool saude = false; //variável bolean
  bool alimentacao = false;
  bool sindical = false;
  bool social = false;

  chkSaude(){
    return CheckboxListTile(
      title: const Text('Plano de Saúde - 200,00'),
      value: saude,
      onChanged: ((value) => setState(() => saude = value!))); //! é para não ter valor nulo
  }

  chkAlimentacao(){
    return CheckboxListTile(
      title: const Text('Vale Alimentação - 150,00'),
      value: alimentacao,
      onChanged: ((value) => setState(() => alimentacao = value!))); 
  }

  chkSindical(){
    return CheckboxListTile(
      title: const Text('Contribuição Sindical - 60,00'),
      value: sindical,
      onChanged: ((value) => setState(() => sindical = value!)));
}

  chkSocial(){
    return CheckboxListTile(
      title: const Text('Clube Social - 50,00'),
      value: social,
      onChanged: ((value) => setState(() => social = value!)));
}

double salario = 0;

btnCalcular(){
    return ElevatedButton(
      onPressed: () => setState((){
        salario = double.parse(txtSalario.text);
        if (saude == true) {salario -=200;}
        if (alimentacao == true) {salario -=150;}
        if (sindical == true) {salario -=60;}
        if (social == true) {salario -=50;}
      }), 
      child: const Text ('Calcular'));
}

btnLimpar(){
    return ElevatedButton(
      onPressed: () => setState((){
        txtSalario.clear();
        salario = 0;
        saude = false;
        alimentacao = false;
        sindical = false;
        social=false;
      }), 
      child: const Text ('Nova Simulação'));
}

}
