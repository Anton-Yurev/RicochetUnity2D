using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : AbstractButton
{
    [SerializeField]
    GameObject pauseObject;
    public override void ActionButton()
    {
        pauseObject.SetActive(false);
        Time.timeScale = 1; ;
    }
}
