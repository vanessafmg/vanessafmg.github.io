void setup()
{
  pinMode(13, OUTPUT); //LED1
}

void loop()
{
  digitalWrite(13, HIGH);
  delay(2000); // Wait for 2000 millisecond(s)
  digitalWrite(13, LOW);
  delay(2000); // Wait for 2000 millisecond(s)
}
