using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Movement : MonoBehaviour
{

    private Vector3 mouseposition;
    public float playerspeed;
    public int soulcount;
    private Vector3 startpos1;
    GameObject obj;
    public Animator animator;

    private AudioSource audioplay;
    public AudioClip death;
    public AudioClip dooropen;
    public AudioClip nextlevel;
    public AudioClip soulpickup;
    public CinemachineVirtualCamera vcam;

    public int FOV;

    public bool end;

    void Start()
    {
        end = false;
        transform.position = new Vector2(-10,0);
        startpos1 = transform.position;
        DontDestroyOnLoad(gameObject);
        audioplay = GetComponent<AudioSource>();
    }

    void LateUpdate()
    {
        obj = GameObject.FindGameObjectWithTag("LevelLoad");
        soulcount = GameObject.FindGameObjectWithTag("SoulPlayer").GetComponent<Soulmove>().soulqnt;
        if (!end)
        {
            mouseposition = Input.mousePosition;
            mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
            transform.position = Vector2.MoveTowards(transform.position, mouseposition, playerspeed * Time.deltaTime);
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            transform.position = Vector2.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("Galaxy").transform.position, 5 * Time.deltaTime);
            vcam.m_Lens.OrthographicSize += 0.01f;
            if(vcam.m_Lens.OrthographicSize>=19)
            {
                obj.GetComponent<LevelLoader>().LoadNextLevel(4);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collison)
    {
        if (collison.gameObject.tag == "SoulObj")
        {
            GameObject.FindGameObjectWithTag("SoulPlayer").GetComponent<Soulmove>().soulqnt += 1;
            Destroy(collison.gameObject);
            audioplay.PlayOneShot(soulpickup, 0.7f);
        }

        if (collison.gameObject.tag == "Door")
        {
            if(soulcount == 1)
            {
                Destroy(collison.gameObject);
                audioplay.PlayOneShot(dooropen, 0.7f);
            }
        }

        if (collison.gameObject.tag == "Door2")
        {
            if (soulcount == 2)
            {
                Destroy(collison.gameObject);
                audioplay.PlayOneShot(dooropen, 0.7f);
            }
        }

        if (collison.gameObject.tag == "Door3")
        {
            if (soulcount == 3)
            {
                Destroy(collison.gameObject);
                audioplay.PlayOneShot(dooropen, 0.7f);
            }
        }


        if (collison.gameObject.tag == "Level2Door2")
        {
            if (soulcount == 6)
            {
                Destroy(collison.gameObject);
                audioplay.PlayOneShot(dooropen, 0.7f);
            }
        }

        if (collison.gameObject.tag == "Level2Door3")
        {
            if (soulcount == 7)
            {
                Destroy(collison.gameObject);
                audioplay.PlayOneShot(dooropen, 0.7f);
            }
        }

        if (collison.gameObject.tag == "Level3Door1")
        {
            if (soulcount == 9)
            {
                Destroy(collison.gameObject);
                audioplay.PlayOneShot(dooropen, 0.7f);
            }
        }



        if (collison.gameObject.tag == "Enemy")
        {
            transform.position = startpos1;
            audioplay.PlayOneShot(death, 0.7f);
        }

        if (collison.gameObject.tag == "Level2")
        {
            Destroy(collison.gameObject);
            animator.SetInteger("playerstate", 1);
            GameObject.FindGameObjectWithTag("SoulPlayer").GetComponent<Soulmove>().soulqnt += 1;
            audioplay.PlayOneShot(nextlevel, 0.7f);
            obj.GetComponent<LevelLoader>().LoadNextLevel(2);
        }

        if (collison.gameObject.tag == "Level3")
        {
            Destroy(collison.gameObject);
            animator.SetInteger("playerstate", 2);
            GameObject.FindGameObjectWithTag("SoulPlayer").GetComponent<Soulmove>().soulqnt += 1;
            audioplay.PlayOneShot(nextlevel, 0.7f);
            obj.GetComponent<LevelLoader>().LoadNextLevel(3);
        }

        if (collison.gameObject.tag == "DoorEnd")
        {
            if (soulcount == 10)
            {
                Destroy(collison.gameObject);
                end = true;
                audioplay.PlayOneShot(dooropen, 0.7f);
            }
        }

    }


}
