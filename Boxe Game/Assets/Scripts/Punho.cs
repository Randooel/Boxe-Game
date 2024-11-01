using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punho : MonoBehaviour
{
    Lutador lutador;

    public int DanoAtual;

    void Start()
    {
        lutador = GetComponentInParent<Lutador>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Lutador inimigo))
        {
            inimigo.TomarDano(DanoAtual);
        }
    }

    public void DanoFraco()
    {
        DanoAtual = lutador.FighterScriptable.DanoFraco;
    }

    public void DanoForte()
    {
        DanoAtual = lutador.FighterScriptable.DanoForte;
    }
}