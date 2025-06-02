using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Proiettile
{
    protected string _name;
    protected float _velocita;

    public abstract void Lancia();

    public string GetName() => _name;
    public float GetVelocita() => _velocita;

    public void SetName(string name)
    {
        if (!string.IsNullOrEmpty(name))
            _name = name;
    }
    public void SetVelocita(float velocita) => _velocita = Mathf.Max(0, velocita);
}
