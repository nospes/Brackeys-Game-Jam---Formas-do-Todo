using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soulmove : MonoBehaviour
{

    private Vector2 playerposition;
    public Animator animator;
    public int soulqnt;

    void Update()
    {
        animator.SetInteger("Soul",soulqnt);
        playerposition = GameObject.FindGameObjectWithTag("Player").transform.position;
        transform.position = new Vector3(playerposition.x, playerposition.y, -1);
    }
}
