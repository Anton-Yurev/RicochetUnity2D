using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartBox : Box
{
    [SerializeField]
    BoxScriptableObjects so;
    public Action<float> OnGetDamage = delegate { };
    private float pointOfDestroy ;
    private void Start()
    {
        pointOfDestroy = so.health;
    }
    public override void BoxGetDamage()
    {
        Debug.Log("BoxGetDamage");
        OnGetDamage(pointOfDestroy);
        Destroy(gameObject);
    }
}
