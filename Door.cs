using System.Collections;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator anim;
    public Transform player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Not Detected Car"))
        {
            anim.SetBool("Near", true);
            other.tag = "Gate Detected Car";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Gate Detected Car"))
        {
            anim.SetBool("Near", false);
        }
    }

    void Update()
    {
        if (player == null)
        {
            Debug.Log("Player is null");
            player = Camera.main?.transform;
            
        }
    }
}
