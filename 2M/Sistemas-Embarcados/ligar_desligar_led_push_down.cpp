// C++ code
//declaração das constantes
const int led = 8; //led no pino 8
const int botao = 7; //botão no pino 7
//variável que conterá os estados do botão (0 LOW, 1 HIGH)
int estadoBotao = 0;

//método setup, executado uma vez ao ligar o arduino
void setup()
{
  pinMode(led, OUTPUT); //pino 8 como de saída
  pinMode(botao,INPUT); //definido pino digital 7 como de entrada
}

//método loop, executado enquanto o arduino estiver ligado
void loop() 
{
  //lendo o estado do pino 7, constante botão, e atribuindo o
  //resultado a váriavel estadoBotao
  estadoBotao = digitalRead(botao);
  
  //verificando o estado do botão para definir se acenderá ou
  //apagará o led
  if (estadoBotao == HIGH){
    digitalWrite(led,HIGH); //botão pressionado acende o led
  } else {
    digitalWrite(led,LOW); //botão não pressionado apaga o led 
}
}