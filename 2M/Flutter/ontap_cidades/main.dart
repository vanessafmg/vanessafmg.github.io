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
      
      List<String> cidades = ['JAU', 'BAURU', 'BARIRI'];

    return Scaffold(
        appBar: AppBar(title: const Text('Flutter')), 
        body: ListView.builder(
          itemCount: cidades.length,
          itemBuilder: (context, index){            
            return Card(
              child: ListTile(
                onTap: () => showAlertDialog(context, cidades[index]),
                title: Text(cidades[index])));
          }
    ));
  }

  showAlertDialog(BuildContext context, String cidade){
    Widget okButton = TextButton(
      child: const Text("OK"),      
      onPressed: () => Navigator.pop(context));
    showDialog(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Dados'),
        content: Text("Cidade selecionada: $cidade"),
        actions: [okButton],
      ));
  }


}

