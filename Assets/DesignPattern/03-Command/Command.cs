using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command {
    public abstract void Exe();
    public abstract bool isEnd { get; }
}
