using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : Lutador
{
    void Start()
    {
        RetomarVida();
    }

    void Update()
    {
        
    }

    public override void AtaqueFraco()
    {
        throw new System.NotImplementedException();
    }
}
