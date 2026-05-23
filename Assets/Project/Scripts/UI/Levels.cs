using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{

    public int NumberOpenLevels { get; set; } = 1;
    public Level[] levelsList = new Level[20];
    public void Start()
    {
        for (int i = 0; i < levelsList.Length; i++)
        {
            levelsList[i] = new Level();
        }
        for (int i = 0; i < NumberOpenLevels; i++)
        {
            levelsList[i].OpenLevel();
            Debug.Log(levelsList[i].IsOpenLevel);
        }
        Debug.Log("___________________________________");
        for (int i = 0; i < levelsList.Length; i++)
        {
            Debug.Log(levelsList[i].IsOpenLevel);
        }
    }
}
