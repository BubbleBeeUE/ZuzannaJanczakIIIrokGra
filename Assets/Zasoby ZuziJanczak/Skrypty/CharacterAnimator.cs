using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class CharacterAnimator : MonoBehaviour

{
    private Animator animator;
    private bool isJumping;
    private bool isGrounded;
    public float health;


    private bool isDead;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude > 0.1f)
        {
            animator.SetBool("IsMoving", true);

            animator.SetBool("Dance", false);

            animator.SetBool("IsDead", false);
        }
        if (direction.magnitude < 0.1f)
        {
            animator.SetBool("IsMoving", false);

        }

        if (Input.GetKey("q"))
        {

            animator.SetBool("Dance", true);

        }


        if (health <= 0 && !isDead)
        {
            animator.SetBool("IsDead", true);
        }
       if (health > 0)
        {
            animator.SetBool("IsDead", false);
        }






    }
   

}
