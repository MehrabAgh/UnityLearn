using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletItem : MonoBehaviour, IShooting
{
    [SerializeField] private Transform ammo, point;
   
    public void Shoot(WeaponOC attacking)
    {
       Instantiate(ammo, point.position, Quaternion.identity);
    }
}
