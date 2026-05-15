using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bang : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Box standartBox))
        {
            standartBox.BoxGetDamage();
        }
    }
    private void Start()
    {
        StartCoroutine("LifeTimeBang");
    }
    IEnumerator LifeTimeBang()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

}
