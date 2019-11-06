using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;
    public float speed = 40;
    float horizontalMove = 0f;
    bool jump = false;
    bool slide = false;

    // Use this for initialization
    void Start () {
		
	}

    // get input from player
    void Update () {
        horizontalMove = Mathf.Abs(Input.GetAxisRaw("Horizontal") * speed);
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }
        // TODO: implement sliding with animation
        if (Input.GetButtonDown("Slide"))
        {
            slide = true;
        } else if(Input.GetButtonUp("Slide"))
        {
            slide = false;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    // appy input received in Update()
    private void FixedUpdate()
    {
        controller.Move(0, slide, jump);
        jump = false;
    }
}
