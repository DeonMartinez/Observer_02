using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Reflection;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardSpeed = 2000f;
    public float lateralSpeed = 500f;

    //comand text object
    public Text commandDisplay;

    public float totalDistance = 400f;
    public float poem01 = 50f;
    public float poem02 = 100f;
    public float poem03 = 150f;
    public float poem04 = 200f;

    //Observers
    public delegate void HalfWayPassed();
    public static event HalfWayPassed OnHalfWay;



    void FixedUpdate()
    {
        //this is a standtard push that scales diretly to frame rate
        //Time.deltaTime negates the frame rate diffirences and the really high number helps the cube to actually move

        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);


        if ( Input.GetKey("d"))
        {
            Command _moveRight = new MoveRight(rb, lateralSpeed);
            Invoker invoker = new Invoker();
            invoker.SetCommand(_moveRight);

            invoker.ExecuteComand();
            //commandDisplay.text += "\n" + _moveRight.ToString();
        }

        if (Input.GetKey("a"))
        {
            Command _moveLeft = new MoveLeft(rb, lateralSpeed);
            Invoker invoker = new Invoker();
            invoker.SetCommand(_moveLeft);
          //  commandDisplay.text += "\n" + _moveLeft.ToString(); 
            invoker.ExecuteComand();
        }

        if (Input.GetKey("w"))
        {
            Command _moveUp = new MoveUp(rb, lateralSpeed);
            Invoker invoker = new Invoker();
            invoker.SetCommand(_moveUp);
         //   commandDisplay.text += "\n" + _moveUp.ToString();
            invoker.ExecuteComand();
        }

        if (Input.GetKey("s"))
        {
            //loacal _moveDown  //calling the command in commmand
            Command _moveDown = new MoveDown(rb, lateralSpeed);
            Invoker invoker = new Invoker();
            invoker.SetCommand(_moveDown);
          //  commandDisplay.text += "\n" + _moveDown.ToString();
            invoker.ExecuteComand();
        }
        
        if (rb.position.y < -1f)
        {

            FindObjectOfType<GameManager>().EndGame();
        }

        if(rb.GetComponentInParent<Transform>().position.z >= poem01)
        {
            OnHalfWay?.Invoke();
        }

        if (rb.GetComponentInParent<Transform>().position.z >= poem02)
        {
            OnHalfWay?.Invoke();
        }

        if (rb.GetComponentInParent<Transform>().position.z >= poem03)
        {
            OnHalfWay?.Invoke();
        }

        if (rb.GetComponentInParent<Transform>().position.z >= poem04)
        {
            OnHalfWay?.Invoke();
        }


    }

    
}
