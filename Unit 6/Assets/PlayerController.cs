using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    //[SerializeField] private float turnSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;

    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        Debug.Log("Test test!");
        isJumping = true;
    }

    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        //var xPos = horiz * moveSpeed;
        //var zPos = vert * moveSpeed;

        var velocity = new Vector3(horiz, 0, vert) * moveSpeed;
        Debug.Log("Start: " + moveDirection.y);


        if (!controller.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
            Debug.Log("Fall :" + moveDirection.y);
        }
        else
        {
            moveDirection.y = 0;
            isJumping = false;
            Debug.Log("Stop");
        }

        if (Input.GetButton("Jump"))
        {
            if (controller.isGrounded || !isJumping)
            {
                moveDirection.y = jumpForce;
                isJumping = true;
            }
        }

        /*if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            isJumping = true;
            Debug.Log("Whee");
            moveDirection.y -= gravity * Time.deltaTime;
        }

        if (isJumping)
        {
            //transform.Translate(Vector3.up * jumpForce * Time.deltaTime);
            moveDirection.y = jumpForce * 2 * gravity;
            isJumping = false;
            Debug.Log("Boing");
        }*/

        Debug.Log("End :" + moveDirection.y);

        var move = moveDirection + velocity;
        controller.Move(move * Time.deltaTime);
    }
}
