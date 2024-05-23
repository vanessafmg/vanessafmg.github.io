import 'package:flutter/material.dart';
import 'contatos.dart';

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
        body: Column(children: [Expanded(child: lista())])
    );
  }

  lista(){
    return ListView.builder(
      itemCount: contatos.length,
      itemBuilder: (context, index){
        return Card(
          child: ListTile(
            onTap: () => caixaContato(index),
            leading: CircleAvatar(backgroundImage: NetworkImage(contatos[index].foto)),
            title: Text(contatos[index].nome),
            subtitle: Text('${contatos[index].mensagem.substring(0,15)}...'),
            trailing: Row(mainAxisSize: MainAxisSize.min,
              children: [iconeMessage(index), iconeRemove(index)],
              )),
        );
      });
  }

  caixaContato(int i){
    showDialog(
      context: context,
      builder: (context) => AlertDialog(
        title: Text(contatos[i].nome),
        content: SizedBox(
          width: 350,
          height: 180,
          child: Image.network(contatos[i].foto)),
      actions: [botaoContato()]));
  }

  TextButton botaoContato(){
    return TextButton(
      onPressed: () => Navigator.pop(context), child: const Text("OK"));
  }

  caixaMensagem(int i){
    showDialog(
      context: context,
      builder: (context) => AlertDialog(
        title: CircleAvatar(minRadius: 50, maxRadius: 75,
          backgroundImage: NetworkImage(contatos[i].foto)),
        content: SizedBox(width: 350, height: 250,
          child: Column(
            children: [
              Text(contatos[i].nome),
              Text (contatos[i].mensagem),
              caixaResposta()]
            )),
        actions: [botaoMensagem()]));
  }

  TextButton botaoMensagem(){
    return TextButton(
      onPressed: () => Navigator.pop(context), child: const Text("Enviar"));
  }

  TextEditingController txtMensagem = TextEditingController();
  caixaResposta(){
    return TextField(
      controller: txtMensagem,
      maxLines: 5,
      decoration: const InputDecoration(
        border: OutlineInputBorder(),
        hintText: 'Digite aqui sua resposta'));
  }

  iconeMessage(int i){
    return IconButton(
      onPressed: () => caixaMensagem(i), icon: const Icon(Icons.message));
  }

  iconeRemove(int i){
    return IconButton(
      onPressed: (){
        contatos.remove(contatos[i]);
        setState((){});
      },
      icon: const Icon(Icons.delete));
  }
}

