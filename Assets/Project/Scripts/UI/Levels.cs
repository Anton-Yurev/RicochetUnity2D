using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    [SerializeField]
    Sprite _unlockedIcon;

    [SerializeField]
    Sprite _lockedIcon;

    public static int NumberOpenLevels { get; set; } = 3;
    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.name=(i+1).ToString();
            transform.GetChild(i).GetChild(0).GetComponent<Text>().text=(i+1).ToString();

            if (i< NumberOpenLevels)
            {
                //transform.GetChild(i).GetComponent<Image>().sprite = _unlockedIcon;
                transform.GetChild(i).GetComponent<Button>().interactable = true;
            }else
            {
                //transform.GetChild(i).GetComponent<Image>().sprite = _lockedIcon;
                transform.GetChild(i).GetComponent<Button>().interactable = false;
            }
        }
    }

}
