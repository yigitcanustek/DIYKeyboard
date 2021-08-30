/*
  LiquidCrystal Library - Hello World

 Demonstrates the use a 16x2 LCD display.  The LiquidCrystal
 library works with all LCD displays that are compatible with the
 Hitachi HD44780 driver. There are many of them out there, and you
 can usually tell them by the 16-pin interface.

 This sketch prints "Hello World!" to the LCD
 and shows the time.

  The circuit:
 * LCD RS pin to digital pin 12
 * LCD Enable pin to digital pin 11
 * LCD D4 pin to digital pin 5
 * LCD D5 pin to digital pin 4
 * LCD D6 pin to digital pin 3
 * LCD D7 pin to digital pin 2
 * LCD R/W pin to ground
 * LCD VSS pin to ground
 * LCD VCC pin to 5V
 * 10K resistor:
 * ends to +5V and ground
 * wiper to LCD VO pin (pin 3)

 Library originally added 18 Apr 2008
 by David A. Mellis
 library modified 5 Jul 2009
 by Limor Fried (http://www.ladyada.net)
 example added 9 Jul 2009
 by Tom Igoe
 modified 22 Nov 2010
 by Tom Igoe
 modified 7 Nov 2016
 by Arturo Guadalupi

 This example code is in the public domain.

 http://www.arduino.cc/en/Tutorial/LiquidCrystalHelloWorld

*/

// include the library code:
#include <LiquidCrystal.h>
#include <SoftwareSerial.h>

// initialize the library by associating any needed LCD interface pin
// with the arduino pin number it is connected to
const int rs = 2, en = 3, d4 = 8, d5 = 9, d6 = 10, d7 = 11;
LiquidCrystal lcd(rs, en, d4, d5, d6, d7);

String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
String commandString = "";

boolean isConnected = false;



const int potPin = A0;
int pot = 0;
char *numberstring;
int buttonState = 0; 
int button1 = 4;
int i =0;
void setup() {
  // set up the LCD's number of columns and rows:
   pinMode(button1, INPUT);
   Serial.begin(9600);

    initDisplay();
  
}

void loop() {
   i++;
   buttonState = digitalRead(button1);

  // check if the pushbutton is pressed. If it is, the buttonState is HIGH:
  if (buttonState == HIGH) {
    // turn LED on:
    Serial.write("b1");
    Serial.flush();
  }
  pot = (float(analogRead(potPin)) * 10 / 1024) * 10 ;
  if (i == 1000){
    
     numberstring = malloc(sizeof(char)*(String(pot).length() + 5));
    sprintf(numberstring, "pot%d/", pot);
    delay(1);
    //str_pot = "pot" + String(pot) + "/"  ;
    //strncpy(buf,str_pot,str_pot.length());
    Serial.write(numberstring);
  //writeString(str_pot);
    //Serial.write(pot);
    //Serial.write(String(pot)[0]);
    Serial.flush();
    free(numberstring);
    i = 0;
    
  }
  
  

  lcd.setCursor(0, 1);
  lcd.print(pot);
  lcd.setCursor(0,0);
 if(stringComplete)
{
  stringComplete = false;
  getCommand();
  
  if(commandString.equals("STAR"))
  {
    lcd.clear();
  }
  if(commandString.equals("STOP"))
  {
    
    lcd.clear();
    initDisplay(); 
  }
  else if(commandString.equals("TEXT"))
  {
    String text = getTextToPrint();
    printText(text);
  }

  
  inputString = "";
}
}

void writeString(String stringData) { // Used to serially push out a String with Serial.write()

    for (int i = 0; i < stringData.length(); i++)
    {
      //buf[i] = stringData[i];
      delay(1);
    }
      //Serial.write(buf);   // Push each char 1 by 1 on each loop pass
      Serial.flush();
  
}// end writeString
void initDisplay()
{
  lcd.begin(16, 2);
  lcd.print("Waiting to connect");
}

void getCommand()
{
  if(inputString.length()>0)
  {
     commandString = inputString.substring(1,5);
  }
}


String getTextToPrint()
{
  String value = inputString.substring(5,inputString.length()-2);
  return value;
}

void printText(String text)
{
  lcd.clear();
  lcd.setCursor(0,0);
    if(text.length()<16)
    {
      lcd.print(text);
    }else
    {
      lcd.print(text.substring(0,16));
      lcd.setCursor(0,1);
      lcd.print(text.substring(16,32));
    }
}

void serialEvent() {
  if (Serial.available()) {
    // get the new byte:
    
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
     
    }
  }
}
