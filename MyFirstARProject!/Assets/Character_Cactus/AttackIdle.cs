using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Animator mAnimator;

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "cactus")
        {
            mAnimator.SetTrigger("TrAttack");
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "cactus")
        {
            mAnimator.SetTrigger("TrIdle");
        }
    }
}
