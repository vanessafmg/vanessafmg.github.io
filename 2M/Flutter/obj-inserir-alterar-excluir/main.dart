import 'package:flutter/material.dart';

void main() {
  runApp(const MaterialApp(title: 'Flutter', home: MyHomePage()));
}
class Usuario { //sempre singular
  String nome, email;
  Usuario({required this.nome, required this.email});
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
        appBar: AppBar(title: const Text('Orientação a Objeto')), 
        body: Column(children: [
          caixaNome(),
          caixaEmail(),
          botaoInserir(),
          SizedBox(height: 400, child: lista())
        ]));
  }

  TextEditingController txtNome = TextEditingController();
  TextEditingController txtEmail = TextEditingController();

  caixaNome(){
    return TextField(
      controller: txtNome,
      decoration: const InputDecoration(labelText: 'Nome'));
  }

  caixaEmail(){
    return TextField(
      controller: txtEmail,
      keyboardType: TextInputType.emailAddress,
      decoration: const InputDecoration(labelText: 'Email'));
  }

  botaoInserir(){
    return ElevatedButton(
      onPressed: () => incluir(), child: const Text('Inserir'));
  }

  incluir(){ 
    Usuario u = Usuario(nome: txtNome.text, email:txtEmail.text);
    usuarios.add(u);
    setState(() {});
    txtNome.clear();
    txtEmail.clear();
  }

  lista(){
    return ListView.builder(
      itemCount: usuarios.length,
      itemBuilder: (context, index){
        return Card(
          child: ListTile(
            onTap: () => carregaTela(index),
            leading: CircleAvatar(
              child: Text(usuarios[index].nome.substring(0,2))),
            title: Text(usuarios[index].nome),
            subtitle: Text(usuarios[index].email),
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
    txtNome.text = usuarios[i].nome;
    txtEmail.text = usuarios[i].email;
  }

  alterar(int i){
    usuarios[i].nome = txtNome.text;
    usuarios[i].email = txtEmail.text;
    setState(() {});
    txtNome.clear();
    txtEmail.clear();
  }

  exclui(int i){
    usuarios.remove(usuarios[i]);
    setState(() {});
  }
}

