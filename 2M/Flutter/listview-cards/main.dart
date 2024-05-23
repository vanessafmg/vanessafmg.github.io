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
List<String> nomes = ['MARIA', 'JOÃO', 'ANTONIO', 'PAULO', 'PEDRO', 'MARCOS'];

  @override
    Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(title: const Text('Flutter')), 
        body: ListView.builder(
          itemCount: nomes.length,
          itemBuilder: (context, index){
            String initials = nomes[index].substring(0, 2).toUpperCase();
            return Card(
              child: ListTile(
                leading: CircleAvatar(backgroundColor: Colors.blue,
                child: Text(initials,
                style: const TextStyle(color: Colors.white), 
                    ),),
              title: Text(nomes[index]),
              trailing: const Icon(Icons.more_vert),),
            );
          }
    ));
  }
}

