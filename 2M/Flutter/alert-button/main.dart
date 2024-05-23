import 'package:flutter/material.dart';

void main() {
  runApp(const MaterialApp(title: 'Flutter', home: MyHomePage()));
}

String nome = "";
TextEditingController txtNome = TextEditingController();

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
            ElevatedButton(onPressed: ()=> caixaMensagem(), child: const Text('Cadastro')),
            Text("O nome digitado foi: $nome")
          ])
    ));
  }

  caixaMensagem(){
    return showDialog(
      context: context, 
      builder: (context) => AlertDialog(
        title: const Text('Título'),
        content: TextField(controller: txtNome,
                decoration: const InputDecoration(labelText: "Digite o seu nome")),
        actions: [botao()]
      ));
  }

  TextButton botao()
  {
    return TextButton(
      onPressed: (){
        setState(()=> nome = txtNome.text);
        Navigator.pop(context);
         },
       child: const Text("OK"));
  }
}