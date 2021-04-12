using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerMove : MonoBehaviour
{
    private CharacterController controller;

    private Vector3 moveDirection = Vector3.zero;

    //set in editor
    [SerializeField] float speed = 6.0f;
    [SerializeField] float jumpSpeed = 8.0f;
    [SerializeField] float gravity = 20.0f;


    //controls
    private float xMove;
    private float yMove;
    private bool jump;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }

    private void FixedUpdate()
    {
        /*if(controller.isGrounded)
        {*/
        moveDirection = new Vector3(xMove, 0.0f, yMove);
        moveDirection *= speed;
        //}

        //face in direction of move
        if(moveDirection.magnitude > float.Epsilon)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection);
        }

        if(controller.isGrounded)
        {
            if(jump){
                moveDirection.y = jumpSpeed;
            }
        }
        

        //Apply gravity
        moveDirection.y -= gravity * Time.fixedDeltaTime;
        controller.Move(moveDirection * Time.fixedDeltaTime);

    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxis("Horizontal");
        yMove = Input.GetAxis("Vertical");
        jump = Input.GetButton("Jump");
    }

     void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy"){
            Destroy(gameObject);
        }
    }
}
