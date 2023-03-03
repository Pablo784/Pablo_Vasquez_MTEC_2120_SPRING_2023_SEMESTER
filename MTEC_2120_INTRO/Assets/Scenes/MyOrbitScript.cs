using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyOrbitScript : MonoBehaviour
{
    public GameObject sun;

    public Vector3 rotationAxis;

    public float rotationAngle = 1.0f;


    Transform tran;



    private void Start()
    {
        tran.position = new Vector3(0, 1, 2);
    }

    // private float countdown = 1.0f;


    // Update is called once per frame
    void Update()
    {
        CountdownToColorChange();

    }
    public void RotateAroundSun()
    {
        transform.RotateAround(sun.transform.position, rotationAxis, rotationAngle);
        {

        }
    }
    public void CountdownToColorChange()
    {

    }
        
        /*
        if (countdown < 0)
        {
            RenderBuffer rend = sun.GetComponent<Renderer>();
            rend.material.color = sun.GetComponent<MyFirstScript>().GetRandomColor();
            countdown = 1.0f;
        }
        else
        {
            countdown -= Time.deltaTime;
        }
        */
    }

  

// I Was following along the zoom recording for 2/10's and 2/17's class. 