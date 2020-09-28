using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public Rigidbody trapRB;

    public float distanceX;
    public float distanceZ;

    private void OnEnable()
    {
        PlayerMovement.OnHalfWay += activateTraps;

    }
    private void OnDisable()
    {
        PlayerMovement.OnHalfWay -= activateTraps;

    }

    void activateTraps()
    {
        trapRB.AddForce(0, 0, distanceZ * -Time.deltaTime, ForceMode.VelocityChange);
    }
}
