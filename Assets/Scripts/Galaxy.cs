using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galaxy : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        gameObject.transform.Rotate(0,0,2*Time.deltaTime,Space.Self);
    }
}
