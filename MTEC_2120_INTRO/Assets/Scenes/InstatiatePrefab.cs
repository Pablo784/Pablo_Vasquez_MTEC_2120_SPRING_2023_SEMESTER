using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatiatePrefab : MonoBehaviour
{

    public GameObject prefab;
    void Start()
    {

        Spawn3DGridPrefabs();

    }




    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space bar was pressed");
        }
    }
    // public void Rotate;





    public void Spawn3DGridPrefabs()
    {
        float spacing = 10;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; i < 10; i++)
            {
                for (int k = 0; i < 10; i++)
                {
                    float x = i * spacing;
                    float y = j * spacing;
                    float z = k * spacing;
                    GameObject go = Instantiate(prefab, new Vector3(x, 1, y), Quaternion.identity);

                    Renderer rend = go.GetComponent<Renderer>();
                    rend.material.color = GetColorRGB(x/10/spacing, y / 10 / spacing, z / 10 / spacing);


                }

            }
        }
    }

    public Color GetColorRGB(float r, float g, float b)
    {
        return new Color(r, g, b);
    }
}
