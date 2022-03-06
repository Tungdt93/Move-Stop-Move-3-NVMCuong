using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Animator Anim;
    public float Speed;
    
    // Start is called before the first frame update
    private void Awake()
    {
        Anim = GetComponent<Animator>();
    }

    public void Move()
    {
        Anim.SetBool("IsIdle",false);
        Anim.SetBool("IsAttack",false);
    }

    // Update is called once per frame
    public void Attack()
    {
        Anim.SetBool("IsAttack",true);
    }

    public void OnDeath()
    {
        Anim.SetBool("IsDead",true);
    }

    public void OnHit()
    {
        
    }

    public void Win()
    {
        Anim.SetBool("IsWin",true);
    }
}
