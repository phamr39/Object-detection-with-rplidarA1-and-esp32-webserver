#ifndef PERIPHERIAL_H
#define PERIPHERIAL_H

#define RXD2 16
#define TXD2 17
#define LED_STA_PIN 2  
#define ARRD_SSID_ST  50
#define ARRD_PASS_ST  100
void fnreadEepromWifi();
void fnwriteEepromWifi();
void NVS_FLASH_INIT(int len);

#endif