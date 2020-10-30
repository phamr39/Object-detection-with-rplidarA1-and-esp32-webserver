#include <WiFi.h>
#include <HardwareSerial.h>
#include <WebServer.h>
#include "Ticker.h"
#include "peripherial.h"
//#include "esp32-hal-ledc.h"
#include <RPLidar.h>
#include <ESPmDNS.h>
#include <ArduinoJson.h>

DynamicJsonDocument doc(128);
WebServer server(80);
bool state = false;
extern String ssidST;
extern String passwordST;
RPLidar lidar;
float distance;
float angle;
#define RPLIDAR_MOTOR 21
const int freq = 5000;
const int ledChannel = 0;
const int resolution = 8;
void handleRoot() {
  server.send(200, "text/plain", "Start Scan");
}
void tranferData() {
  Serial.println("Start scan data Lirad");
  if (distance > 300) {
    distance = 300; angle = 0;
  } 
  doc["distance"] = distance;
  doc["angle"] = angle;
  String output;
  serializeJsonPretty(doc,output);
  server.send(200, "application/json", output);
}
void setup() {
  Serial.begin(115200);
  Serial2.begin(115200);
  lidar.begin(Serial2);
  pinMode(LED_STA_PIN,OUTPUT);
  ledcSetup(ledChannel, freq, resolution);
  ledcAttachPin(RPLIDAR_MOTOR, ledChannel);
  WiFi.mode(WIFI_STA);
  NVS_FLASH_INIT(512);
  fnreadEepromWifi();
  if (!ssidST.equals("0"))
  {
    WiFi.begin((const char *)ssidST.c_str(), (const char *)passwordST.c_str());
    char retry_connect_num = 0;
    while (WiFi.status() != WL_CONNECTED) {
      Serial.print('.');
      retry_connect_num++;
      digitalWrite(LED_STA_PIN, !digitalRead(LED_STA_PIN));
      delay(150);
      if (retry_connect_num > 5) {
        Serial.println("Connect Fail");
        WiFi.beginSmartConfig();
      }
    }
    digitalWrite(LED_STA_PIN, 0);
    Serial.println("...............WIFI CONNECTED..................");
  }
  else
  {
    Serial.println("...............START SMARTCONFIG..................");
    WiFi.beginSmartConfig();
    while (WiFi.status() != WL_CONNECTED) {
      digitalWrite(LED_STA_PIN, !digitalRead(LED_STA_PIN));
      delay(150);
    }
  }
  digitalWrite(LED_STA_PIN,1);
  Serial.println(WiFi.localIP());Serial.println(WiFi.SSID());Serial.println(WiFi.psk());
  ssidST = WiFi.SSID(); passwordST = WiFi.psk();
  Serial.println("SSID : "+ ssidST );
  fnwriteEepromWifi();
  if (MDNS.begin("esplidar")) {
    Serial.println("MDNS responder started");
  }
  Serial.print("IPAddress : ");Serial.println(WiFi.localIP());
  server.on("/", handleRoot);
  server.on("/update",tranferData);
  server.begin();
  Serial.println("HTTP server started");
  MDNS.addService("http", "tcp", 80);
  ledcWrite(RPLIDAR_MOTOR, 255);
}
void loop() {
  if (IS_OK(lidar.waitPoint())) {
    delay(200);
    distance = lidar.getCurrentPoint().distance; //distance value in mm unit
    angle    = lidar.getCurrentPoint().angle; //anglue value in degree
    bool  startBit = lidar.getCurrentPoint().startBit; //whether this point is belong to a new scan
    byte  quality  = lidar.getCurrentPoint().quality; //quality of the current measurement
    Serial.println("_____________________________________");
    Serial.println("Lidar Get info...");
  } else {
    ledcWrite(RPLIDAR_MOTOR, 0);
    rplidar_response_device_info_t info;
    if (IS_OK(lidar.getDeviceInfo(info, 100))) {
       lidar.startScan();
       ledcWrite(RPLIDAR_MOTOR, 255);
       delay(1000);
    }
  }
  Serial.println(lidar.getCurrentPoint().distance);
  Serial.println(lidar.getCurrentPoint().angle);
  Serial.println(lidar.getCurrentPoint().startBit);
  Serial.println(lidar.getCurrentPoint().quality);
  Serial.println("_____________________________________");
  server.handleClient();
}
