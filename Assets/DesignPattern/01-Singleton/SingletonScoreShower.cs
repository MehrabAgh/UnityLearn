using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonScoreShower : MonoBehaviour
{
    public void ScoreUpper()
    {
        GameManager.instance.Score++;
        print(GameManager.instance.Score);
    }
}
