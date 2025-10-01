using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class PlayerMovement : MonoBehaviour
{
    public Transform position;
    public Transform Camera;
    public Vector3 start;
    public Vector3 finish;
    public float step;
    private float progress1;
    private float progress2;
    public Vector3 direction;
    public bool flag = false;
    float lastTime;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = start;
        lastTime = Time.time;
    }

    // Update is called once per frame

    // bool flagC = true;
    float height = 2.0f;
    float deltaHeight = 1.0f;
    //   float deltaHeightCamera = 2.0f;

    void FixedUpdate()
    {

        /*    direction.x = 3;
            transform.Translate(direction * Time.deltaTime);
            Thread.Sleep(1000);
            direction.x = -3;
            transform.Translate(direction * Time.deltaTime);
        */

        /*
        if (Input.GetKeyDown(KeyCode.S) && (Time.time - lastTime > 5.0f))
        {

            lastTime = Time.time;
            flagC = false;
        }
        */
        /*
        if (Input.GetKey("w") && (Time.time - lastTime > 1.0f))
        {
            position.transform.position = new Vector3(0, deltaHeight, 0);
            start += new Vector3(0, deltaHeight, 0);
            finish += new Vector3(0, deltaHeight, 0);
        }
        if (Input.GetKey("s") && (Time.time - lastTime > 1.0f))
        {
            position.transform.position = new Vector3(0, -deltaHeight, 0);
            start += new Vector3(0, -deltaHeight, 0);
            finish += new Vector3(0, -deltaHeight, 0);
        }
        */
        if (Input.GetKey("space") && (Time.time - lastTime > 1.0f))
        {
            lastTime = Time.time;
            //flagC = true;
            var FallCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            FallCube.tag = "Box";
            Vector3 FallCube_Vector = new Vector3(transform.position.x, height, transform.position.z);

            //if(Camera.position.x > 3)
            //Camera.transform.position = new Vector3(transform.position.x, height + 0.1f, transform.position.z);
            //position.transform.position = new Vector3(transform.position.x, transform.position.y + 1.0f, transform.position.z);
            //var direction1 = new Vector3(0, 1.0f, 0);
            //position.transform.Translate(direction1 * Time.deltaTime);

            // position.transform.Translate(new Vector3(0, 1.0f, 0) * Time.deltaTime);
            position.transform.position = new Vector3(0, deltaHeight, 0);
            start += new Vector3(0, deltaHeight, 0);
            finish += new Vector3(0, deltaHeight, 0);
            //Camera.position.y = 3.0f;
            height += deltaHeight;


            FallCube.transform.position = FallCube_Vector;
            FallCube.name = "brown_cube";
            FallCube.AddComponent<Rigidbody>();
            // FallCube.tag = "FallCube";



            //FallCube.AddComponent<Rigidbody>;



            /*
            Vector3 FallCube_Vector = new Vector3(0, 15, 10);
            Vector3 FallCube_Scale = new Vector3(10, 10, 10);
            GameObject myGameObject = new GameObject("Test Object"); // Make a new GO.
            Rigidbody gameObjectsRigidBody = myGameObject.AddComponent<Rigidbody>(); // Add the rigidbody.
            gameObjectsRigidBody.mass = 5; // Set the GO's mass to 5 via the Rigidbody.
            gameObjectsRigidBody.position = FallCube_Vector;
            gameObjectsRigidBody.transform.localScale = FallCube_Scale;
            gameObjectsRigidBody.*/
        }

        if (flag)
        {
            transform.position = Vector3.Lerp(start, finish, progress1);
            progress1 += step;
        }
        else
        {
            transform.position = Vector3.Lerp(finish, start, progress2);
            progress2 += step;
        }
        if (transform.position.x == 2)
        {
            //    transform.Translate(-direction * Time.deltaTime);
            //    direction = -direction;
            flag = false;
            transform.position = finish;
            // progress1 = 0;
            progress1 = 0;

        }
        if (transform.position.x == -2)
        {
            //      transform.Translate(direction * Time.deltaTime);
            //    direction = -direction;
            flag = true;
            transform.position = start;
            /// progress1 = 0;
            progress2 = 0;
        }
        // transform.position = finish;
        // transform.position = Vector3.Lerp(finish, start, progress);
        // progress += step;
    }
}
