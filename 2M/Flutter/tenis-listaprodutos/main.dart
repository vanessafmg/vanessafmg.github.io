import 'package:flutter/material.dart';

void main() {
  runApp(const MaterialApp(title: 'Flutter', home: MyHomePage()));
}

class Produto{
  String nome, foto;
  double valor;
  Produto({required this.nome, required this.foto, required this.valor});
}

List<Produto> produtos = [
  Produto(nome: 'Tenis Nike', foto: 'https://trilhaesportes.fbitsstatic.net/img/p/tenis-nike-air-zoom-pegasus-39-feminino-rosa-branco-71232/267411-1.jpg?w=800&h=800&v=no-value', valor: 700),
  Produto(nome: 'Tenis Adidas', foto: 'https://static.lojadointer.com.br/produtos/tenis-adidas-asweerun-feminino/18/NQQ-0371-018/NQQ-0371-018_zoom1.jpg?ts=1692823246&ims=544x', valor: 500),
  Produto(nome: 'Tenis Vans', foto: 'https://static.rockcity.com.br/public/rockcity/imagens/produtos/thumbs/tenis-vans-ultrarange-rapidweld-rose-cloud-rosa-47699.jpg', valor: 600),
  Produto(nome: 'Tenis Everlast', foto: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6HP9rsD9vFbxfgqxLKeZUqIuC_cdTfrKIJHMUbux_cQ&s', valor: 400),
];

List<TextEditingController> txtQtde = [];
double total = 0;

class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key});

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(title: const Text('Seu tênis é aqui')), 
        body: Column(
          children: [
            SizedBox(height: 500, child: lista()),
            Text('Total do Pedido: $total', style: const TextStyle(fontSize: 25))
          ])
    );
  }

  lista(){
    return ListView.builder(
      itemCount: produtos.length,
      itemBuilder: (context,index){
        txtQtde.add(TextEditingController());
        return Card(
          child: ListTile(
            leading: Image.network(produtos[index].foto),
            title: Text(produtos[index].nome),
            subtitle: Text(produtos[index].valor.toString()),
            trailing: Row(mainAxisSize: MainAxisSize.min,
                children: [caixaQtde(index), iconeAdd(index), IconButton(
                  onPressed: () => exclui(index),
                  icon: const Icon(Icons.delete))],
            )),
    );      
    }
    );
  }

  caixaQtde(int i){
    return SizedBox(width: 50,
    child: TextField(controller: txtQtde[i],
    keyboardType: TextInputType.number,
    decoration: const InputDecoration(border: OutlineInputBorder()),
    textAlign: TextAlign.center));
  }

  iconeAdd(int i){
    return IconButton(
      onPressed: (){
        if (txtQtde[i].text == '') return;
        total += produtos[i].valor * int.parse(txtQtde[i].text);
        txtQtde[i].clear();
        setState(() {});
      },
      icon: const Icon(Icons.add_shopping_cart),
    );
  }

  exclui(int i){
    produtos.remove(produtos[i]);
    setState(() {});
  }
}

