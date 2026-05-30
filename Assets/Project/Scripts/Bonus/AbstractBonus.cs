using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractBonus : MonoBehaviour
{
    int _speedOfMove = 3;
    private void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * _speedOfMove);
    }
    private void Start()
    {
        StartCoroutine("LifeTimeBonus");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player platformMove))
        {
            Go(platformMove);
            Destroy(gameObject);
        }
    }
    IEnumerator LifeTimeBonus()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
    public abstract void Go(Player platformMove);
}
