using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    GameObject player;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if(player!=null)
            player.transform.position = new Vector3(-10,0,0); 
    }

    public void LoadNextLevel(int roomchangen)
    {
        StartCoroutine(LoadLevel(roomchangen));
    }

    IEnumerator LoadLevel(int actualroom)
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(actualroom);
    }

}