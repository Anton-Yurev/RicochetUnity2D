using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildeLevel : MonoBehaviour
{
    [SerializeField]
    public GameObject _blocks;

    private int _numberOfBlocks=14;
    float pointOfBuilding = 0f;
    float offsetBlocks = 0.2f;
    private void Start()
    {
        for (int i = 0; i < _numberOfBlocks; i++)
        {
            Instantiate(_blocks, new Vector2(transform.position.x + i+pointOfBuilding,transform.position.y), Quaternion.identity);
            pointOfBuilding += offsetBlocks;
        }
    }
}
