using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Liskov
{
    public class PlayerStatic : Character
    {
        public override void TakeDamage(float X)
        {
            base.TakeDamage(X * 2);
        }
    }
}
