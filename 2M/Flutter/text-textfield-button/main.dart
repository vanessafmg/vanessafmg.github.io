import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

void main() {
  runApp(MaterialApp(
      title: 'Meu primeiro Aplicativo',
      home: Scaffold(
          appBar: AppBar(title: const Text('Bem-Vindo!')),
          body:  Column(
            children: [
              const Text('Nome:'),
              const TextField(keyboardType: TextInputType.text,
              maxLines:2),
              const Text('Senha:'),
              const TextField(keyboardType: TextInputType.number,
              obscureText: true, 
              textAlign: TextAlign.right,
              maxLength: 40),
              const Text('Email:'),
              const TextField(keyboardType: TextInputType.emailAddress),
              TextButton(
              onPressed: (){}, 
              child: const Text('Clique Aqui')),
              TextButton.icon(
                onPressed:(){},
                icon: const Icon(Icons.favorite), 
                label: const Text ('Favoritos'))

              




          ])
      )
  ));
}
