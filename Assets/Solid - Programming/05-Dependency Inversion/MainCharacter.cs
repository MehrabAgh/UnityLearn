using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    [SerializeField] private CharacterSetting dataCharacter;
    private ICharacter e;
    private CharacterMovement movement;
    private void Awake()
    {
        e = new CharacterInput();
        movement = new CharacterMovement(dataCharacter , e , transform);
    }
    void Update()
    {
        e.ReadInput();
        movement.Move();
    }
}
