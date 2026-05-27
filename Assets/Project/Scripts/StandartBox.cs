using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartBox : Box
{
    [SerializeField]
    Points points;
    public Action<int> OnGetDamage = delegate { };
    private int pointOfDestroy = 1;
    public override void BoxGetDamage()
    {
        //OnGetDamage(pointOfDestroy);
        points.AddPoints(pointOfDestroy);
        Destroy(gameObject);
    }
}
