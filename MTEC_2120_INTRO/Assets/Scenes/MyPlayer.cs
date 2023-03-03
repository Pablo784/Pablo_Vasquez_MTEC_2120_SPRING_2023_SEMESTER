using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Component to sit next to the PlayerInput
[RequireComponent(typeof(PlayerInput))]
public class MyPlayer : MonoBehaviour
{
    //public GameObject projectilePrefab;

    //private Vector2 m_Look;
    private Vector2 m_Move;
    //private bool m_Fire;

    // Player has joined the game.
    public void OnPlayerJoined()
    {
        // Put player at spawn point.
        //transform.position = PickSpawnPoint().transform.position;
    }

    // 'Fire' input action has been triggered. For 'Fire' we want continuous
    // action (i.e. firing) while the fire buttion is held such that the action
    // gets triggered repeatedly while the button is down. We can easily set this
    // up by having a "Press" interaction on the button and setting it to repeat
    // at fixed intervals.
    //public void OnFire()
    //{
    //    Instantiate(projectilePrefab);
    //}


    public void OnJump(InputValue value)
    {
        float jumpVal = value.Get<float>();

        Debug.Log("On Jump Called");
        Rigidbody rigid = GetComponent<Rigidbody>();
        rigid.AddForce(0, 100, 0);
    }

    // 'Move' input action has been triggered.
    public void OnMove(InputValue value)
    {
        m_Move = value.Get<Vector2>();
    }

   // private GameObject PickSpawnPoint()
    
        // Pick a spawn point for the player...
    }

