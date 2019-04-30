/*

Orientation Shield Example

This example shows an application on 1Sheeld's orientation shield.

By using this example, you can turn on some LEDs if the
smartphone's orienta


tion sensor moves in any of the x, y
and z axises.

OPTIONAL:
To reduce the library compiled size and limit its memory usage, you
can specify which shields you want to include in your sketch by
defining CUSTOM_SETTINGS and the shields respective INCLUDE_ define. 

*/

#define CUSTOM_SETTINGS
#define INCLUDE_ORIENTATION_SENSOR_SHIELD
#define INCLUDE_MIC_SHIELD
#define INCLUDE_PRESSURE_SENSOR_SHIELD
#define INCLUDE_SLIDER_SHIELD
#define INCLUDE_LIGHT_SENSOR_SHIELD

/* Include 1Sheeld library. */
#include <OneSheeld.h>

/* A name for the LED on pin 13. */
int ledPin1 = 13;
/* A name for the LED on pin 12. */
int ledPin2 = 12;
/* A name for the LED on pin 11. */
int ledPin3 = 11;

//If the control is out of bounds, it sends digitalWrite(2);
int Controller = 0;
int Mapeo = 0;
int Temp = 0;
String Mensaje = "";
void setup() 
{
  /* Start communication. */
  OneSheeld.begin();
  Serial.begin(115200);
  /* Set LEDs 1, 2 and 3 as output. */
  pinMode(ledPin1,OUTPUT);
  pinMode(ledPin2,OUTPUT);
  pinMode(ledPin3,OUTPUT);
}
/*
 * Trabajo realizado por:
 * 
 * @Xavier Idrovo Vallejo
 * @Christian Carrillo Espinosa
 * @Verónica Moreira Apolo
 * 
 * ::..::MANUAL::..::
 * 
 *    1 DSEACELERAR
 *    2 MANTENERSE
 *    3 ACELERAR
 *    
 *    4 Arriba
 *    5 Medio
 *    6 Abajo
 *    
 *    9 Disparo
 *    
 *    ::..::..::..::..::..::..::..::..::..::..::..::..::..
 *    Los mensajes son enviados con el siguiente patrón
 *    ::..::..::..::..::..::..::..::..::..::..::..::..::..
 *    -_-_-_-_-_-[Aceleración-Disparo-Altura]-_-_-_-_-_-
*/

void loop()
{
  Mensaje = "";
  /*
  Mapeo = map(Slider.getValue(), 0 , 255, 1, 6 );

  if (Mapeo <= 2)
  {
    Mensaje = Mensaje + "1-";
  } else if (Mapeo >= 5)
  {
    Mensaje = Mensaje + "3-";
  } else {
    Mensaje = Mensaje + "2-";
  }

  Serial.flush();
  */
  
   if(OrientationSensor.getZ() < 90 && OrientationSensor.getZ() > 20)
  {
      Mensaje = Mensaje + "3-";
  }else if((OrientationSensor.getZ() < 0 && OrientationSensor.getZ() > -20) || (OrientationSensor.getZ() > 0 && OrientationSensor.getZ() < 20))
  {
      Mensaje = Mensaje + "2-";
  }else if(OrientationSensor.getZ() <= -20 && OrientationSensor.getZ() >= -90) 
  {
    Mensaje = Mensaje + "1-";
  }else
  {
    Mensaje = Mensaje + "2-";
  } 

//------------------------------------------
  //Pew pew con Sensor de luz.
  //Shoot at 9!!!
  if (LightSensor.getValue() < 10 && LightSensor.getValue() > 0)
  {
    Mensaje = Mensaje + "9-";
   // Serial.write(9);
   // delay(20);
   // Serial.flush();  
  }
  else
  {
    Mensaje = Mensaje + "0-";
  }
//-----------------------------------------

   /* Check X-axis orientation. */
   //This is the Up/Down control part, when the angles are betwin (20~70)
   //the Character goes up.

   //if the Angles era betwen 20 and -20, the character goes on an
   //Horizonal line.

   //Otherwise, the character goes down.
  if(OrientationSensor.getY() < 70 && OrientationSensor.getY() > 20)
  {
    /* Turn on the LED 1., pin 13 */
    digitalWrite(ledPin1,HIGH);
    //For unity~
//    Serial.write(4);
//    delay(20);
      Mensaje = Mensaje + "4-";
    //Ends of what Unity needs
  }
//  Serial.flush();

  /* Check Y-axis orientation. */
  else if((OrientationSensor.getY() < 0 && OrientationSensor.getY() > -20) || (OrientationSensor.getY() > 0 && OrientationSensor.getY() < 20))
  {
    /* Turn on the LED 2., pin 12 */
    digitalWrite(ledPin2,HIGH);
    //For unity~
//    Serial.write(5);
//    delay(20);
    Mensaje = Mensaje + "5-";
    //Ends of what Unity needs
  }
//  Serial.flush();
  /* Check Z-axis orientation. */
  else if(OrientationSensor.getY() <= -20 && OrientationSensor.getY() >= -70) 
  {
    /* Turn on the LED 3., pin 11 */
    digitalWrite(ledPin3,HIGH);
    //For unity~
//    Serial.write(6);
//    delay(20);
    Mensaje = Mensaje + "6-";
    //Ends of what Unity needs
  }else
  {
    Mensaje = Mensaje + "0-";
  }
  
  Serial.println(Mensaje);
  Serial.flush();
  delay(25);
  
}
