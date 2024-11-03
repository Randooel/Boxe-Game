using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : Lutador
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        RetomarVida();
    }

    void Update()
    {
        
    }

    public override void AtaqueFraco()
    {
        punho.DanoFraco();
        animator.SetTrigger("isWeakPunching");
        Debug.Log("Atacou fofo");
    }

    public override void AtaqueForte()
    {
        throw new System.NotImplementedException();
    }

    public override void DesvioEsquerda()
    {
        throw new System.NotImplementedException();
    }

    public override void DesvioDireita()
    { 
        throw new System.NotImplementedException();
    }
}
