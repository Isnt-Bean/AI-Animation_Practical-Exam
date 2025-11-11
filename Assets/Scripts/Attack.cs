using System;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) ||
            Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("IsWalking", true);
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("IsWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            animator.SetBool("IsCrouching", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetBool("IsCrouching", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Zombie")
        {
            animator.SetBool("isAttacking", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("isAttacking", false);
    }
}
