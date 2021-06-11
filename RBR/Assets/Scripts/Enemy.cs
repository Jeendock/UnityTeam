using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp { get; set; }

    public Enemy()
    {
        hp = 10;
    }

    public void Hit(int Damage = 1)
    {
        hp -= Damage;
    }

    protected virtual void Attack()
    {
    }
}