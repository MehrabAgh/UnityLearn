using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(update(0.002f));
    }

    IEnumerator update(float timer)
    {
        while (true)
        {
            yield return new WaitForSeconds(timer);
            transform.position += Vector3.forward * Time.deltaTime;
        }
    }
}
