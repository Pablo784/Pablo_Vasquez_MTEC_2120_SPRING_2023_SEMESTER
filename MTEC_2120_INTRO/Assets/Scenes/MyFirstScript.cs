using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MyFirstScript : MonoBehaviour
{
    public float speed = 5;
    GameObject test;

    // Start is called before the first frame update
    void Start()
    {
        int i = 123;
        int count = 0;
        int n = i;


        while (i > 0)
        {
            ++count;
            i = i / 10;
        }
        Debug.Log(string.Format("Number {0} contains {1} digits.", n, count));
    }
}


/* LEARNING C# AGAIN IN MTEC 2120 (SPRING 2023 SEMESTER) 
 FPS - Frames Per Second

*/
