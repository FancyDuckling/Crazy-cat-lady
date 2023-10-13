using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public StillKatt targetKatt; // Reference to the StillKatt script attached to the other GameObject.

    private void Start()
    {
        // You can either set the reference manually in the Inspector or find it at runtime.
       targetKatt = FindObjectOfType<StillKatt>(); // If you want to find the StillKatt script at runtime.
    }

    private void OnMouseOver()
    {
        if (targetKatt != null)
        {
            targetKatt.TriggerAnimation();
        }
    }
}
