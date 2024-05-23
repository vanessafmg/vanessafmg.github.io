// C++ code
//
/*
  Motor DC com botão, quando o botão é pressionado
  o motor DC funciona durante 50 segundos, caso o
  botão não seja pressionado o motor não
  funcionará.
*/

void setup()
{
  pinMode(12, INPUT);
  pinMode(A0, OUTPUT);
}

void loop()
{
  // Dentro desta condição SE, é programado que se o
  // pino do botão for alto, o motor funcionará por
  // durante 5s e depois parará. Caso o botão seja
  // baixo, o motor não funciona.
  if (digitalRead(12) == 1) {
    digitalWrite(A0, HIGH);
    delay(50000); // Wait for 5000 millisecond(s)
  } else {
    digitalWrite(A0, LOW);
  }
}