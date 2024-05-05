using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidbodycomponent;

    public Transform groundchecktransform;
    [SerializeField] private LayerMask PlayerMask;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodycomponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            jumpKeyWasPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
    }

    //Fixed Update is called once every physics update 
    private void FixedUpdate()
    {
        rigidbodycomponent.velocity = new Vector3(horizontalInput * 10, rigidbodycomponent.velocity.y, 0);

        if (Physics.OverlapSphere(groundchecktransform.position, 0.1f, PlayerMask).Length == 0)
            return;

        //players jump and side movement   
        if (jumpKeyWasPressed)
        {
            rigidbodycomponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }

    }
}


