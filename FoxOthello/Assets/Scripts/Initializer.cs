using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using FoxOthello.PageSystem;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    [SerializeField] Transform _pageRoot;

    void Start()
    {
        PageInitializer pageInitializer = new PageInitializer(new StateMachine());
        pageInitializer.InitializeAndRun(_pageRoot).Forget();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
