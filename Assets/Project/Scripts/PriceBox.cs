using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceBox : Box
{
    [SerializeField ]
    GameObject bonus;
    public override void BoxGetDamage()
    {
        Instantiate(bonus, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
