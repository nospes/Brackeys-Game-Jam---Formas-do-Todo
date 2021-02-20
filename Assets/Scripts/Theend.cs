using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Theend : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        Destroy(GameObject.FindGameObjectWithTag("MainCamera"));
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Done");
            Application.Quit();
        }
    }

}
