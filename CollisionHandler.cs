using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private Animator animator;
    private bool isPaused = false;
     
    void Start()
    {
        animator = GetComponent<Animator>();
        TogglePause();
    }


    public void TogglePause()
    {

        isPaused = !isPaused;


        if (isPaused)
        {

            animator.speed = 0f;
        }
        else
        {

            animator.speed = 1f;
        }
    }
}
