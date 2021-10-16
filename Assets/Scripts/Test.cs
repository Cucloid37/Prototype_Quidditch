using System;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;
    private readonly SquareData _square;
    private List<GameObject> _squareList;
    private const int Capacity = 1496;
    private float xMax = 17;
    private float yMax = 11;
    private float zMax = 8;

    private void Awake()
    {
        Debug.Log("Awake Запущен");
        CreateField();
    }

    public void CreateField()
    {
        Debug.Log("Create запущен");
       // _squareList = new List<GameObject>();
        for(int x = 1; x < xMax; x++)
        {
            for (int y = 1; y <= yMax; y++)
            {
                for (int z = 1; z <= zMax; z++)
                {
                    Debug.Log($"{z}, {x}, {y}");
                    // var xX = _square.Prefab;
                             
                        // _squareList[i] = _square.Prefab.DeepCopy();
                        var position = new Vector3(x, y, z);
                        Instantiate(Prefab, position, Quaternion.identity);
                        
                }
            }
        }

    }
}