using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenButton : AbstractButton
{
    [SerializeField]
    GameObject watchObject;
    public override void ActionButton()
    {
        watchObject.SetActive(true);
    }
}
