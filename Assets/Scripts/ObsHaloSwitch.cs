using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsHaloSwitch : MonoBehaviour
{
    public GameObject obst;

    private void OnEnable()
    {

        PlayerCollision.OnSwitchHit += turnOnHalo;
    }

    private void OnDisable()
    {

        PlayerCollision.OnSwitchHit -= turnOnHalo;
    }

    public void turnOnHalo()
    {
        (obst.GetComponent("Halo") as Behaviour).enabled = true;
    }
}
