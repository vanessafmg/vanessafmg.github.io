// C++ code
//#define - define uma constante
#define led 13 
#define led2 12
#define botao 2
#define botao2 4


void setup()
{
  pinMode(led, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(botao, INPUT_PULLUP);
  pinMode(botao2, INPUT_PULLUP);
  
}

void loop()
{
  if (digitalRead(botao)== LOW) {
    delay(300);
    digitalWrite(led,!digitalRead(led));}

  if (digitalRead(botao2)== LOW) {
    delay(300);
    digitalWrite(led2,HIGH);}
}
