using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Lutador : MonoBehaviour
{
    [SerializeField] CombatenteScriptbl _fighterScriptable;

    public Punho punho;

    public CombatenteScriptbl FighterScriptable => _fighterScriptable;

    private int _vidaAtual;

    public abstract void AtaqueFraco();

    public abstract void AtaqueForte();

    public abstract void DesvioEsquerda();

    public abstract void DesvioDireita();

    public void TomarDano(int danoRecebido)
    {
        _vidaAtual -= danoRecebido;
        Debug.Log(_vidaAtual);
    }

    public void RetomarVida()
    {
        _vidaAtual = _fighterScriptable.VidaMax;
        Debug.Log(_vidaAtual);
    }
}
