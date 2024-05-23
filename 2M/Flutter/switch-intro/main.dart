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
        appBar: AppBar(title: const Text('Flutter')), 
        body: Column(children: [swtModelo()]));
  }

  bool status = false;

  swtModelo(){
    return SwitchListTile(
      title: const Text('Status do Switch'),
      value: status,
      onChanged: ((value) => setState(() => status = value)));
    }
}