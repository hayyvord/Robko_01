#include <AccelStepper.h>
#include <String.h>
#include <stdlib.h>

AccelStepper Base(AccelStepper::FULL4WIRE, 23, 25, 27, 29);
AccelStepper Shoulder(AccelStepper::FULL4WIRE, 22, 24, 26, 28);
AccelStepper Elbow(AccelStepper::FULL4WIRE, 30, 32, 34, 36);
AccelStepper Pitch(AccelStepper::FULL4WIRE, 39, 41, 43, 45);
AccelStepper Roll(AccelStepper::FULL4WIRE, 38, 40, 42, 44);
AccelStepper Gripper(AccelStepper::FULL4WIRE, 31, 33, 35, 37);

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


  //?D1-0100\n
  if (command[0] == '?' && command[8] == '\n')
  {
    if (command[3] == '-' || command[3] == '+')
    {
      if (command[1] == 'M')
      {
        Motor = atoi(command.substring(2).c_str());
        Steps = atoi(command.substring(4, 8).c_str());

        if (Steps <= 1999 && Steps >= -1999)
        {
          state = true;
        }

        if (Motor >= 0 && Motor <= 5)
        {
          state = true;
        }

      }
    }
  }


  if (command[0] == '?' && command[3] == '\n')
  {
    if (command[1] == 'D')
    {
      Motor = atoi(command.substring(2).c_str());

      if (Motor >= 0 && Motor <= 5)
      {
        state = true;
      }
    }
  }

  if (command[0] == '?' && command[3] == '\n')
  {
    if (command[1] == 'E')
    {
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

  if (command[0] == '?' && command[8] == '\n')
  {
    if (command[3] == '-' || command[3] == '+')
    {
      Motor = atoi(command.substring(2).c_str());
      Steps = atoi(command.substring(4, 8).c_str());

      if (command[1] == 'D')
      {

        if (command[3] == '+')
        {
          RunStepper(Motor, Steps);
        }
        else if (command[3] == '-')
        {
          RunStepper(Motor, -Steps);
        }

        //RunStepper(Motor, Steps);

      }
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

  else if (command[0] == '?' && command[3] == '\n')
  {
    if (command[1] == 'E')
    {

      Motor = atoi(command.substring(2).c_str());
      //enableMotors(Motor);

    }
  }

  else if (command[0] == '?' && command[3] == '\n')
  {
    if (command[1] == 'D')
    {

      Motor = atoi(command.substring(2).c_str());
      //disableMotors(Motor);

    }
  }
}

void RunStepper(int motor, int steps)
{
  switch (motor) {
    case 0:
      Base.move(steps);
      break;
    case 1:
      Shoulder.move(steps);
      break;
    case 2:
      Elbow.move(steps);
      break;
    case 3:
      Pitch.move(steps);
      Roll.move(steps);
      break;
    case 4:
      Pitch.move(-steps);
      Roll.move(steps);
      break;
    case 5:
      Gripper.move(steps);
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
      break;
    case 1:
      Shoulder.stop();
      break;
    case 2:
      Elbow.stop();
      break;
    case 3:
      Pitch.stop();
      Roll.stop();
      break;
    case 4:
      Pitch.stop();
      Roll.stop();
      break;
    case 5:
      Gripper.stop();
      break;
    default:

      break;
  }
}


void SetupSteppers()
{
  Base.setMaxSpeed(100.0);
  Base.setAcceleration(100.0);
  Shoulder.setMaxSpeed(100.0);
  Shoulder.setAcceleration(100.0);
  Elbow.setMaxSpeed(100.0);
  Elbow.setAcceleration(100.0);
  Pitch.setMaxSpeed(100.0);
  Pitch.setAcceleration(100.0);
  Roll.setMaxSpeed(100.0);
  Roll.setAcceleration(100.0);
  Gripper.setMaxSpeed(100.0);
  Gripper.setAcceleration(100.0);
}

void RunMotors()
{
  Base.run();
  Shoulder.run();
  Elbow.run();
  Pitch.run();
  Roll.run();
  Gripper.run();  
}

