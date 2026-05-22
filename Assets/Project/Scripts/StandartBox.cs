using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartBox : Box
{
    static public Action<int> OnGetDamage = delegate { };
    private int pointOfDestroy = 1;
    public override void BoxGetDamage()
    {
        OnGetDamage(pointOfDestroy);
        Destroy(gameObject);
    }
}
