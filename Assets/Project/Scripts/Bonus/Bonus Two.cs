using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusTwo : MonoBehaviour
{
    public  void Go(  PlatformMove platformMove)
    {
        Debug.Log("Two");
        platformMove.UpSpeed();
        //platformMove.UPSpeed();
    }
}
