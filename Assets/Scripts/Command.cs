using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command : MonoBehaviour
{
    public Rigidbody playerRB;
    public abstract void Execute(); 

}

// playerRB.AddForce(0, lateralForce, 0 )
class MoveUp : Command
{
    //a local version of the lateral force arguments in player script
    private float _lateralForce;

    //implemntaiton of the MoveUp call 
    public MoveUp(Rigidbody player, float lateralForce)
    {
        //set locals equal to arguments
        playerRB = player;
        _lateralForce = lateralForce;
    }

    public override void Execute()
    {
        playerRB.AddForce(0, _lateralForce * Time.deltaTime, 0, ForceMode.VelocityChange);
    }
}
class MoveDown : Command
{
    private float _lateralForce;

    public MoveDown(Rigidbody player, float lateralForce)
    {
        playerRB = player;
        _lateralForce = lateralForce;
    }

    public override void Execute()
    {
        playerRB.AddForce(0, -_lateralForce * Time.deltaTime, 0, ForceMode.VelocityChange);
    }
}
class MoveLeft : Command
{
    private float _lateralForce;

    public MoveLeft(Rigidbody player, float lateralForce)
    {
        playerRB = player;
        _lateralForce = lateralForce;
    }

    public override void Execute()
    {
        playerRB.AddForce(-_lateralForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
class MoveRight : Command
{
    private float _lateralForce;

    public MoveRight(Rigidbody player, float lateralForce)
    {
        playerRB = player;
        _lateralForce = lateralForce;
    }

    public override void Execute()
    {
        playerRB.AddForce(_lateralForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}