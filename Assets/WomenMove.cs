using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomenMove : MonoBehaviour
{

    //Ny kod från Test2Move

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
        //animator.SetFloat("Speed", movement.magnitude);
        //animator.SetFloat("DirectionX", movement.x);

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





    //Gammal kod - funkar för movement men ej för flip character dvs byta animation fr höger till vänster
    /*public float speed = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(h, v);

        if (movement != Vector2.zero)
        {
            GetComponent<Rigidbody2D>().velocity = movement.normalized * speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        // Animation Parameters
        Vector2 dir = movement - (Vector2)transform.position;
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        

    }*/
}
