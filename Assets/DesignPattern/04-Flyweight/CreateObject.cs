using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    [SerializeField] private Transform Cube;

    private void Spawn()
    {
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                Instantiate(Cube, new Vector3(i, j, 0), Quaternion.identity) ;
            }
        }
    }
    private void Awake()
    {
        Spawn();
    }
}
