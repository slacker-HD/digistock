#include "DigisparkOLED.h"
#include <DigiUSB.h>

char input[200];
void setup()
{
  oled.begin();
  DigiUSB.begin();
  DigiUSB.refresh();
  oled.setCursor(0, 0);
  oled.setFont(FONT8X16);
  oled.fill(0xff);
  DigiUSB.delay(1000);
  oled.clear();
}

void loop()
{
  char content[17];
  byte line = 0;
  byte i = 0;
  while (DigiUSB.available())
  {
    content[i] = DigiUSB.read();
    i++;
    if (i == 16)
    {
      content[i]='\0';
      oled.setCursor(0, line);
      oled.println(content);
      line += 2;
      i = 0;
    }
  }
  DigiUSB.delay(1000);
  DigiUSB.refresh();
}
