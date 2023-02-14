using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallChangingColor : MonoBehaviour
{
    public Color color;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = color;
    }

    public Color GetRandomColor()
    {
        return new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f));

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rend.material.color = color;
    }
    
}

/* THIS SCRIPT IS TO SEE A 3D OBJECT LIKE A CUBE FOR EXAMPLE CHANGE COLOR IN UNITY AND WHEN YOU PRESS A KEY LIKE YOUR SPACEBAR
 * I WAS FOLLOWING ALONG THE ZOOM RECORDING FROM 2/10'S CLASS
*/