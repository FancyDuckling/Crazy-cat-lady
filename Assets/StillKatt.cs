using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StillKatt : MonoBehaviour
{
    //public Animator myAnimator;

    public Animator myAnimator;

    private void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    public void TriggerAnimation()
    {
        myAnimator.SetTrigger("Play");
    }





    /*void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        myAnimator.SetTrigger("Play");
    }*/

}
