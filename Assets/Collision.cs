using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody rb;


    private void OnCollisionEnter(Collision collisionInfo)
    {

        ///Debug.Log(collisionInfo.collider.name);
        //if (collisionInfo.collider.name == "Fence")
        if (collisionInfo.collider.tag == "Box")
        {



        }
    }
}
