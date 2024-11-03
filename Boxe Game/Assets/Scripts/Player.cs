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
}
