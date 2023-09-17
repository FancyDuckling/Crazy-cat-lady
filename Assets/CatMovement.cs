using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{

    public float minSpeed = 0.2f;      // Minimum movement speed
    public float maxSpeed = 0.5f;      // Maximum movement speed
    public float changeInterval = 2f; // Time interval for changing movement direction

    private Rigidbody2D rb2D;
    private Vector2 movementDirection;
    private float elapsedTime = 0f;


    //från Coin
    public GameObject playerObject;

    Transform target; //hitta spelaren

    private void Start()
    {
        

        rb2D = GetComponent<Rigidbody2D>();

        // Initialize the first movement direction
        RandomizeMovementDirection();
        
    }

    private void Update()
    {
        // Update the elapsed time
        elapsedTime += Time.deltaTime;

        // Check if it's time to change direction
        if (elapsedTime >= changeInterval)
        {
            RandomizeMovementDirection();
            elapsedTime = 0f;
        }


    }

    private void FixedUpdate()
    {
        // Move the sprite in the current movement direction
        rb2D.velocity = movementDirection * Random.Range(minSpeed, maxSpeed);
        
        
        // Flip the character's sprite if moving left , kod from Women
        if (movementDirection.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (movementDirection.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    private void RandomizeMovementDirection()
    {
        // Generate a random direction vector
        movementDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }


    //från Coin
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject == playerObject)
        {
            Death();
        }
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
