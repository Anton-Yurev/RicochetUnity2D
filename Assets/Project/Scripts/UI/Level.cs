using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
    public bool IsOpenLevel { get; private set; } = false;
    public int levelNumber;
    public void OpenLevel()
    {
        IsOpenLevel = true;
    }
    public void WinLevel()
    {

    }
}
