using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceBox : Box
{
    [SerializeField ]
    GameObject bonus1;
    [SerializeField]
    GameObject bonus2;
    [SerializeField]
    GameObject bonus3;
    List<GameObject> list;
    private void Start()
    {
        list = new List<GameObject>(3);
        list.Add(bonus1);
        list.Add(bonus2);
        list.Add(bonus3);
    }
    public override void BoxGetDamage()
    {
        GameObject bonus= list[Random.Range(0,3)];
        Instantiate(bonus, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
