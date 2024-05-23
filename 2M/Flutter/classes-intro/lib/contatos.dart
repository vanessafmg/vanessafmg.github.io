class Contato {
  String nome, foto, mensagem;
  Contato({required this.nome, required this.foto, required this.mensagem});
}

List<Contato> contatos = [
  Contato(nome: 'Vanessa', foto: 'https://media.licdn.com/dms/image/D4D03AQF7dZj6QEsnwg/profile-displayphoto-shrink_200_200/0/1690318962746?e=1721865600&v=beta&t=3Vjj7LQuP4sULsV5bXC4oRpghvl4c4cMtng5Dl_zY7s', mensagem: 'Olá, eu sou a Vanessa'),
  Contato(nome: 'Erick', foto: 'https://media.licdn.com/dms/image/D4D03AQFF_sNtqqW_hQ/profile-displayphoto-shrink_800_800/0/1713756963238?e=1721865600&v=beta&t=_PYg396kWQ75j9nHY4c2up3L69MKT_WaaRD0vfQLNcA', mensagem: 'Olá, eu sou o Erick'),
  Contato(nome: 'Carol', foto: 'https://media.licdn.com/dms/image/D4D03AQH5hgx_XH-3PA/profile-displayphoto-shrink_200_200/0/1708379368882?e=1721865600&v=beta&t=uiOvkBEJae9TZgoY6-ZXnowwLsA14CL26oEPuLZvMeo', mensagem: 'Olá, eu sou a Carol'),
  Contato(nome: 'Mariano', foto: 'https://rollingstone.uol.com.br/media/uploads/cillian_murphy_como_tommy_shelby_reproducao_netflix.jpg', mensagem: 'Olá, eu sou o Mariano')
];