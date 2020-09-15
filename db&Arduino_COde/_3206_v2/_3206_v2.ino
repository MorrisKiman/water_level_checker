#include <Stepper.h>
#include <Servo.h>
//Define constants for the stepper
const float Stp_per_revolution = 32;
const float gear_Reduction = 64;
const float stepsPerOutRev = Stp_per_revolution * gear_Reduction;
int StepsNeeded;
Stepper stepperMotor(Stp_per_revolution, 8, 9, 10, 11);
//sonar module
const unsigned int TRIG_PIN= 5 ;
const unsigned int ECHO_PIN= 7 ;
float duration, distance;
//const unsigned int BAUD_;

//servo
Servo servo;
int angle = 0;
//vb commands channel
char ch;

void setup () {
 pinMode ( TRIG_PIN , OUTPUT );
 pinMode ( ECHO_PIN , INPUT);
 servo.attach(3);
servo.write(angle);
Serial.begin(9600);
Serial. begin(9600 );
}

 void loop() {
  sonar();
 if (Serial.available())//wait for user entry
 {
    ch = Serial.read();//read vb commands
      switch (ch)
      {
        case 'a':
        while (ch = 'a' )
            {servio();}
            break;
        case 'b':
          while (distance >=0.9 )
            {stepper();}
            break;
        case 'c':
          //digitalWrite(reset, HIGH);
            break;
        case 'd':
            digitalWrite(8, LOW);
            digitalWrite(9,LOW);
            digitalWrite(10, LOW);
            digitalWrite(11, LOW);
            break;
        case 'e':
            digitalWrite(8, LOW);
            digitalWrite(9,LOW);
            digitalWrite(10, LOW);
            digitalWrite(11, LOW);
            off_servio();
            break; }}}
 
 void sonar()
 {
 digitalWrite (TRIG_PIN , LOW );
 delayMicroseconds(2);
 digitalWrite (TRIG_PIN , HIGH);
 delayMicroseconds(10);
 digitalWrite (TRIG_PIN , LOW );


 duration= pulseIn( ECHO_PIN , HIGH);
 distance= (30-(duration/29/2))/10 ;
 Serial. println(distance );
 delay (1000);
    }

    void stepper()
{
  StepsNeeded = 4;
   StepsNeeded = stepsPerOutRev;
   stepperMotor.setSpeed(600);
   stepperMotor.step(StepsNeeded);
   sonar();
  
  }

  void servio()
  {
     // put your main code here, to run repeatedly:
  for (angle = 0; angle < 180; angle++)

  {
    servo.write(angle);
    sonar();
    delayMicroseconds(1);
    ch = Serial.read();
    }
  for (angle = 180 ; angle >0; angle--)

  {
    servo.write(angle);
    sonar();
    ch = Serial.read();
    }}

    //switch those motors off!!
    void off_servio()
    {
      for (angle == angle; angle>0||angle<0; angle-- || angle+20)
      {
        servo.write(angle);
        delayMicroseconds(1);}
      }
