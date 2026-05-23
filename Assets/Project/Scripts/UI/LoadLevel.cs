using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : AbstractButton
{
    [SerializeField]
    int level;

    public override void ActionButton()
    {
        SceneManager.LoadScene(level);
    }
}
