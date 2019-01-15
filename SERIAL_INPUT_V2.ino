int hijau=12;
int merah=11;
int biru=10;
void setup() {
  Serial.begin(9600);
  Serial.println("Enter Command!");
  pinMode(merah,OUTPUT);
  pinMode(hijau,OUTPUT);
  pinMode(biru,OUTPUT);
}

char rx_byte = 0;
String rx_str = "";

void loop() {
  if (Serial.available() > 0) {    // is a character available?
    rx_byte = Serial.read();       // get the character
    
    if (rx_byte != '\n') {
      // a character of the string was received
      rx_str += rx_byte;
      Serial.println(rx_str);
    }
    else {
      // end of string
      if(rx_str == "a1"){
        digitalWrite(hijau,HIGH);
        rx_str="";
      }else if(rx_str=="a0"){
        digitalWrite(hijau,LOW);
        rx_str="";
      }else if(rx_str=="b1"){
        digitalWrite(merah,HIGH);
        rx_str="";
      }else if(rx_str=="b0"){
        digitalWrite(merah,LOW);
        rx_str="";
      }else if(rx_str=="c1"){
        digitalWrite(biru,HIGH);
        rx_str="";
      }else if(rx_str=="c0"){
        digitalWrite(biru,LOW);
        rx_str="";
      }
      else{
        Serial.println("Wrong Command!");
        rx_str="";
      }
    }
  } // end: if (Serial.available() > 0)
}
