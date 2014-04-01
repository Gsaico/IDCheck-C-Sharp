/*
  Autor: Percy Saico Ccapa
  
*/
const int LED_Rojo=8;
const int LED_Verde=10;
int inByte = 0;
 
void setup(){
    Serial.begin(9600); //Open the serial port
    pinMode(LED_Verde, OUTPUT);
    pinMode(LED_Rojo, OUTPUT);
    digitalWrite(LED_Verde, LOW);
    digitalWrite(LED_Rojo, LOW);
  }
 
void loop(){
 
    if(Serial.available() > 0){
 
        inByte = Serial.read();
        Serial.println(inByte);
        if(inByte == '0')
            digitalWrite(LED_Verde, LOW);
        else if(inByte=='1')
            digitalWrite(LED_Verde, HIGH);
        else if(inByte=='2')
            digitalWrite(LED_Rojo, LOW);
        else if(inByte=='3')
            digitalWrite(LED_Rojo, HIGH);
    }
}

