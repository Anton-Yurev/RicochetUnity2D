using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health { get; private set; }
    public int startHealth { get; private set; } = 5;
    public void Start()
    {
        health = startHealth;
        Debug.Log(health); 
    }
    public void AddHealth()
    {
        health++;
        Debug.Log(health);
    }
    public void RemoveHealth()
    {
        health--;
    }

}
