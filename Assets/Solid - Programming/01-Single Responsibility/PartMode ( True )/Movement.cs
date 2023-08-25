using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed;
    [SerializeField]
    private float maxSpeed;

    public event Action<float> move = delegate { };

    private void Awake()
    {
        move += movement;
        speed = maxSpeed;
    }   
    private void Update()
    {
        move(speed);
    }    

    public void movement(float speed)
    {
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");

        transform.position += Time.deltaTime * Vector3.forward * v * speed;
        transform.position += Time.deltaTime * -Vector3.left * h * speed;

    }
}
