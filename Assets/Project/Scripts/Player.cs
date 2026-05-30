using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PlatformMove platformMove;
    Health health;
    Points points;
    private void Start()
    {
        platformMove = GetComponent<PlatformMove>();
        health = GetComponent<Health>();
        points = GetComponent<Points>();
    }
    public void UpSpeed()
    {
        platformMove.UpSpeed();
    }
    public void UpHealth()
    {
        health.AddHealth();
    }
}
