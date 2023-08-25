using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Liskov
{
    public class Damager : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            var chara = other.GetComponent<Character>();
            chara.TakeDamage(2);
        }
    }
}
