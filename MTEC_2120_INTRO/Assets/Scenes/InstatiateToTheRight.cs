using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatiateToTheRight : MonoBehaviour
{

    public GameObject someObject;
    public Vector3 thePosition;


    void Start()
    {

        thePosition = transform.TransformPoint(Vector3.right * 2);
        Instantiate(someObject, thePosition,someObject.transform.rotation);
    }
}

