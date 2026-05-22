
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField]
    public AbstaractBonus bonus;

    int _speedOfMove = 3;
    private void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * _speedOfMove);
    }
    private void Start()
    {
        StartCoroutine("LifeTimeBonus");
    }
    IEnumerator LifeTimeBonus()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlatformMove platformMove))
        {
            Debug.Log("colision player");
            bonus.Go();
            Debug.Log("Bonus");
            Destroy(gameObject);
        }
    }

}
