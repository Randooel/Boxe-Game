using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Lutador
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        RetomarVida();
    }

    void Update()
    {
        AtaqueFraco();
        AtaqueForte();
        DesvioDireita();
        DesvioEsquerda();
    }

    public override void AtaqueFraco()
    {
        if (Input.GetMouseButtonDown(0))
        {
            punho.DanoFraco();
            animator.SetTrigger("isWeakPunching");
            Debug.Log("Atacou fofo");
        }
    }

    public override void AtaqueForte()
    {
        if(Input.GetMouseButtonDown(1))
        {
            punho.DanoForte();
            animator.SetTrigger("isStrongPunching");
            Debug.Log("Atacou FORTE");
        }
    }

    public override void DesvioEsquerda()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("isLeftDodging");
            Debug.Log("Desviou esquerda");
        }
    }

    public override void DesvioDireita()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("isRightDodging");
            Debug.Log("Desviou direita");
        }
    }
}
