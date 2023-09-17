using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Get input from arrow keys or WASD
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement vector
        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        // Normalize the vector to prevent diagonal movement from being faster
        movement.Normalize();

        // Set the character's velocity based on input and speed
        GetComponent<Rigidbody2D>().velocity = movement * moveSpeed;

        // Set animator parameters
        animator.SetFloat("Speed", movement.magnitude);
        animator.SetFloat("DirectionX", movement.x);

        // Flip the character's sprite if moving left
        if (movement.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (movement.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
