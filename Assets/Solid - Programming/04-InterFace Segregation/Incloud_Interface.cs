using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incloud_Interface
{
    class NPC
    {

    }

    class Player
    {

    }

    class Enemy
    {

    }
}

public interface IEntity
{
    public int Health { get; set; }
    public float speed { get; set; }
    public abstract void Attacking();
    public abstract void TakeDamage(int x);
    public void Shower();
    public void Movement(float speed);
}


