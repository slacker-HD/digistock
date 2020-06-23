#include "DigisparkOLED.h"
#include <DigiUSB.h>

char input[200];
void setup()
{
  oled.begin();
  oled.clear();
  DigiUSB.begin();
  delay(1000);
  oled.setCursor(0, 0);
  oled.setFont(FONT8X16);
  oled.clear();
  DigiUSB.delay(10000);
}

void loop()
{
  char p[11];
  byte i = 0;
  while (DigiUSB.available())
  {
    p[i] = DigiUSB.read();
    i++;
    if (i > 10)
      break;
  }
  if (i < 11)
    p[i] = '\0';

  oled.setCursor(0, 0);
  oled.print(p);
  DigiUSB.delay(1000);
  DigiUSB.refresh();
}
