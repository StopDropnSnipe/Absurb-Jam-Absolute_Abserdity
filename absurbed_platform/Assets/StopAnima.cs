﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnima : MonoBehaviour
{
    //refer to Animator in here and inspector
    public Animator Anima;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            //disables the animator
            Anima.enabled = false;
        }
    }
}
