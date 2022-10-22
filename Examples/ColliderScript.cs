using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{

    public Renderer myObject;

    private void OnTriggerEnter()
    {
        Debug.Log("Tetiklenme Tespit Edildi");
        Destroy(this.gameObject);
    }

    
    private void OnCollisionEnter()
    {
        Debug.Log("Tetiklenme Tespit Edildi");
        myObject.material.color = Color.red;
    }
}
