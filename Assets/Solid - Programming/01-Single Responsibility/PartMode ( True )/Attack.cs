using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public event Action _attack = delegate { };
    private void Awake()
    {
        _attack += attack;
    }   
    private void Start()
    {        
        StartCoroutine(update(0.005f));
    }
    IEnumerator update(float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            var a = Input.GetAxis("Fire1");
            if (a > 0)
            {
                _attack();
            }
        }
    }
    private void attack()
    {
        print("attack");
    }
}
