import 'package:flutter/material.dart';

void main() {
  runApp(const MaterialApp(title: 'Flutter', home: MyHomePage()));
}

class Aluno{ //classe de modelagem aluno
  String curso, nome, cidade;
  Aluno({required this.curso, required this.nome, required this.cidade});
}

List<Aluno> alunos = [ //array de objetos que armazena dados do tipo alunos
  Aluno (curso: 'DS', nome: 'JOAO', cidade:'JAU'),
  Aluno (curso: 'AD', nome: 'MARIA', cidade:'BAURU'),
  Aluno (curso: 'NT', nome: 'JOANA', cidade:'ITAPUI'),
  Aluno (curso: 'ME', nome: 'PEDRO', cidade:'BARIRI'),
  Aluno (curso: 'EL', nome: 'JOSE', cidade:'JAU'),
  Aluno (curso: 'DS', nome: 'ANTONIO', cidade:'BOCAINA'),
];

class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key});

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(title: const Text('ListView - Objeto')), 
        body: lista());
  }

  lista(){
    return ListView.builder(
      itemCount:alunos.length,
      itemBuilder: (context,index){
        return ListTile(
          onTap: () => caixaMensagem(alunos[index].curso, alunos[index].nome, alunos[index].cidade),
          leading: CircleAvatar(child: Text(alunos[index].curso)),
          title: Text(alunos[index].nome),
          subtitle: Text(alunos[index].cidade),
        );
      });
  }

  caixaMensagem(String curso, String nome, String cidade){
    return showDialog(context: context, 
    builder: (context) => AlertDialog(
      title: const Text('Dados'),
      content: Text('Curso: $curso \nNome: $nome \nCidade: $cidade'),
      actions: [botao()],
    ));
  }

  botao(){
    return TextButton(
      onPressed: () => Navigator.pop(context), child: const Text('OK'));
  }
}