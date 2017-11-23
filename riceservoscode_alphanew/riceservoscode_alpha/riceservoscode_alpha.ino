
#include <Servo.h> 
 
Servo servo1;
Servo servo2;
Servo servo3; 
Servo servo4; 
int s1 = 4;
int s2 = 5;
int s3 = 2;
int s4 = 3;
int so1 = A2;
int so2 = A3;
int ldr1 = 6;
int ldr2 = 7;
int ldr3 = 8;
int l[6] = {0,13,12,11,10,9};
int w1 = A0;
int w2 = A1;
char s;


 
void setup() 
{ 
  Serial.begin(9600);
servo1.attach(s1);
servo2.attach(s2);
servo1.write(120);
servo2.write(75);
servo3.attach(s3);
servo4.attach(s4);
servo3.write(120);
servo4.write(50);
pinMode(so1, OUTPUT);
pinMode(so2, OUTPUT);
pinMode(ldr1, INPUT);
digitalWrite(ldr1,LOW);
pinMode(ldr2, INPUT);
digitalWrite(ldr2,LOW);
pinMode(ldr3, INPUT);
digitalWrite(ldr3,LOW);
pinMode(l[1], INPUT);
digitalWrite(l[1],LOW);
pinMode(l[2], INPUT);
digitalWrite(l[2],LOW);
pinMode(l[3], INPUT);
digitalWrite(l[3],LOW);
pinMode(l[4], INPUT);
digitalWrite(l[4],LOW);
pinMode(l[5], INPUT);
digitalWrite(l[5],LOW);
pinMode(w1, INPUT);
//digitalWrite(w1,LOW);
pinMode(w2, INPUT);
//digitalWrite(w2,LOW);
} 
 
void loop() 
{
}

void serialEvent()
{ 
  s = Serial.read();
  //Serial.print(s);
  if(s== 'a')                                    //rice
  {
    int counter = analogRead(w1);
    delay(100);
    servo1.write(50);
    
    
    delay(100);
    Serial.println(counter);
    int k = Serial.parseInt();
    while (true)
    {
      k = Serial.parseInt();
      if(k>=5&&k<=800)                            //defining k range      
      break;
    }
    
    //Serial.print(k);
    
    while(analogRead(w1)-counter<=k)
    {
      Serial.println(analogRead(w1)-counter);
    }
    Serial.println(analogRead(w1)-counter);
    servo1.write(120);                            //closing servo

    if(digitalRead(ldr2) == LOW)
    {
      Serial.write("n");
      while(digitalRead(ldr2)==LOW)
      {}
      Serial.write("m");
    }
    
    int flag=5;
    //if(digitalRead(ldr2) == HIGH)
    {
      servo2.write(105);
      while(analogRead(w1)-counter>=-3)
      {
        if(digitalRead(ldr2)== LOW)
        {
          servo2.write(75);
          flag=55;
          Serial.write("n");
          while(digitalRead(ldr2)==LOW)
          {}
          Serial.write("m");
          servo2.write(105);
        }
        
      }
      servo2.write(75);
      Serial.write('o');
  }
}



  else if (s == 'b')    //wheat
  {
    int counter2 = analogRead(w2);
    servo3.write(50);
    delay(100);
    Serial.println(counter2);
    int k = Serial.parseInt();
    
    while (true)
    {
      k = Serial.parseInt();
      if(k>=5&&k<=800)                            //defining k range      
      break;
    }
    
    Serial.print(k);
     
    while(analogRead(w2)-counter2<=k)
    {
      Serial.println(analogRead(w2)-counter2);
    }
    Serial.println(analogRead(w2)-counter2);
    servo3.write(120);                            //closing servo

    if(digitalRead(ldr1) == LOW)
    {
      Serial.write("n");
      while(digitalRead(ldr1)==LOW)
      {}
      Serial.write("m");
    }
    
    int flag=5;
    //if(digitalRead(ldr3) == HIGH)
    {
      servo4.write(105);
      while(analogRead(w2)-counter2>=-3)
      {
        if(digitalRead(ldr1)== LOW)
        {
          servo4.write(50);
          flag=55;
          Serial.write("n");
          while(digitalRead(ldr1)==LOW)
          {}
          Serial.write("m");
          servo4.write(105);
        }
        
      }
      servo4.write(50);
      Serial.write('o');
  }
  }
  else if(s== 'i')      //kerosene
  {
    digitalWrite(so1 , HIGH);
    //delay(1000);
    //s = Serial.read();
    //Serial.print(s);
    delay(100);
    int k = Serial.parseInt();
    while (true)
    {
      k = Serial.parseInt();
  //Serial.print(k);
    if(k==1||k==2||k==3||k==4)
    break;
    }
    
    //Serial.print(k);
    while(true)
    {
      //Serial.print("233131  ");
      if(digitalRead(l[k])==HIGH)
      {
       //3 Serial.print(12);
        digitalWrite(so1 , LOW);
        break;
      }
    }
     // Serial.print(ldr3);
    //digitalWrite(so1 , LOW);
    if(digitalRead(ldr3) == LOW)
    {
      Serial.write("n");
      while(digitalRead(ldr3)==LOW)
      {}
      Serial.write("m");
    }
    
    int flag=5;
    //if(digitalRead(ldr3) == HIGH)
    {
      digitalWrite(so2,HIGH);
      while(digitalRead(l[1]))
      {
        //Serial.println(digitalRead(l[1]));
        if(digitalRead(ldr3)== LOW)
        {
          digitalWrite(so2,LOW);
          flag=55;
          Serial.write("n");
          while(digitalRead(ldr3)==LOW)
          {}
          Serial.write("m");
          digitalWrite(so2,HIGH);
        }
        
      }
      digitalWrite(so2,LOW);
      Serial.write('o');
    
    }
    
    
    
    
   
   
   
  }
 
}
