using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Color color;
    private Renderer rend;
    public GameObject sun;
    public Vector3 rotationAxis;

    public float rotationAngle = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = color;
    }

    public void RotateAroundSun()
    {
        transform.RotateAround(sun.transform.position, rotationAxis, rotationAngle);
        {

        }
    }
    public Color getRandomColor()
    {
        return new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f));

    }
    // Update is called once per frame
    void Update()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = getRandomColor();

    }
}
