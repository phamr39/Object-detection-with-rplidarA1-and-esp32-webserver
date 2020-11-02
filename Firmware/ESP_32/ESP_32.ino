#include <WiFi.h>

#define LED_PIN 2  
bool state = false;

void setup() {
  // int cnt = 0;
  //Khởi tạo baud 115200
  Serial.begin(115200);
  pinMode(LED_PIN,OUTPUT);
  Serial.println("Smart Config");
  //WiFi.disconnect();
  //Mode wifi là station
  WiFi.mode(WIFI_STA);
  delay(500);
  WiFi.beginSmartConfig();
  Serial.println("SmartConfig Started");
  while (WiFi.status() != WL_CONNECTED)
  {
      digitalWrite(LED_PIN, !digitalRead(LED_PIN));
      delay(150);
  }
  Serial.println("WIFI CONNECTED");
  Serial.println("...");
  digitalWrite(LED_PIN,1);
  Serial.println(WiFi.localIP());
  Serial.println(WiFi.SSID());
  Serial.println(WiFi.psk());
}
void loop() {
  
}
