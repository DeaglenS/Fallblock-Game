using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class PlayerBoxMovement : MonoBehaviour
{
    public Rigidbody playerBox;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerBox.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        Thread.Sleep(100000);
        playerBox.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
    }
}
