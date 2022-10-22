using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class importantUnityMethods : MonoBehaviour
{

    private void Awake() //run before start method
    {
        Debug.Log("Awake Method Çalıştı");
    }

    private void Start()
    {
        Debug.Log("Start Method Çalıştı");
    }

    private void Update() //Update depend on computer system
    {
        
    }

    private void FixedUpdate() //FixedUpdate works on certain period regardless of computer system specs
    {

    }

    private void LateUpdate() //works after update method
    {

    }
}
