#include "DigisparkOLED.h"
#include <DigiUSB.h>
#include "hanzi.h"
byte refreshtime = 0;
bool needDrawimg = false;
void setup()
{
  oled.begin();
  DigiUSB.begin();
  DigiUSB.refresh();
  oled.setCursor(0, 0);
  oled.fill(0x00);
  oled.setCursor(0, 0);
  oled.println(F("WAITING FOR"));
  oled.setCursor(10, 4);
  oled.println(F("CONNECTING..."));
}

void loop()
{
  char content[17];
  byte line = 0;
  byte i = 0;
  while (DigiUSB.available())
  {
    refreshtime++;
    if (refreshtime > 200)
    {
      refreshtime = 0;
      oled.fill(0x00);
    }
    content[i] = DigiUSB.read();
    i++;
    if (i == 16)
    {
      if (line == 0 && content[4] == '-' )
      {
        needDrawimg = true;
      }
      content[i] = '\0';
      oled.setCursor(0, line);
      oled.println(content);
      line += 2;
      i = 0;
    }
  }
  if ( needDrawimg == true)
  {
    oled.bitmap(0, 2, 60, 8, zhishu);
    needDrawimg = false;
  }

  DigiUSB.delay(1000);
  DigiUSB.refresh();
}
