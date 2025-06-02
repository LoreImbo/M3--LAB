using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Character
{
    public Archer(string name, int hp) : base(name, hp)
    {
    }

    public override void Attack()
    {
        Debug.Log($"Il personaggio {Name} con salute rimanente {Hp} scaglia la freccia 1 che infligge 7 di danno");
        Debug.Log($"Il personaggio {Name} scaglia la freccia 2 che infligge 7 di danno");
    }

    public override void TakeDamage(int damage)
    {
        Debug.Log($"Il personaggio {Name} ha subito {damage} danni e la sua salute ora è {Mathf.Max(0,Hp-damage)}");
    }
}
