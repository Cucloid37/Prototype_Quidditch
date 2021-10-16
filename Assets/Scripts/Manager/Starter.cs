using System;
using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField] private Data _data;
    [SerializeField] private GameObject _canvas;
    private Controllers _controllers;
        
    private void Start()
    {
        _controllers = new Controllers();
        var initialization = new GameInitialization(_data, _canvas);
        
        
    }
    
    private void Update()
    {
        var deltaTime = Time.deltaTime;
        _controllers.Execute(deltaTime);
    }

    private void LateUpdate()
    {
        var deltaTime = Time.deltaTime;
        _controllers.Execute(deltaTime);
    }

    private void OnDestroy()
    {
        _controllers.Cleanup();
    }
}