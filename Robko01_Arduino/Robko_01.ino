#include <Stepper.h>
#include <String.h>
#include <stdlib.h>

#define stepsPerRevolution 48

Stepper Base(stepsPerRevolution, 23, 25, 27, 29);
Stepper Shoulder(stepsPerRevolution, 22, 24, 26, 28);
Stepper Elbow(stepsPerRevolution, 30, 32, 34, 36);
Stepper Pitch(stepsPerRevolution, 39, 41, 43, 45);
Stepper Roll(stepsPerRevolution, 38, 40, 42, 44);
Stepper Gripper(stepsPerRevolution, 31, 33, 35, 37);

String IncommingCommnad = "";

void setup() {
  SetupSteppers();
  Serial.begin(9600);
}

void loop() {
  ReadCommand();
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


  //?S2\n, Stop Steppers
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

  //?S2\n, Stop Steppers
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

  //?S2\n, Stop Steppers
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
      //StopSteppers(Motor);

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
      Base.step(steps);
      break;
    case 1:
      Shoulder.step(steps);
      break;
    case 2:
      Elbow.step(steps);
      break;
    case 3:
      Pitch.step(steps);
      Roll.step(steps);
      break;
    case 4:
      Pitch.step(-steps);
      Roll.step(steps);
      break;
    case 5:
      Gripper.step(steps);
      break;
    default:

      break;
  }
}

void SetupSteppers()
{
  Base.setSpeed(100);
  Shoulder.setSpeed(30);  
  Elbow.setSpeed(30);
  Pitch.setSpeed(30);
  Roll.setSpeed(30);
  Gripper.setSpeed(30);
}

