
#include <Servo.h> 
 
Servo myservo;   
 
 
int s1 = 1;
int s2 = 2;
int s3 = 3;
int s4 = 4;
int so1 = 5;
int so2 = 6;
int ldr1 = 7;
int ldr2 = 8;
int ldr3 = 9;
int l[5] = {0,10,11,12,13};
//l[1] = 10;
//l[2] = 11;
//l[3] = 12;
//l[4] = 13;
int w1 = A0;
int w2 = A1;
int t=0;
char s;

 
void setup() 
{ 
  Serial.begin(9600);
  pinMode(t,INPUT);
 pinMode(s1, OUTPUT);
  pinMode(s2, OUTPUT);
 pinMode(s3, OUTPUT);
pinMode(s4, OUTPUT);
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
pinMode(w1, INPUT);
digitalWrite(w1,LOW);
pinMode(w2, INPUT);
digitalWrite(w2,LOW);
} 
 
void loop() 
{
}

void serialEvent()
{ //int l[5] = {0,10,11,12,13};
  s = Serial.read();
  //digitalWrite(so1 , HIGH);
  //Serial.print(s);
  if(Serial.read()== 'a')  //rice
  {
   
  }
  else if (Serial.read()== 'b')    //wheat
  {
    
  }
  
  else if(s== 'i')      //kerosene
  {
    digitalWrite(so1 , HIGH);
    //delay(1000);
    //s = Serial.read();
    //Serial.print(s);
    delay(100);
    int k = Serial.parseInt();
    int kk;
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
      kk=digitalRead(l[k]);
      if(kk==HIGH)
      {
       //3 Serial.print(12);
        digitalWrite(so1 , LOW);
        break;
      }
    }
     // Serial.print(ldr3);
    //digitalWrite(so1 , LOW);
    while(digitalRead(ldr3) == LOW){}
    if(digitalRead(ldr3) == HIGH)
    {//Serial.print("23thfg  ");
      digitalWrite(so2 , HIGH);
      while( digitalRead(l[1]) != LOW)
      {
        if(digitalRead(ldr3)== LOW)
        {
          digitalWrite(so2 , LOW);
          Serial.write("n");
        }
        s = Serial.read();
        while (s=='n')
        {
          s = Serial.read();
        }
         s = Serial.read();
        if(s=='k')
        {
        
          digitalWrite(so2 , HIGH);
        }
      }
      digitalWrite(so2 , LOW);
      Serial.write('o');
      
      
      
    }
    
    
    
    
   
   
   
  }
 
}
