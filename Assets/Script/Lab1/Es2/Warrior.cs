using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Character
{
    public Warrior(string name, int hp) : base(name, hp)
    {
    }

    public override void Attack()
    {
        Debug.Log($"Il personaggio {Name} infligge 10 di danno");
    }

    public override void TakeDamage(int damage)
    {
        Debug.Log($"Il personaggio {Name} ha subito {damage} danni e la sua salute ora è {Mathf.Max(0,Hp-damage)}");
    }
}
