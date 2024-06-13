using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float turnSpeed = 5f;
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
        float xPos = horiz * moveSpeed;
        float vPos = vert * moveSpeed;

        transform.position = new Vector3(xPos, 0, vPos);

        if (Input.GetButtonDown("Jump") /*&& controller.isGrounded*/)
        {
            isJumping = true;
            Debug.Log("Whee");
        }

        moveDirection.y -= gravity * Time.deltaTime;

        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }*/

        //if (Input.GetKey(KeyCode.Space) /*&& controller.isGrounded*/)
        /*{
            isJumping = true;
        }*/

        /*if (!controller.isGrounded)
        {
            transform.Translate(-Vector3.up * gravity * Time.deltaTime);
            Debug.Log("Touchdown");
        }*/

        if (isJumping)
        {
            transform.Translate(Vector3.up * jumpForce * Time.deltaTime);
            //moveDirection.y = jumpForce;
            isJumping = false;
            Debug.Log("Boing");
        }
    }
}
