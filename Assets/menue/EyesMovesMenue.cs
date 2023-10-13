using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesMovesMenue : MonoBehaviour
{
    public Animator animator;
    public Transform referencePoint;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        // Calculate the direction from player to mouse
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = (mousePosition - (Vector2)referencePoint.transform.position).normalized;

        // Update the Animator's parameters based on the mouse direction
        animator.SetFloat("DirX", dir.x);
        animator.SetFloat("DirY", dir.y);


    }
}
