using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soulmove : MonoBehaviour
{

    private Vector2 playerposition;
    public Animator animator;
    public int soulqnt;


    public AudioSource musicplay;
    public AudioClip stg11;
    public AudioClip stg12;
    public AudioClip stg13;
    public AudioClip stg21;
    public AudioClip stg22;
    public AudioClip stg23;
    public AudioClip stg3;


    private void Start()
    {
    }
    void Update()
    {
        animator.SetInteger("Soul",soulqnt);
        playerposition = GameObject.FindGameObjectWithTag("Player").transform.position;
        transform.position = new Vector3(playerposition.x, playerposition.y, -1);

        if (soulqnt == 1&&musicplay.clip!= stg11)
        {
            musicplay.clip = stg11;
            musicplay.Play();
        }
        if (soulqnt == 2 && musicplay.clip != stg12)
        {
            musicplay.clip = stg12;
            musicplay.Play();
        }
        if (soulqnt == 3 && musicplay.clip != stg13)
        {
            musicplay.clip = stg13;
            musicplay.Play();
        }

        if (soulqnt == 4 && musicplay.clip != stg21)
        {
            musicplay.clip = stg21;
            musicplay.Play();
        }
        if (soulqnt == 5 && musicplay.clip != stg22)
        {
            musicplay.clip = stg22;
            musicplay.Play();
        }
        if (soulqnt == 6 && musicplay.clip != stg23)
        {
            musicplay.clip = stg23;
            musicplay.Play();
        }

        if (soulqnt == 8 && musicplay.clip != stg3)
        {
            musicplay.clip = stg3;
            musicplay.Play();
        }
    }
}
