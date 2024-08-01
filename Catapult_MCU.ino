#include <Servo.h>

Servo TensionServo;  
Servo LockServo;    

int stringToInt(const String &str) {
  int result = 0;
  int sign = 1;
  int startIndex = 0;

  if (str[0] == '-') {
    sign = -1;
    startIndex = 1;
  }

  for (int i = startIndex; i < str.length(); i++) {
    char c = str[i];
    if (c >= '0' && c <= '9') {
      result = result * 10 + (c - '0');
    } else {
      return 0; 
    }
  }

  return result * sign;
}

void setup() {
  Serial.begin(9600);
  TensionServo.attach(11);  // Attach TensionServo to pin 11
  LockServo.attach(10);     // Attach LockServo to pin 10
  TensionServo.write(0);    // Initialize TensionServo to 0
  LockServo.write(0);       // Initialize LockServo to 0
}

void loop() {
  static String inputString = "";  
  if (Serial.available()) {
    char inChar = (char)Serial.read();
    if (inChar == '\n') {
      Serial.print("Received: ");
      Serial.println(inputString);
      char command = inputString[0];
      int value = stringToInt(inputString.substring(1));
      if (command == 'A') {
        Serial.print("TensionServo set to: ");
        Serial.println(value);
        TensionServo.write(value);
      } else if (command == 'B') {
        Serial.print("LockServo set to: ");
        Serial.println(value);
        LockServo.write(value);
      }
      inputString = "";  
    } else {
      inputString += inChar;  
    }
  }
}
