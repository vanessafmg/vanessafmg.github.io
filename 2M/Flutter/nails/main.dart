import 'package:flutter/material.dart';

void main() {
  runApp(const MaterialApp(title: 'Flutter', home: MyHomePage()));
}
class Usuario { //sempre singular
  String cliente, servico, valor;
  Usuario({required this.cliente, required this.servico, required this.valor});
}

List<Usuario> usuarios = [];//sempre plural

class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key});

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(title: const Text('Nails')), 
        body: Column(children: [
          caixaCliente(),
          caixaServico(),
          caixaValor(),
          botaoInserir(),
          SizedBox(height: 300, child: lista())
        ]));
  }

  TextEditingController txtCliente = TextEditingController();
  TextEditingController txtServico = TextEditingController();
  TextEditingController txtValor = TextEditingController();

  caixaCliente(){
    return TextField(
      controller: txtCliente,
      decoration: const InputDecoration(labelText: 'Cliente'));
  }

  caixaServico(){
    return TextField(
      controller: txtServico,
      decoration: const InputDecoration(labelText: 'Serviço'));
  }

  caixaValor(){
    return TextField(
      controller: txtValor,
      decoration: const InputDecoration(labelText: 'Valor'));
  }

  botaoInserir(){
    return ElevatedButton(
      onPressed: () => incluir(), child: const Text('Inserir'));
  }

  incluir(){ 
    Usuario u = Usuario(cliente: txtCliente.text, servico:txtServico.text, valor: txtValor.text);
    usuarios.add(u);
    setState(() {});
    txtCliente.clear();
    txtServico.clear();
    txtValor.clear();
  }

  lista(){
    return ListView.builder(
      itemCount: usuarios.length,
      itemBuilder: (context, index){
        return Card(
          child: ListTile(
            onTap: () => carregaTela(index),
            leading: CircleAvatar(
              child: Text(usuarios[index].cliente.substring(0,2))),
            title: Text(usuarios[index].cliente),
            subtitle: Text(usuarios[index].servico),
            trailing: Row(mainAxisSize: MainAxisSize.min,
              children: [
                IconButton(
                    onPressed: () => alterar(index),
                    icon: const Icon(Icons.edit)),
                IconButton(
                  onPressed: () => exclui(index),
                  icon: const Icon(Icons.delete))
              ],
            ),
          ));        
      });
  }

  carregaTela(int i ){
    txtCliente.text = usuarios[i].cliente;
    txtServico.text = usuarios[i].servico;
    txtValor.text = usuarios[i].valor;
  }

  alterar(int i){
    usuarios[i].cliente = txtCliente.text;
    usuarios[i].servico = txtServico.text;
    usuarios[i].valor = txtValor.text;
    setState(() {});
    txtCliente.clear();
    txtServico.clear();
    txtValor.clear();
  }

  exclui(int i){
    usuarios.remove(usuarios[i]);
    setState(() {});
  }
}

