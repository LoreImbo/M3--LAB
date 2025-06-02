using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Character> listOfCharacters = new List<Character>();
        Archer archer = new("arciere", 20); // nuova sintassi per istanziare un oggetto
        Mage mage = new Mage("mago", 30);
        Warrior warrior = new Warrior("guerriero", 50);

        listOfCharacters.Add(archer);
        listOfCharacters.Add(mage);
        listOfCharacters.Add(warrior);

        for (int i = 0; i < listOfCharacters.Count; ++i)
        {
            listOfCharacters[i].Attack();
            listOfCharacters[i].TakeDamage(Random.Range(0,21));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
