using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Character",menuName ="Create a Character/Character" , order = 1)]
public class CharacterSetting : ScriptableObject
{
    [SerializeField] private int health;
    [SerializeField] private float speed;
    [SerializeField] private bool _checkAI;
    public int Health { get { return health; } }
    public float Speed { get { return speed; } }
    public bool _CheckAI { get { return _checkAI; } }
}
