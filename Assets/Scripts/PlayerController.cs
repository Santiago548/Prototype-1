using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInupt;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInupt = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInupt * Time.deltaTime);
    }
}
