using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// I USED THE RECORDING THE PROFESSOR PROVIDED FROM 4/14'S CLASS 


public class Health-Bar : MonoBehaviour
{
    public int health = 100;
public UnityEvent OnDeath;

  private void OnCollisionEnter(Collision collision)
{

    if (collision.gameObject.GetComponet<Damage>())
    {
        Health -= collision.gameObject.GetComponent<Damage>().damage;
    }

    private void CheckDeath()
    {
        if (health < 0)
            Die();
    }

    private void Die()
    {

        OnDeath.Invoke();
        Destroy(this.gameObject);
    }


    private void Update()
    {
        CheckDeath();

    }
}
