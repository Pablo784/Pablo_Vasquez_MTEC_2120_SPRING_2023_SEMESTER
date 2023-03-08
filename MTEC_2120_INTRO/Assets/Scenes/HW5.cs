using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW_5 : MonoBehaviour
{


    public delegate void OnClickEvent(GameObject g);
    public event OnClickEvent OnClick;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit[] hits = Physics.RaycastAll(ray);
        for (int i = 0; i < hits.Length; i++)
        {
            OnClick(hits[i].collider.gameObject);
        }
    }
}

// ON 3/3, THE PROFESSOR WENT OVER THE 5TH HOMEWORK ASSIGNMENT