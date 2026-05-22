using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    //[SerializeField]

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
        pointsUI.UpdateText(addPoint);
    }
    public void DeductPoints(int addPoint)
    {
        point -= addPoint;
        pointsUI.UpdateText(addPoint);
    }
    private void OnEnable()
    {
        StandartBox.OnGetDamage += AddPoints;
        //StandartBox.OnGetDamage += pointsUI.UpdateText;
        
    }
    private void OnDisable()
    {
        StandartBox.OnGetDamage -= AddPoints;
        //StandartBox.OnGetDamage -= pointsUI.UpdateText;
    }
}
