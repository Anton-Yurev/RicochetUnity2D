using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartBox : Box
{
    public override void BoxGetDamage()
    {
        Destroy(gameObject);
    }
}
