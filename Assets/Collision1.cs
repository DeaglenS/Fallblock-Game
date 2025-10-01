using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision1 : MonoBehaviour
{
    public Rigidbody rb;


    private void OnCollisionEnter(Collision collisionInfo)
    {

        ///Debug.Log(collisionInfo.collider.name);
        //if (collisionInfo.collider.name == "Fence")
        if (collisionInfo.collider.tag == "Box")
        {

            Debug.Log("Hit ");
            //  Application.LoadLevel("mainscene");
            SceneManager.LoadScene("SampleScene");
            //Application.LoadLevel(Application.loadedLevelName);
        }
    }
}
