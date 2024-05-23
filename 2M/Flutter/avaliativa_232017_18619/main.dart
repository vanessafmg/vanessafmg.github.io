import 'package:flutter/material.dart';

TextEditingController txtPeso = TextEditingController();
TextEditingController txtAltura = TextEditingController();
TextEditingController txtImc = TextEditingController();
TextEditingController txtResultado = TextEditingController();

double imc = 0;

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
      body: Column(
        children: [
          ElevatedButton(
            onPressed: () => caixaDados(),
            child: const Text('Inserir Dados'),
          ),
          Text("Peso: ${txtPeso.text}"),
          Text("Altura: ${txtAltura.text}"),
          Text("IMC: ${txtImc.text}"),
          Text('Situação: ${txtResultado.text}'),
          botaoLimpar(),
          botaoFechar(),
          SizedBox(height: 250, width: 500, child: Image.asset("imagem/tabela.png")),
        ],
      ),
    );
  }

  calcularimc() {
    double peso = double.parse(txtPeso.text);
    double altura = double.parse(txtAltura.text);  

    setState(() {
      imc = peso / (altura * altura);
      txtImc.text = imc.toStringAsFixed(2); // Fixa exibição de 2 casas decimais

      if (imc > 30) {
        txtResultado.text = "Obesidade";
      } else if (imc >= 25) {
        txtResultado.text = "Sobrepeso";
      } else if (imc >= 18.5) {
        txtResultado.text = "Normal";
      }
      else {
        txtResultado.text = "Baixo peso";
      }
    });
  }

  ElevatedButton botaoCalcular() {
    return ElevatedButton(
      onPressed: () {
        calcularimc();
        Navigator.pop(context); // Fecha o diálogo após calcular o IMC
      },
      child: const Text("CALCULAR"),
    );
  }

  caixaDados() {
    return showDialog(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Informe os Dados'),
        content: SizedBox(
          height: 130,
          child: Column(
            children: [
              TextField(
                controller: txtPeso,
                decoration: const InputDecoration(labelText: "Digite o seu peso"),
              ),
              TextField(
                controller: txtAltura,
                decoration: const InputDecoration(labelText: "Digite a sua altura"),
              ),
            ],
          ),
        ),
        actions: [botaoCalcular()],
      ),
    );
  }

  limpar(){ 
    txtPeso.clear();
    txtAltura.clear();
    txtImc.clear();
    txtResultado.clear();
    imc = 0;
  }

   botaoLimpar(){
    return ElevatedButton(
      onPressed: () => setState(() => limpar()), 
      child: const Text ('Limpar'));
  }
  
  fechar(){
    Navigator.pop(context);
  }

  botaoFechar(){
    return ElevatedButton(
      onPressed: () => setState(() => fechar()), 
      child: const Text ('Fechar'));
  } 
}