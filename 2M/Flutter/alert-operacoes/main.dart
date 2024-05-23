import 'package:flutter/material.dart';
import 'package:flutter/services.dart';


void main() {
  runApp(const MaterialApp(title: 'Flutter', home: MyHomePage()));
}


TextEditingController txtValor1 = TextEditingController();
TextEditingController txtValor2 = TextEditingController();

    double resultado = 0;
  
    double n1 = double.parse(txtValor1.text);
    double n2 = double.parse(txtValor2.text);

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
        body: Center(
          child: Column(children: [
            caixaValor1(),
            caixaValor2(),
            const SizedBox(height: 15),
            ElevatedButton(onPressed: ()=> caixaOperacao(), child: const Text('Selecione a operação')),
            const SizedBox(height: 15),
            botaoLimpar(),
            const SizedBox(height: 15),
            Text(resultado.toStringAsFixed(2)),
            const SizedBox(height: 15),
            botaoFechar(),
          ])
    ));
  }

  caixaValor1(){
    return TextField(
      controller: txtValor1,
      keyboardType: TextInputType.number,
      decoration: const InputDecoration(labelText: "Primeiro Valor"));
  }

  caixaValor2(){
    return TextField(
      controller: txtValor2,
      keyboardType: TextInputType.number,
      decoration: const InputDecoration(labelText: "Segundo Valor"));
  }

  caixaOperacao(){
    return showDialog(
      context: context, 
      builder: (context) => AlertDialog(
        title: const Text('Calculadora'),
        content: const Text ("Selecione uma das operações"),
        actions: [botaoSoma(), botaoSubtracao(), botaoMultiplicacao(), botaoDivisao()]
      ));
  }
   
   somar(){ resultado = n1 + n2;}
   subtrair(){ resultado = n1 - n2;}
   multiplicar(){ resultado = n1 * n2;}
   dividir(){ resultado = n1 / n2;}

  ElevatedButton botaoSoma()
  {
    return ElevatedButton(
      onPressed: (){
        setState(()=> somar());
        Navigator.pop(context);
         },
       child: const Text("+"));
  }

  ElevatedButton botaoSubtracao()
  {
    return ElevatedButton(
      onPressed: (){
        setState(()=> subtrair());
        Navigator.pop(context);
         },
       child: const Text("-"));
  }

  ElevatedButton botaoMultiplicacao()
  {
    return ElevatedButton(
      onPressed: (){
        setState(()=> multiplicar());
        Navigator.pop(context);
         },
       child: const Text("*"));
  }

  ElevatedButton botaoDivisao()
  {
    return ElevatedButton(
      onPressed: (){
        setState(()=> dividir());
        Navigator.pop(context);
         },
       child: const Text("/"));
  }

  limpar(){ 
    txtValor1.clear();
    txtValor2.clear();
    resultado = 0;
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