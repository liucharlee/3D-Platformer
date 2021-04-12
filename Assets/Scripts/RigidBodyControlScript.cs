using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyControlScript : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float speed;
    

    //public float rotate = 0f;
    //public float forward = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //rb.MovePosition(rb.position + (transform.forward * speed * forward * Time.fixedDeltaTime));
        //rb.MoveRotation(Quaternion.AngleAxis(rotate * turnSpeed, Vector3.up) * rb.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddTorque(Vector3.up * turnSpeed); //add Rotation
        rb.AddRelativeForce(new Vector3(speed, 0.0f, 0.0f)); //add force in direction of movement
    }
}
