using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New BoxHealth", menuName ="BoxHealth")]
public class BoxScriptableObjects : ScriptableObject
{
    [SerializeField]
    public float health;
}
