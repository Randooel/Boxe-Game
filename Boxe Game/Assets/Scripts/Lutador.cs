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

    public void TomarDano(int danoRecebido)
    {
        _vidaAtual -= danoRecebido;
    }

    public void RetomarVida()
    {
        _vidaAtual = _fighterScriptable.VidaMax;
    }
}
