using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public delegate void EnableGravity();
    public static event EnableGravity OnEnableGravity;


    public void Update()
    {
        //if (Input.GetKeyDown((KeyCode.Space))
            { 
            OnEnableGravity?.Invoke();
        }

    }
}
 
    




/*
 FOLLOWING ALONG THE ZOOM RECORDING FROM 2/17 AND USING SOMETHING CALLED DELEGATES. FOR THIS SCRIPT YOU CAN CONTROL THE SUN BY
HOLDING SPACEBAR AND HAVE A BUNCH OF OTHER PLANETS ORBITING THE SUN
*/