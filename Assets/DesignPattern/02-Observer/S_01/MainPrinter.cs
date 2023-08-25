using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPrinter : MonoBehaviour
{
    public static event Action OnPrinting;

    public void OnPress()
    {
        OnPrinting?.Invoke();
    }
}
