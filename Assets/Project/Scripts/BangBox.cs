using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangBox : Box
{
    [SerializeField]
    CircleCollider2D bang;
    public override void BoxGetDamage()
    {
        StartCoroutine("Bang");

    }
    IEnumerator Bang()
    {
        yield return new WaitForSeconds(0.25f);
        Instantiate(bang, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
