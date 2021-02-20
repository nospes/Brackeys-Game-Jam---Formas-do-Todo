using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonmenu : MonoBehaviour
{
    GameObject obj;

    private void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("LevelLoad");
    }
    void OnMouseDown()
    {
        obj.GetComponent<LevelLoader>().LoadNextLevel(1);
    }
}
