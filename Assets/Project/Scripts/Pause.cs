using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField]
    GameObject pauseObject;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                pauseObject.SetActive(true);
                Time.timeScale = 0.0f;
            }
            else
            {
                pauseObject.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
