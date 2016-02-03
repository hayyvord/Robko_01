#include <AccelStepper.h>
#include <String.h>
#include <stdlib.h>

AccelStepper Base(AccelStepper::HALF4WIRE, 23, 25, 27, 29);
AccelStepper Shoulder(AccelStepper::HALF4WIRE, 22, 24, 26, 28);
AccelStepper Elbow(AccelStepper::HALF4WIRE, 30, 32, 34, 36);
AccelStepper Pitch(AccelStepper::HALF4WIRE, 39, 41, 43, 45);
AccelStepper Roll(AccelStepper::HALF4WIRE, 38, 40, 42, 44);
AccelStepper Gripper(AccelStepper::HALF4WIRE, 31, 33, 35, 37);

String IncommingCommnad = "";

#define DEFAULT_SPEED 100

#define ANALOG_INPUT A0

#define X1 2
#define X2 3
#define X3 4
#define X4 5
#define X5 6

boolean Input1 = false;
boolean Input2 = false;
boolean Input3 = false;
boolean Input4 = false;
boolean Input5 = false;

float vout = 0.0;
float vin = 0.0;

float R1 = 100000.0;
float R2 = 10000.0;

int value = 0;

void setup() {
  SetupSteppers();
  SetInputs();
  Serial.begin(9600);
}

void loop() {
  ReadCommand();
  RunMotors();
}

void ReadCommand()
{
  while (Serial.available())
  {
    IncommingCommnad += (char)Serial.read();
    delay(5);
  }

  if (IncommingCommnad != "")
  {
    boolean isValid = ValidateCommand(IncommingCommnad);
    if (isValid)
    {
      ParseCommand(IncommingCommnad);
    }

    IncommingCommnad = "";
  }
}


boolean ValidateCommand(String command)
{
  boolean state = false;

  static int motor = 0;
  static int steps = 0;
  static int speed = 0;

  if (command[0] == '?' && command[8] == '\n')
  {
    if (command[3] == '-' || command[3] == '+')
    {
      if (command[1] == 'M')
      {
        motor = atoi(command.substring(2).c_str());
        steps = atoi(command.substring(4, 8).c_str());

        if (steps <= 1999 && steps >= -1999)
        {
          state = true;

        }

        if (motor >= 0 && motor <= 5)
        {
          state = true;

        }
      }
    }
  }

  //?M0+1000:0123\n
  if (command[0] == '?' && command[8] == ':' && command[13] == '\n')
  {
    if (command[3] == '-' || command[3] == '+')
    {
      if (command[1] == 'D')
      {
        motor = atoi(command.substring(2).c_str());
        steps = atoi(command.substring(4, 8).c_str());
        speed = atoi(command.substring(9, 13).c_str());

        if (steps <= 1999 && steps >= -1999)
        {
          state = true;
        }

        if (motor >= 0 && motor <= 5)
        {
          state = true;
        }

        if (speed >= 0 && speed <= 100)
        {
          state = true;
        }
      }
    }
  }

  //?E0000\n
  if (command[0] == '?' && command[2] == ':' && command[7] == '\n')
  {
    if (command[1] == 'E')
    {
      speed = atoi(command.substring(3, 7).c_str());

      if (speed >= 0 && speed <= 100)
      {
        state = true;
      }

      motor = atoi(command.substring(2).c_str());

      if (motor >= 0 && motor <= 5)
      {
        state = true;
      }
    }
  }


  if (command[0] == '?' && command[3] == '\n')
  {
    if (command[1] == 'S')
    {
      motor = atoi(command.substring(2).c_str());

      if (motor >= 0 && motor <= 5)
      {
        state = true;
      }
    }
  }

  if (command == "?INPUTS\n")
  {
    state = true;
  }

  if (command == "?VOLTAGE\n")
  {
    state = true;
  }

  if (command == "?VERSION\n")
  {
    state = true;
  }

  return state;
}


void ParseCommand(String command)
{
  static int motor = 0;
  static int steps = 0;
  static int speed = 0;


  if (command[0] == '?' && command[8] == ':' && command[13] == '\n')
  {
    if (command[3] == '-' || command[3] == '+')
    {
      if (command[1] == 'M')
      {
        motor = atoi(command.substring(2).c_str());
        steps = atoi(command.substring(4, 8).c_str());
        speed = atoi(command.substring(9, 13).c_str());

        if (command[3] == '+')
        {
          RunStepper(motor, steps, DEFAULT_SPEED);
        }
        else if (command[3] == '-')
        {
          RunStepper(motor, -steps, DEFAULT_SPEED);
        }

      }
    }
  }

  if (command[0] == '?' && command[8] == '\n')
  {
    if (command[3] == '-' || command[3] == '+')
    {
      motor = atoi(command.substring(2).c_str());
      steps = atoi(command.substring(4, 8).c_str());

      if (command[1] == 'D')
      {

        if (command[3] == '+')
        {
          RunStepper(motor, steps, 100);
        }
        else if (command[3] == '-')
        {
          RunStepper(motor, -steps, 100);
        }
      }
    }
  }


  //E0:1000\n
  else if (command[0] == '?' && command[2] == ':' && command[7] == '\n')
  {
    if (command[1] == 'E')
    {
      speed = atoi(command.substring(3, 7).c_str());
      motor = atoi(command.substring(2).c_str());
      SetSpeed(motor, speed);
    }
  }


  else if (command[0] == '?' && command[3] == '\n')
  {
    if (command[1] == 'S')
    {

      motor = atoi(command.substring(2).c_str());
      StopSteppers(motor);

    }
  }

  else if (command == "?VOLTAGE\n")
  {
    value = analogRead(ANALOG_INPUT);
    vout = (value * 5.0) / 1024.0;
    vin = vout / (R2 / (R1 + R2));
    if (vin < 0.09) {
      vin = 0.0;
    }
    Serial.print("#VOLTAGE: ");
    Serial.print(vin);
    Serial.println(" ");
  }

  else if (command == "?VERSION\n")
  {
    Serial.println("#NAME: Robko01");
    Serial.println("#DATE: 29.1.2016y.");
  }

  else if (command == "?INPUTS\n")
  {
    Input1 = digitalRead(X1);
    Input2 = digitalRead(X2);
    Input3 = digitalRead(X3);
    Input4 = digitalRead(X4);
    Input5 = digitalRead(X5);

    Serial.print("Input1: ");
    Serial.println(Input1);
    Serial.print("Input2: ");
    Serial.println(Input2);
    Serial.print("Input3: ");
    Serial.println(Input3);
    Serial.print("Input4: ");
    Serial.println(Input4);
    Serial.print("Input5: ");
    Serial.println(Input5);
  }

}

void RunStepper(int motor, int steps, int Speed)
{
  switch (motor) {
    case 0:
      Base.move(steps);
      Base.setSpeed(Speed);
      break;
    case 1:
      Shoulder.move(steps);
      Shoulder.setSpeed(Speed);
      break;
    case 2:
      Elbow.move(steps);
      Elbow.setSpeed(Speed);
      break;
    case 3:
      Pitch.move(steps);
      Pitch.setSpeed(Speed);
      Roll.move(steps);
      Roll.setSpeed(Speed);
      break;
    case 4:
      Pitch.move(-steps);
      Pitch.setSpeed(Speed);
      Roll.move(steps);
      Roll.setSpeed(Speed);
      break;
    case 5:
      Gripper.move(steps);
      Gripper.setSpeed(Speed);
      break;
    default:

      break;
  }
}

void SetSpeed(int motor, int Speed)
{
  switch (motor) {
    case 0:
      Base.setSpeed(Speed);
      break;
    case 1:
      Shoulder.setSpeed(Speed);
      break;
    case 2:
      Elbow.setSpeed(Speed);
      break;
    case 3:
      Pitch.setSpeed(Speed);
      Roll.setSpeed(Speed);
      break;
    case 4:
      Pitch.setSpeed(Speed);
      Roll.setSpeed(Speed);
      break;
    case 5:
      Gripper.setSpeed(Speed);
      break;
    default:

      break;
  }
}

void StopSteppers(int motor)
{
  switch (motor) {
    case 0:
      Base.stop();
      Base.setSpeed(0.00);
      break;
    case 1:
      Shoulder.stop();
      Shoulder.setSpeed(0.00);
      break;
    case 2:
      Elbow.stop();
      Elbow.setSpeed(0.00);
      break;
    case 3:
      Pitch.stop();
      Pitch.setSpeed(0.00);
      Roll.stop();
      Roll.setSpeed(0.00);
      break;
    case 4:
      Pitch.stop();
      Pitch.setSpeed(0.00);
      Roll.stop();
      Roll.setSpeed(0.00);
      break;
    case 5:
      Gripper.stop();
      Gripper.setSpeed(0.00);
      break;
    default:

      break;
  }
}


void SetupSteppers()
{
  Base.setMaxSpeed(100.0);
  Base.setSpeed(100.0);

  Shoulder.setMaxSpeed(100.0);
  Shoulder.setSpeed(100.0);

  Elbow.setMaxSpeed(100.0);
  Elbow.setSpeed(100.0);

  Pitch.setMaxSpeed(100.0);
  Pitch.setSpeed(100.0);

  Roll.setMaxSpeed(100.0);
  Roll.setSpeed(100.0);

  Gripper.setMaxSpeed(100.0);
  Gripper.setSpeed(100.0);
}

void RunMotors()
{
  Base.runSpeedToPosition();
  Shoulder.runSpeedToPosition();
  Elbow.runSpeedToPosition();
  Pitch.runSpeedToPosition();
  Roll.runSpeedToPosition();
  Gripper.runSpeedToPosition();
}

void SetInputs()
{
  pinMode(X1, INPUT);
  pinMode(X2, INPUT);
  pinMode(X3, INPUT);
  pinMode(X4, INPUT);
  pinMode(X5, INPUT);
}
