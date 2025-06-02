using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancioProiettili : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Freccia f1 = new Freccia("freccia", 100);
        f1.Lancia();

        PallaMagica p1 = new PallaMagica("palla magica", 200);
        p1.Lancia();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
