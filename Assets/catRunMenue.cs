using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class catRunMenue : MonoBehaviour
{
    public float minSpeed = 0.2f;      // Minimum movement speed
    public float maxSpeed = 0.5f;      // Maximum movement speed
    public float changeInterval = 2f; // Time interval for changing movement direction

    private Rigidbody2D rb2D;
    private Vector2 movementDirection;
    private float elapsedTime = 0f;



    private void Start()
    {


        rb2D = GetComponent<Rigidbody2D>();

       

    }

    private void Update()
    {
     


    }

    private void FixedUpdate()
    {
        
    }

    



}

