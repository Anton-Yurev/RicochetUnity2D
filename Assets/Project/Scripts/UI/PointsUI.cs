using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsUI : MonoBehaviour
{
    private Text Text; 
    private void Awake()
    {
        Text = GetComponent<Text>();
        Text.text = "0";
    }
    public void UpdateText(int newText)
    {
        Text.text = newText.ToString();
        Debug.Log("TU");
    }
}
