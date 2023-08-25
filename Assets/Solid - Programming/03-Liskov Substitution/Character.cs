using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Liskov
{
    public class Character : MonoBehaviour
    {
        private float health;
        [SerializeField] private float maxHealth;

        private void Awake()
        {
            health = maxHealth;
        }

        public virtual void TakeDamage(float X)
        {
            health -= X;
            print(health);
        }

    }
}
