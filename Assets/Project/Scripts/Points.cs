using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    StandartBox standartBox;
    //[SerializeField]
    public Action<int> bonusUpdate = delegate {  };
    //StandartBox standartBox;
    [SerializeField]
    PointsUI pointsUI;
    public int point { get; private set; }
    private void Start()
    {
        point = 0;
    }
    public void AddPoints(int addPoint)
    {
        point += addPoint;
        pointsUI.UpdateText(point);
    }
    public void DeductPoints(int addPoint)
    {
        point -= addPoint;
        pointsUI.UpdateText(addPoint);
    }
    private void OnEnable()
    {
        //StandartBox.OnGetDamage += AddPoints;
        //StandartBox.OnGetDamage += pointsUI.UpdateText;
        
    }
    private void OnDisable()
    {
        //StandartBox.OnGetDamage -= AddPoints;
        //StandartBox.OnGetDamage -= pointsUI.UpdateText;
    }
}
