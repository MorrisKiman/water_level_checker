//sonar module
const unsigned int TRIG_PIN= 5 ;
const unsigned int ECHO_PIN= 7 ;
float duration, distance;

//motors
int motor_in = 12;//inflow pump
int motor_out = 15;//outflow pump

//value for changing pump status
char ch;

//get everything set up
void setup () {
  pinMode ( TRIG_PIN , OUTPUT );
  pinMode ( ECHO_PIN , INPUT);
  pinMode (motor_in, OUTPUT);
  pinMode (motor_out, OUTPUT);
  Serial.begin(9600);//baudrate
  } //end of setup

//start the program
void loop () {
sonar();
 if (Serial.available())//wait for user entry
 {
    ch = Serial.read();//read vb commands
      switch (ch)
      {
        case 'a':
            {digitalWrite(motor_in, HIGH);}
            break;
        case 'b':
          //while (distance >=0.9 )
            {digitalWrite(motor_out, HIGH);}
            break;
        case 'c':
          digitalWrite(motor_in, LOW);
            break;
        case 'd':
            digitalWrite(motor_out, LOW);
            break;
        case 'e':
            digitalWrite(motor_in, LOW);
            digitalWrite(motor_out, LOW);
            break; 
            } // end of switch case
     }//big if
  
  
  }//end of loop

void sonar(){
 digitalWrite (TRIG_PIN , LOW );
 delayMicroseconds(2);
 digitalWrite (TRIG_PIN , HIGH);
 delayMicroseconds(10);
 digitalWrite (TRIG_PIN , LOW );


 duration= pulseIn( ECHO_PIN , HIGH);
 distance= (30-(duration/29/2))/10 ;
 Serial. println(distance );
 delay (1000);
    }// end of sonar function








  
