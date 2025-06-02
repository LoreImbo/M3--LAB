using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PallaMagica : Proiettile
{
    public PallaMagica(string nome, float velocita)
    {
        SetName(nome);
        SetVelocita(velocita);
    }
    public override void Lancia()
    {
        Debug.Log($"Il proiettile {GetName()} è stato lanciato a una velocità {GetVelocita()}");
    }
}
