#EU QUERO FAZER UM COMENTÁRIO
-- EU QUERO FAZER UM COMENTÁRIO
/*EU 
QUERO
 FAZER UM 
 COMENTÁRIO*/
 
CREATE DATABASE IF NOT EXISTS ESCOLA;

USE ESCOLA;

CREATE TABLE IF NOT EXISTS ALUNOS

(ID tinyint not null auto_increment,
NOME char(50) not null,
RG char(12) not null,
CPF char(14) not null,
DATA_NASCIMENTO date not null,
ENDERECO char(50) not null,
NUMERO smallint not null,
COMPLEMENTO varchar(50),
BAIRRO char(40) not null,
ID_CIDADE smallint not null,
CEP char(10) not null,
TELEFONE1 char(12) not null,
TELEFONE2 char(12) not null,
PAI char(50) not null,
MAE char(50) not null,
PRIMARY KEY (ID)); 

CREATE TABLE IF NOT EXISTS CIDADES

(ID tinyint not null auto_increment,
NOME char(50) not null,
UF char(2) not null,
PRIMARY KEY (ID));
    
CREATE TABLE IF NOT EXISTS DISCIPLINAS
    
(ID tinyint not null auto_increment,
NOME char(50) not null,
PRIMARY KEY(ID));
    
CREATE TABLE IF NOT EXISTS BOLETINS
    
(ID tinyint not null auto_increment,
ID_ALUNO smallint not null,
ID_DISCIPLINA smallint not null,
DATA_PROVA date not null,
NOTA double(2,1),
PRIMARY KEY(ID));

INSERT INTO ALUNOS
(NOME,
RG,
CPF,
DATA_NASCIMENTO,
ENDERECO,
NUMERO,
COMPLEMENTO,
BAIRRO,
CIDADE,
CEP,
TELEFONE1,
TELEFONE2,
PAI,
MAE)
VALUES
('Gabriela da Silva',
'17.973.898-3',
'147.520.609-61',
'1979-03-26',
'Rua Angelo Zugliani',
33,
'Casa',
'Jardim Maria Luiza',
'Rio Bonito',
'10.584.471',
'29-8615-4558',
'29-8775-2452',
'Professor Josué',
'Anabela Fernandes Prado');

INSERT INTO ALUNOS
(NOME,
RG,
CPF,
DATA_NASCIMENTO,
ENDERECO,
NUMERO,
COMPLEMENTO,
BAIRRO,
CIDADE,
CEP,
TELEFONE1,
TELEFONE2,
PAI,
MAE)
VALUES
('Nacib Saad',
'22.184.157-9',
'275.213.650-63',
'1961-04-14',
'Rua Major Ascanio',
247,
'Apto.',
'Vila Brasil',
'Nova Iguaçu',
'20.125.144',
'10-1718-5110',
'29-8775-2452',
'Rômulo Vieira',
'Dona Arminda');

INSERT INTO ALUNOS
(NOME,
RG,
CPF,
DATA_NASCIMENTO,
ENDERECO,
NUMERO,
COMPLEMENTO,
BAIRRO,
CIDADE,
CEP,
TELEFONE1,
TELEFONE2,
PAI,
MAE)
VALUES
('Mundinho Falcão',
'15.486.669-3',
'221.593.349-63',
'1981-03-20',
'Rua Francisco Glicério',
1087,
'Fundos',
'Vila Buscariolo',
'Brasília',
'18.391.120',
'22-1897-4072',
'22-8649-6869',
'Chico Moleza',
'Maria Lupicínia');

INSERT INTO ALUNOS
(NOME,
RG,
CPF,
DATA_NASCIMENTO,
ENDERECO,
NUMERO,
COMPLEMENTO,
BAIRRO,
CIDADE,
CEP,
TELEFONE1,
TELEFONE2,
PAI,
MAE)
VALUES
('Manoel das Onças',
'26.230.647-2',
'356-115-460-86',
'1931-04-02',
'Rua Visconde do Rio Branco',
984,
'Casa',
'Centro',
'Ubá',
'13.133.763',
'13-5006-1895',
'13-9529-3164',
'João Fulgêncio',
'Miquelina');

INSERT INTO ALUNOS
(NOME,
RG,
CPF,
DATA_NASCIMENTO,
ENDERECO,
NUMERO,
COMPLEMENTO,
BAIRRO,
CIDADE,
CEP,
TELEFONE1,
TELEFONE2,
PAI,
MAE)
VALUES
('Coronel Coriolano',
'13.281.822-9',
'290-724-003-96',
'1933-01-27',
'Avenida do Café',
488,
'3º Andar, Nº 52',
'Vila Maria Cristina',
'Guaragi',
'28.719.415',
'28-7366-0612',
'28-8931-1282',
'Coronel Ribeirinho',
'Florzinha Reis');

INSERT INTO ALUNOS
(NOME,
RG,
CPF,
DATA_NASCIMENTO,
ENDERECO,
NUMERO,
COMPLEMENTO,
BAIRRO,
CIDADE,
CEP,
TELEFONE1,
TELEFONE2,
PAI,
MAE)
VALUES
('Maria Machadão',
'18.519.133-2',
'312,467,859-64',
'1972-05-27',
'Rua Rangel Pestana',
700,
'Bloco II',
'Vila Nova',
'Juazeiro',
'14.227.991',
'23-8564-6322',
'23-9012-8224',
'Coronel Amâncio Leal',
'Marinalva Tavares');

INSERT INTO ALUNOS
(NOME,
RG,
CPF,
DATA_NASCIMENTO,
ENDERECO,
NUMERO,
COMPLEMENTO,
BAIRRO,
CIDADE,
CEP,
TELEFONE1,
TELEFONE2,
PAI,
MAE)
VALUES
('Zarolha',
'28.180.997-2',
'223-168-731-94',
'1969-11-06',
'Rua Dr. Quinzinho',
511,
'Casa',
'Chacara Peccioli',
'Rosario do Sul',
'22.192.012',
'10-4211-8537',
'10-9128-3283',
'Negro Fagundes',
'Quinquina dos Reis');

INSERT INTO ALUNOS
(NOME,
RG,
CPF,
DATA_NASCIMENTO,
ENDERECO,
NUMERO,
COMPLEMENTO,
BAIRRO,
CIDADE,
CEP,
TELEFONE1,
TELEFONE2,
PAI,
MAE)
VALUES
('Coronel Ramiro Bastos',
'29.226.206-6',
'206.558.702.80',
'1949-04-18',
'Avenida Gustavo Chiozzi',
405,
'Subsolo',
'Jardim Netinho Prado',
'Rio de Janeiro',
'11.235.877',
'19-8340-8276',
'19-9651-4781',
'Alfredo Bastos',
'Conceição Bastos');

INSERT INTO ALUNOS
(NOME,
RG,
CPF,
DATA_NASCIMENTO,
ENDERECO,
NUMERO,
COMPLEMENTO,
BAIRRO,
CIDADE,
CEP,
TELEFONE1,
TELEFONE2,
PAI,
MAE)
VALUES
('Tonico Bastos',
'16-170-745-4',
'220-178-949-44',
'1967-02-10',
'Rua Santa Barbara',
165,
'A',
'Vila Vicente',
'Rio de Janeiro',
'26.740-878',
'25-2533-2285',
'25-9979-4499',
'Coronel Ramiro Bastos',
'Gerusa Bastos');

INSERT INTO ALUNOS
(NOME,
RG,
CPF,
DATA_NASCIMENTO,
ENDERECO,
NUMERO,
COMPLEMENTO,
BAIRRO,
CIDADE,
CEP,
TELEFONE1,
TELEFONE2,
PAI,
MAE)
VALUES
('Doroteia',
'29.510.610-5',
'102.566.825-44',
'1927-09-13',
'Rua Aristides Lobo Sobrinho',
101,
'Apto.',
'Chacara Braz Miraglia',
'São Paulo',
'13.474.853',
'12-4511-6110',
'12-8145-0515',
'Dr. Osmundo Pimentel',
'Olga Bastos');

INSERT INTO DISCIPLINAS
(NOME)
VALUES
("OSA");

INSERT INTO DISCIPLINAS
(NOME)
VALUES
("Lógica de Programação");

INSERT INTO DISCIPLINAS
(NOME)
VALUES
("IMC");

INSERT INTO DISCIPLINAS
(NOME)
VALUES
("TLBD-1");

INSERT INTO DISCIPLINAS
(NOME)
VALUES
("Organização Empresarial");

INSERT INTO BOLETINS
(ALUNO,
DISCIPLINA,
DATA,
NOTA)
VALUES
("Zarolha",
"OSA",
'2012-08-01',
5.0);

INSERT INTO BOLETINS
(ALUNO,
DISCIPLINA,
DATA,
NOTA)
VALUES
("Mundinho Falcão",
"Lógica de Programação",
'2012-06-01',
7.1);

INSERT INTO BOLETINS
(ALUNO,
DISCIPLINA,
DATA,
NOTA)
VALUES
("Mundinho Falcão",
"OSA",
'2012-03-14',
3.7);

INSERT INTO BOLETINS
(ALUNO,
DISCIPLINA,
DATA,
NOTA)
VALUES
("Maria Machadão",
"IMC",
'2012-08-20',
4.1);

INSERT INTO BOLETINS
(ALUNO,
DISCIPLINA,
DATA,
NOTA)
VALUES
("Maria Machadão",
"Lógica de Programação",
'2012-10-30',
5.0);

INSERT INTO BOLETINS
(ALUNO,
DISCIPLINA,
DATA,
NOTA)
VALUES
("Mundinho Falcão",
"TLBD-1",
'2012-08-20',
3.5);

INSERT INTO BOLETINS
(ALUNO,
DISCIPLINA,
DATA,
NOTA)
VALUES
("Tonico Bastos",
"OSA",
'2012-10-14',
4.0);

INSERT INTO BOLETINS
(ALUNO,
DISCIPLINA,
DATA,
NOTA)
VALUES
("Tonico Bastos",
"Organização Empresarial",
'2012-07-24',
7.0);

INSERT INTO BOLETINS
(ALUNO,
DISCIPLINA,
DATA,
NOTA)
VALUES
("Zarolha",
"Organização Empresarial",
'2012-05-06',
9.8);

INSERT INTO BOLETINS
(ALUNO,
DISCIPLINA,
DATA,
NOTA)
VALUES
("Tonico Bastos",
"TLBD01",
'2012-11-11',
2.3);





