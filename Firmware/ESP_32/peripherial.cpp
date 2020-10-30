#include <EEPROM.h>
#include "peripherial.h"
String ssidST = "ssid";
String passwordST = "pass";
static void fnWriteEepromString(unsigned int addr, String value)
{
  byte lenValue = value.length();
  EEPROM.write(addr, lenValue);
  for (byte i = 0; i < lenValue; i++)
  {
    EEPROM.write(addr + 1 + i, byte(value[i]));
  }
}

static String fnReadEepromString(unsigned int addr)
{
  String strTemp = "";
  byte lenStr = EEPROM.read(addr);
  for (byte i = 0; i < lenStr; i++)
  {
    strTemp  += (char)EEPROM.read(addr + 1 + i);
  }
  return strTemp;
}

void NVS_FLASH_INIT(int len){
    EEPROM.begin(len);
}

void fnreadEepromWifi()
{
  byte lenSsid = EEPROM.read(ARRD_SSID_ST);
  if (lenSsid > 0 && lenSsid < 50)
  {
     ssidST= fnReadEepromString(ARRD_SSID_ST);
  }
  else ssidST = "0";
#ifdef DEBUG
  ssidST = "0";
#endif
  byte lenPass = EEPROM.read(ARRD_PASS_ST);
  if (lenPass > 0 && lenPass < 50)
  {
    passwordST=fnReadEepromString(ARRD_PASS_ST);
  }
}

void fnwriteEepromWifi()
{
  fnWriteEepromString(ARRD_SSID_ST,ssidST);
  fnWriteEepromString(ARRD_PASS_ST,passwordST);
  EEPROM.commit();
}