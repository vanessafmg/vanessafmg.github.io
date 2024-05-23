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
        appBar: AppBar(title: const Text('Simulação de Viagem')), 
        body: Column(children: [
          caixaDiaria(),
          caixaPessoas(),
          botaoDiaria(),
          Text('$diariatotal'),
          caixaDias(),
          caixaParcelas(),
          botaoParcela(),
          Text ('$parcela'),
          botaoLimpar()
        ])
    );
  }

  TextEditingController txtDiaria = TextEditingController();
  TextEditingController txtPessoas = TextEditingController();
  TextEditingController txtDias = TextEditingController();
  TextEditingController txtParcelas = TextEditingController();

  caixaDiaria(){
    return TextField(
      controller: txtDiaria,
      keyboardType: TextInputType.number,
      decoration: const InputDecoration(labelText: "Informe o valor da diária:"));
  }

  caixaPessoas(){
    return TextField(
      controller: txtPessoas,
      keyboardType: TextInputType.number,
      decoration: const InputDecoration(labelText: "Informe o número de pessoas:"));
  }

  double diariatotal = 0;

  calcularDiaria(){
    double diaria = double.parse(txtDiaria.text);
    int pessoas = int.parse(txtPessoas.text);
    diariatotal = diaria * pessoas;
  }

  botaoDiaria(){
    return ElevatedButton(
      onPressed: () => setState(() => calcularDiaria()), 
      child: const Text ('Calcular Diária'));
  }

  caixaDias(){
    return TextField(
      controller: txtDias,
      keyboardType: TextInputType.number,
      decoration: const InputDecoration(labelText: "Informe o número de dias"));
  }

  caixaParcelas(){
    return TextField(
      controller: txtParcelas,
      keyboardType: TextInputType.number,
      decoration: const InputDecoration(labelText: "Informe o número de parcelas"));
  }

  double parcela = 0;

  calcularParcela(){
    int dias = int.parse(txtDias.text);
    int parcelas = int.parse(txtParcelas.text);
    parcela = diariatotal * dias / parcelas;
  }

  botaoParcela(){
    return ElevatedButton(
      onPressed: () => setState(() => calcularParcela()), 
      child: const Text ('Calcular Parcela'));
  }

  limpar(){
    txtDiaria.clear();
    txtPessoas.clear();
    txtDias.clear();
    txtParcelas.clear();
    diariatotal = 0;
    parcela = 0;
  }

  botaoLimpar(){
    return ElevatedButton(
      onPressed: () => setState(() => limpar()), 
      child: const Text ('Nova Simulação'));
  }

  



   


}


