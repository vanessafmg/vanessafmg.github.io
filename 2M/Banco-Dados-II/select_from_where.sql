SELECT * FROM ALUNOS; /*exibir todas as colunas de toda a tabela*/

SELECT ID, NOME FROM ALUNOS; 

SELECT ID, NOME, COMPLEMENTO FROM ALUNOS 
WHERE COMPLEMENTO = "CASA"; /*= é operação relacional correspondente ao tipo de dado do campo where*/

SELECT ID, NOME FROM ALUNOS 
WHERE COMPLEMENTO = "CASA"; /*mostra apenas as pessoas, sem mostrar a informação casa*/

SELECT ID, NOME, COMPLEMENTO FROM ALUNOS 
WHERE COMPLEMENTO = "CASA" OR 
	  COMPLEMENTO = "APTO."; /*OR = ou, separação, repetir o campo-- VER QUANDO É IMPORTANTE MOSTRAR O CAMPO*/

SELECT ID, NOME, DATA_NASCIMENTO FROM ALUNOS 
WHERE DATA_NASCIMENTO = "1979-03-26" OR
	  DATA_NASCIMENTO = "1981-03-20" OR
	  DATA_NASCIMENTO = "1933-01-27" OR
	  DATA_NASCIMENTO = "1972-05-27" OR
      DATA_NASCIMENTO = "1967-02-10";
      
#IN Operador de Lista

SELECT ID, NOME, DATA_NASCIMENTO FROM ALUNOS
WHERE DATA_NASCIMENTO IN ("1979-03-26","1981-03-20","1933-01-27","1972-05-27","1967-02-10");

SELECT ID, NOME, PAI, MAE FROM ALUNOS
WHERE PAI IN ("Professor Josué", "Coronel Ramiro Bastos","Dr. Osmundo Pimentel") OR
	  MAE IN ("Maria Lupicínia", "Conceição Bastos");

