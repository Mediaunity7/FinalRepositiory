using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]float movementspeed = 6f;
    [SerializeField]float jumpforce = 5f;

        [SerializeField] Transform groundCheck;
        [SerializeField] LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizaontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        rb.velocity = new Vector3(horizaontalInput * movementspeed, rb.velocity.y, verticalInput * movementspeed);

        if(Input.GetButtonDown("Jump") && Grounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpforce, rb.velocity.z);
        }
    }
    
    bool Grounded() // to jump only when the player hits the ground 
    {
       return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
    
}
