using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freccia : Proiettile
{
    public Freccia(string nome, float velocita)
    {
        SetName(nome);
        SetVelocita(velocita);
    }
    public override void Lancia()
    {
        Debug.Log($"Il proiettile {GetName()} è stato lanciato a una velocità {GetVelocita()}");
    }
}
