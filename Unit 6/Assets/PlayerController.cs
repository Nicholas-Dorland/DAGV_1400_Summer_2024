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
    [SerializeField] private float height = 2;
    [SerializeField] private float crouchHeight = 1;

    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        Debug.Log("Test test!");
        isJumping = true;
        controller.height = height;
    }

    void Update()
    {
        var velocity = new Vector3(0, 0, 0);
        if (Input.GetButton("Crouch"))
        {
            float horiz = Input.GetAxis("Horizontal");
            float vert = Input.GetAxis("Vertical");

            velocity.x = horiz * (moveSpeed - 2);
            velocity.z = vert * (moveSpeed - 2);

            controller.height = crouchHeight;
        }
        else if (Input.GetButton("Sprint"))
        {
            float horiz = Input.GetAxis("Horizontal");
            float vert = Input.GetAxis("Vertical");

            velocity.x = horiz * (moveSpeed + 3);
            velocity.z = vert * (moveSpeed + 3);
        }
        else
        {
            float horiz = Input.GetAxis("Horizontal");
            float vert = Input.GetAxis("Vertical");

            velocity = new Vector3(horiz, 0, vert) * moveSpeed;
        }


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

        if (!Input.GetButton("Crouch"))
        {
            if (controller.height < height)
            {
                controller.height += height * Time.deltaTime;
                if (controller.height > height)
                {
                    controller.height = height;
                }
            }
        }

        var move = moveDirection + velocity;
        controller.Move(move * Time.deltaTime);
    }
}
