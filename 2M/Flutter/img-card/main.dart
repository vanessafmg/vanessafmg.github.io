import 'package:flutter/material.dart';

void main() {
  runApp(const MaterialApp(title: 'Flutter', home: MyHomePage()));
}

class Produto{ //classe de modelagem aluno
  String imagem, nome, valor, carrinho;
  Produto({required this.imagem, required this.nome, required this.valor, required this.carrinho});
}

List<Produto> produtos = [
  Produto (imagem: 'https://i0.wp.com/www.mamaeplugada.com.br/wp-content/uploads/2016/05/papinha-de-ma%C3%A7a.png?w=418&ssl=1', nome: 'Maçã', valor:'3.58', carrinho: ''),
  Produto (imagem: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ50-qHoKYgqEjdB-a7Uqmj282qwo5rAtp_XS1zl0LUlw&s', nome: 'Banana', valor:'5.15', carrinho: ''),
  Produto (imagem: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcShxuMP-npM82Fhsx14ippObCsthFhMC8M9c2oJYKeufA&s', nome: 'Melancia', valor:'3.46', carrinho: ''),
  Produto (imagem: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRGkpETH_p5j_PsATouoRMYgnxnQLyWEFlOGhbh28CGvQ&s', nome: 'Laranja', valor:'2.29', carrinho: ''),
  Produto (imagem: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSUqTuJo4PWQJp-UBo3-pJxt1npbgioukV3l_eK4etCvA&s', nome: 'Abacaxi', valor:'4.92', carrinho: ''),
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
        appBar: AppBar(title: const Text('Produtos')), 
        body: lista());
  }

  Widget lista(){
    return ListView.builder(
      itemCount:produtos.length,
      itemBuilder: (context,index){
        return Card(
          child: ListTile(          
            onTap: () => caixaMensagem(produtos[index].nome, produtos[index].imagem, produtos[index].valor),
            leading: CircleAvatar(backgroundImage: NetworkImage(produtos[index].imagem)),
            title: Text(produtos[index].nome),
            subtitle: Text(produtos[index].valor),
            trailing: Icon(Icons.shopping_cart)),
        );
      });
  }

  caixaMensagem(String nome, String imagem, String valor) {
  return showDialog(
    context: context,
    builder: (context) => AlertDialog(
      title: Text(nome),
      content: Column(
        mainAxisSize: MainAxisSize.min,
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          SizedBox(
            width: 200,
            height: 200,
            child: Image.network(imagem,              
              fit: BoxFit.cover, 
              // Ajuste para cobrir todo o espaço disponível
            ),
          ),
          SizedBox(height: 8),
          Text('Valor: $valor'),
        ],
      ),
      actions: [
        botao(),
      ],
    ),
  );
}

  botao(){
    return TextButton(
      onPressed: () => Navigator.pop(context), child: const Text('OK'));
  }
}