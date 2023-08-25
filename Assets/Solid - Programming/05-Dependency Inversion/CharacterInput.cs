using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour , ICharacter     
{
    public float ve { get ; set ; }
    public float ho { get; set ; }

    public void ReadInput()
    {
        ve = Input.GetAxis("Vertical");
        ho = Input.GetAxis("Horizontal");
    }

}
