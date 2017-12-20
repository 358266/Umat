const int buttonPin1 = 1;
const int buttonPin2 = 2;
const int buttonPin3 = 3;
const int buzzPin =  5; 
int ledPin = 4;
int buttonState1 = 0; 
int buttonState2 = 0; 
int buttonState3 = 0; 


void setup() {
  pinMode(ledPin, OUTPUT);  
  pinMode(buzzPin, OUTPUT);  
  pinMode(buttonPin1, INPUT);
  pinMode(buttonPin2, INPUT);
  pinMode(buttonPin3, INPUT);
}

void loop(){
  buttonState1 = digitalRead(buttonPin1);
  buttonState2 = digitalRead(buttonPin2);
  buttonState3 = digitalRead(buttonPin3);

  if (buttonState1 == LOW) {      
    digitalWrite(ledPin, HIGH);

    tone(buzzPin, 500);
    delay(10);
    noTone(buzzPin);
    delay(50);

    
  }
  else {
    digitalWrite(ledPin, LOW);
  }

//


  if (buttonState2 == LOW) {      
    digitalWrite(ledPin, HIGH);

    tone(buzzPin, 1000);
    delay(10);
    noTone(buzzPin);
    delay(50);
      
  }
  else {
    digitalWrite(ledPin, LOW);
  }


//


  if (buttonState3 == LOW) {      
    digitalWrite(ledPin, HIGH);

    tone(buzzPin, 1500);
    delay(10);
    noTone(buzzPin);
    delay(50);

  }
  else {
    digitalWrite(ledPin, LOW);
  }
}
