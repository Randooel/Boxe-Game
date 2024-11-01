using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : TecnicasLuta
{
    [SerializeField] CombatenteScriptbl _playerScriptable;

    public override void AtaqueFraco()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Atacou fofo");
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        AtaqueFraco();
    }
}
