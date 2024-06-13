using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;

    private CharacterController controller;
    private Vector2 moveDirection;
    private bool isJumping;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        moveDirection = new Vector2();
        Debug.Log("Test test!");
    }

    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveDirection.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            isJumping = true;
        }

        moveDirection.y += gravity * Time.deltaTime;

        moveDirection.x = moveSpeed;

        if (isJumping)
        {
            moveDirection.y = jumpForce;
            isJumping = false;
        }
    }
}
