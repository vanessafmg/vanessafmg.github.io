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
        appBar: AppBar(title: const Text('Alert')), 
        body: Center(
          child: ElevatedButton(
            onPressed: ()=>caixaMensagem(),
            child: const Text('Mensagem'))));
  }

  caixaMensagem(){
    return showDialog(
      context: context,
      builder: (context) => AlertDialog(
        shape: const RoundedRectangleBorder(borderRadius: BorderRadius.all(Radius.circular(20))), //mudar tamanho da borda
        title: const Text('Cadastro'), //titulo da caixa
        content: const SizedBox(height: 130, //define altura da caixa
        child: Column(children: [
            TextField(decoration: InputDecoration(labelText: "Digite o seu nome")),
            TextField(decoration: InputDecoration(labelText: "Digite o seu curso"))])),  //const Text("Conteúdo"), //corpo da caixa
        actions: [botao1(),botao2()] 
      ));
    }

    

    ElevatedButton botao1()
    {
      return ElevatedButton(onPressed: () => Navigator.pop(context),child: const Text("OK")); //opções dos botões - navigator.pop fecha caixa
    }

     TextButton botao2()
    {
      return TextButton(onPressed: () => Navigator.pop(context),child: const Text("CANCELAR")); //opções dos botões - navigator.pop fecha caixa
    }
}

