using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyOrbitScript : MonoBehaviour
{
    public GameObject sun;

    public Vector3 rotationAxis;

    public float rotationAngle = 1.0f;

    // private float countdown = 1.0f;


    // Update is called once per frame
    void Update()
    {
        // CountdownToColorChange();
        Renderer rend = sun.GetComponent<Renderer>();
        rend.material.color = sun.GetComponent<BallChangingColor>().GetRandomColor();
        transform.RotateAround(sun.transform.position, rotationAxis, rotationAngle);

    }
}

/*
public void CountdownToColorChange()
{
    if (CountdownToColorChange < 0)
    {
        Renderer rend = sun.GetComponent<Renderer>();
        rend.material.color = sun.GetComponent<BallChangingColor>().GetRandomColor()
        countdown = 1.0f;
  }
    else
    {
        countdown -= Time.deltaTime;
    }
}
     }     
*/

// I Was following along the zoom recording for 2/10's class. This script makes your gameobjects orbit like a planet and
// Changing the color of the sun every second instead of every frame. A timer was also added