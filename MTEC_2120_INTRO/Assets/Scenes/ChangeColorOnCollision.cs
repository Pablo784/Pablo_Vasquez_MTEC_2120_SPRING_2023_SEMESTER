using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
 
public Color getRandomColor()
    {

        return new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f));
    }

public void OnCollisionEnter(Collision collision)
{
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = getRandomColor();
        Debug.Log("OnCollisionEnter : " + collision.gameObject.name);

}

}

// This script is to have a ball bounce on a cube and change color. I was following along the zoom recording from 2/10's class