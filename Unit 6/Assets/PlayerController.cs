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
    }

    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        var xPos = horiz * moveSpeed;
        var vPos = vert * moveSpeed;

        var moveDirection = new Vector3(xPos, 0, vPos);

        if (!controller.isGrounded)
        {
            moveDirection.y -= gravity;// * Time.deltaTime;
            Debug.Log("Fall");
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
                moveDirection.y = jumpForce;// * -2 * gravity;
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

        controller.Move(moveDirection * Time.deltaTime);
    }
}
