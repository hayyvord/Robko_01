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

void setup() {
  SetupSteppers();
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
  boolean state;

  int Motor = 0;
  int Steps = 0;
  int Speed = 0;

  //?M0+1000:0123\n
  if (command[0] == '?' && command[8] == ':' && command[13] == '\n')
  {
    if (command[3] == '-' || command[3] == '+')
    {
      if (command[1] == 'D')
      {
        Motor = atoi(command.substring(2).c_str());
        Steps = atoi(command.substring(4, 8).c_str());
        Speed = atoi(command.substring(9, 13).c_str());

        if (Steps <= 1999 && Steps >= -1999)
        {
          state = true;
        }

        if (Motor >= 0 && Motor <= 5)
        {
          state = true;
        }

        if (Speed >= 0 && Speed <= 100)
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
      Speed = atoi(command.substring(3, 7).c_str());

      if (Speed >= 0 && Speed <= 100)
      {
        state = true;
      }
      Motor = atoi(command.substring(2).c_str());

      if (Motor >= 0 && Motor <= 5)
      {
        state = true;
      }
    }
  }


  if (command[0] == '?' && command[3] == '\n')
  {
    if (command[1] == 'S')
    {
      Motor = atoi(command.substring(2).c_str());

      if (Motor >= 0 && Motor <= 5)
      {
        state = true;
      }
    }
  }

  return state;
}


void ParseCommand(String command)
{

  int Motor = 0;
  int Steps = 0;
  int Speed = 0;


  if (command[0] == '?' && command[8] == ':' && command[13] == '\n')
  {
    if (command[3] == '-' || command[3] == '+')
    {
      if (command[1] == 'D')
      {
        Motor = atoi(command.substring(2).c_str());
        Steps = atoi(command.substring(4, 8).c_str());
        Speed = atoi(command.substring(9, 13).c_str());

        if (command[3] == '+')
        {
          RunStepper(Motor, Steps, Speed);
        }
        else if (command[3] == '-')
        {
          RunStepper(Motor, -Steps, Speed);
        }

      }
    }
  }
  //E0:1000\n
  else if (command[0] == '?' && command[2] == ':' && command[7] == '\n')
  {
    if (command[1] == 'E')
    {
      Speed = atoi(command.substring(3, 7).c_str());
      Motor = atoi(command.substring(2).c_str());
      SetSpeed(Motor, Speed);
    }
  }


  else if (command[0] == '?' && command[3] == '\n')
  {
    if (command[1] == 'S')
    {

      Motor = atoi(command.substring(2).c_str());
      StopSteppers(Motor);

    }
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
  Shoulder.run();
  Elbow.run();
  Pitch.run();
  Roll.run();
  Gripper.run();
}

