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
        appBar: AppBar(title: const Text('Flutter')), 
        body: Column(children: [
          caixaVeiculo(),
          rdbFlex(),
          rdbGNV(),
          rdbMoto(),
          rdbEletrico(),
          btnIPVA(),
          Text('Valor do IPVA: $ipva'),
          btnLimpar(),
        ])
    );
  }

   TextEditingController txtVeiculo = TextEditingController();

 
  double ipva = 0;
  double valorcarro=0;
  int tipoveic = 1;

  caixaVeiculo(){
    return TextField(
      controller: txtVeiculo,
      keyboardType: TextInputType.number,
      decoration: const InputDecoration(labelText: "Informe o valor do veículo"));
  }

  List<String> listagem = [
    'Carro Flex - 4%',
    'GNV - 1,5%',
    'Moto - 2%',
    'Elétrico - 0,5%',
  ];

  rdbFlex(){
    return RadioListTile(
      title: Text(listagem[0]),
      value: 0,
      groupValue: tipoveic,
      onChanged: ((value)=> setState(() => tipoveic = value!)));
  }

  rdbGNV(){
    return RadioListTile(
      title: Text(listagem[1]),
      value: 1,
      groupValue: tipoveic,
      onChanged: ((value)=> setState(() => tipoveic = value!)));
  }

  rdbMoto(){
    return RadioListTile(
      title: Text(listagem[2]),
      value: 2,
      groupValue: tipoveic,
      onChanged: ((value)=> setState(() => tipoveic = value!)));
  }

  rdbEletrico(){
    return RadioListTile(
      title: Text(listagem[3]),
      value: 3,
      groupValue: tipoveic,
      onChanged: ((value)=> setState(() => tipoveic = value!)));

  }


  btnIPVA(){
    return ElevatedButton(
      onPressed: () => setState((){
      valorcarro = double.parse(txtVeiculo.text);  
  
       if (tipoveic == 0) {ipva = valorcarro * 0.04;}
       if (tipoveic == 1) {ipva = valorcarro * 0.015;}
       if (tipoveic == 2) {ipva = valorcarro * 0.02;}
       if (tipoveic == 3) {ipva = valorcarro * 0.005;}
    }), 
      child: const Text ('Calcular IPVA'));
  }

  btnLimpar(){
    return ElevatedButton(
      onPressed: () => setState((){
        txtVeiculo.clear();
        ipva = 0;
        tipoveic = 0;
        valorcarro = 0;

        }), 
      child: const Text ('Novo Cálculo'));
  }
}


