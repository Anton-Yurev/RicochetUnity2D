using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumBox : Box
{
    public int _health { get; private set; }
    public MediumBox()
    {
        _health = 3;
    }
    public override void BoxGetDamage()
    {
        _health--;
        if ( _health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
