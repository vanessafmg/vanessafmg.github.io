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
        appBar: AppBar(title: const Text('Revisão do Veículo')), 
        body: Column(children: [
          swtAlinhamento(),
          swtBalanceamento(),
          swtOleo(),
          swtFiltro(),
          swtFreio(),
           Text('Total da Revisão: ' + revisao.toStringAsFixed(2)),
          btnLimpar()
        
        
        
        ]));
  }

  bool alinhamento= false, balanceamento = false, oleo = false, filtro=false, freio= false;
  double revisao = 0;

  swtAlinhamento(){
    return SwitchListTile(
      title: const Text('Alinhamento - 90,00'),
      value: alinhamento,
      onChanged: ((value) => setState((){ 
        alinhamento = value;
        if (alinhamento == true) {revisao += 90;} 
        else {revisao -= 90;}})));
    }

    swtBalanceamento(){
    return SwitchListTile(
      title: const Text('Balanceamento - 60,00'),
      value: balanceamento,
      onChanged: ((value) => setState((){ 
        balanceamento = value;
        if (balanceamento == true) {revisao += 60;} 
        else {revisao -= 60;}})));
    }

    swtOleo(){
    return SwitchListTile(
      title: const Text('Troca de Óleo - 240,00'),
      value: oleo,
      onChanged: ((value) => setState((){ 
        oleo = value;
        if (oleo == true) {revisao += 240;} 
        else {revisao -= 240;}})));
    }

     swtFiltro(){
    return SwitchListTile(
      title: const Text('Troca de Filtro - 80,00'),
      value: filtro,
      onChanged: ((value) => setState((){ 
        filtro = value;
        if (filtro == true) {revisao += 80;} 
        else {revisao -= 80;}})));
    }

    swtFreio(){
    return SwitchListTile(
      title: const Text('Pastilha de Freio - 200,00'),
      value: freio,
      onChanged: ((value) => setState((){ 
        freio = value;
        if (freio == true) {revisao += 200;} 
        else {revisao -= 200;}})));
    }
    

    btnLimpar(){
    return ElevatedButton(
      onPressed: () => setState((){
        revisao = 0;
        alinhamento = false;
        balanceamento = false;
        oleo = false;
        filtro=false;
        freio=false;
      }), 
      child: const Text ('Nova Revisão'));
}
       
}


