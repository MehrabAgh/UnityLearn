using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScript : MonoBehaviour
{
    private float speed;
    [SerializeField]
    private float maxSpeed;
    private int Health;
    [SerializeField]
    private int maxHealth;

    public event Action<float> move = delegate { };
    public event Action Death = delegate { };
    public event Action attack = delegate { };
    private void Start()
    {
        speed = maxSpeed;
        Health = maxHealth;
        move += movement;
        Death += OnDie;
        attack += Attack;
    }
    private void Update()
    {
        if(Health < 1)
        {
            Death();
        }
        move(speed);
        Attack();
    }
    public void movement(float speed)
    {
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");

        transform.position += Time.deltaTime * Vector3.forward * v * speed;
        transform.position += Time.deltaTime * -Vector3.left * h * speed;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            Health--;
        }
    }

    public void Attack()
    {
        var a = Input.GetAxis("Fire1");
        if(a > 0)
        {
            print("attack");
        }
    }

    public void OnDie()
    {
        Destroy(gameObject);
    }
}
