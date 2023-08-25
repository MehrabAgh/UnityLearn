using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int health;
    [SerializeField]
    private int maxHealth;
    public event Action Death = delegate { };

    private void Awake()
    {
        health = maxHealth;
    }
    private void Start()
    {
        Death += OnDie;
        StartCoroutine(update(0.01f));
    }
    IEnumerator update(float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            if (health < 1)
            {
                Death();
            }
        }
    }

    public void OnDie()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            health--;
        }
    }

}
