using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{    
    private string str;    
    private void OnEnable()
    {
        str = "Enable";
        MainPrinter.OnPrinting += Printer;
    }
    private void OnDisable()
    {
        str = "Disable";
        MainPrinter.OnPrinting -= Printer;
    }

    private void Printer() => print(str);
}
