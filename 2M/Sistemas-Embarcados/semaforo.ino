void setup()
{
  pinMode(13, OUTPUT); //LED1
  pinMode(12, OUTPUT); //LED2
  pinMode(11, OUTPUT); //LED3
}

void loop()
{
  digitalWrite(13, HIGH);
  delay(2000); // Wait for 2000 millisecond(s)
  digitalWrite(13, LOW);
  delay(2000); // Wait for 2000 millisecond(s)

  digitalWrite(12, HIGH);
  delay(2000); // Wait for 2000 millisecond(s)
  digitalWrite(12, LOW);
  delay(2000); // Wait for 2000 millisecond(s)

  digitalWrite(11, HIGH);
  delay(2000); // Wait for 2000 millisecond(s)
  digitalWrite(11, LOW);
  delay(2000); // Wait for 2000 millisecond(s)
}
