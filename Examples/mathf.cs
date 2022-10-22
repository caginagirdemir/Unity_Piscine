using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathf : MonoBehaviour
{
    void Start()
    {
        float x = 2f;

        // float y = Mathf.Abs(x);
        // float y = Mathf.Pow(x, 3);
        x = Mathf.Sqrt(x);
        float y =  Mathf.Round(x);

        print(y);
    }
}
