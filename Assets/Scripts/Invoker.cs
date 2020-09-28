using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker 
{
    Command temp_command;
    public bool disableLog = false;

    public void SetCommand(Command command)
    {
        temp_command = command;
    }
/*
    public Command GetComand()
    {
        if (temp_command != null)
        {
            return temp_command;
        }
        else
        {
            return null;
        }
    }
*/
    public void ExecuteComand()
    {
 
        CommandLog.commands.Enqueue(temp_command);
      
        temp_command.Execute();      
    }
}
