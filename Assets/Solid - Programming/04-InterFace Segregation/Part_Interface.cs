using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part_Interface
{
    class NPC : MonoBehaviour , IHealthCollect
    {
        public int Health
        {
            get { return Health; }
            set { Health = value; }
        }
        public int Damage {
            get { return Damage; }
            set { Damage = value; } 
        }

        private void Start()
        {
            Health = 4;
            
            print("Health NPC : " + Health);
        }
    }

    class Player : MonoBehaviour , IHealthCollect , IMoveCollect
    {
        public int Health
        {
            get { return Health; }
            set { Health = value; }
        }
        public int Damage
        {
            get { return Damage; }
            set { Damage = value; }
        }

        public float Speed
        {
            get { return Speed; }
            set { Speed = value; }
        }

        private void Start()
        {
            Health = 50;
            Speed = 10;
            print("Speed Player : " + Speed);
            print("Health Player : " + Health);
        }

    }

    class Enemy : MonoBehaviour, IHealthDam
    {
        public int Health
        {
            get { return Health; }
            set { Health = value; }
        }
        public int Damage
        {
            get { return Damage; }
            set { Damage = value; }
        }

        public void TakeDamage(int x)
        {
            
        }
    }

    public interface IHealthCollect
    {
        public int Health { get; set; }
        public int Damage { get; set; }
    }

    public interface IHealthDam : IHealthCollect
    {       
        public void TakeDamage(int x);
    }

    public interface IMoveCollect
    {
        public float Speed { get; set; }
    }

}
