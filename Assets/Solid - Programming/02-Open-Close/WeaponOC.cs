using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponOC : MonoBehaviour
{
    public IShooting Bullet;   
    private void Start()
    {
        Bullet = GetComponent<IShooting>();    
    }
    private void Update()
    {
        var a = Input.GetAxis("Fire1");
        if(a > 0)
        {
            Bullet.Shoot(this);
        }
    }    
}
