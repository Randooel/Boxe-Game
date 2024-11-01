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
}
