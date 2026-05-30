using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField]
    StandartBox standartBox;
    public float point { get; private set; }
    private void Start()
    {
        point = 0;
    }
    public void AddPoints(float addPoint)
    {
        point += addPoint;
        Debug.Log(point);
    }
    public void DeductPoints(int addPoint)
    {
        point -= addPoint;
    }
    private void OnEnable()
    {
        standartBox.OnGetDamage += AddPoints;
    }
    private void OnDisable()
    {
        standartBox.OnGetDamage -= AddPoints;
    }
}
