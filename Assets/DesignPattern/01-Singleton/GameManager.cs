using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Score;
    public static GameManager instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }
   
}
