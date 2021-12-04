using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /// PRIVATE ///
    private Rigidbody playerRB;
    private Collider playerCollider;

    /// PUBLIC ///
    public float upThrustAmount = 1000f;
    public float rotationSpeed = 100f;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerCollider = GetComponent<Collider>();    
    }

    // Update is called once per frame
    void Update()
    {
        ShipMovement();
    }
    public void ShipMovement()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerRB.AddRelativeForce(Vector3.up * upThrustAmount * Time.deltaTime);
            Debug.Log("Trying too thrust");
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            playerRB.freezeRotation = true;
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            playerRB.freezeRotation = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRB.freezeRotation = true;
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
            playerRB.freezeRotation = false;
        }
    }
}
