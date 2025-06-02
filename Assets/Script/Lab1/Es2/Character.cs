using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    protected string Name { get; set;}
    protected int Hp { get; set;}

    public abstract void Attack();

    public abstract void TakeDamage(int damage);

    protected Character(string name, int hp)
    {
        Name = name;
        Hp = hp;
    }
}
