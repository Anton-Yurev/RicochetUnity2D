using UnityEngine;
using UnityEngine.UI;

public class UpdateTextUI : MonoBehaviour
{
    [SerializeField]
    StandartBox standartBox;
    private Text Text;
    private void Awake()
    {
        Text = GetComponent<Text>();
        Text.text = "0";
    }
    public void UpdateText(float newText)
    {
        Debug.Log("UpdateText");
        Text.text = newText.ToString();
    }
    //private void OnEnable()
    //{
    //    standartBox.OnGetDamage += UpdateText;
    //}
    //private void OnDisable()
    //{
    //    standartBox.OnGetDamage -= UpdateText;
    //}
}
