using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;
    public float speed = 40;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Use this for initialization
    void Start () {
		
	}

    // get input from player
    void Update () {
        horizontalMove = Mathf.Abs(speed);
        Debug.Log("horiz: " + horizontalMove);
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
             animator.SetBool("isJumping", true);
        }
        // TODO: implement sliding with animation
        if (Input.GetButtonDown("Slide"))
        {
            crouch = true;
        } else if(Input.GetButtonUp("Slide"))
        {
            crouch = false;
        }

    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
        jump = false;
    }

    // appy input received in Update()
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
