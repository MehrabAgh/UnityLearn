using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private readonly Transform CurrentTransform;
    private readonly ICharacter CurrentInputs;
    private readonly CharacterSetting CurrentData;

    public CharacterMovement(CharacterSetting data , ICharacter input , Transform _transform)
    {
        this.CurrentTransform = _transform;
        this.CurrentInputs = input;
        this.CurrentData = data;
    }
    public void Move()
    {
        CurrentTransform.position += Time.deltaTime * Vector3.forward * CurrentData.Speed * CurrentInputs.ve ;
        CurrentTransform.Rotate(Time.deltaTime * Vector3.up * CurrentData.Speed * CurrentInputs.ho);
    }
}
