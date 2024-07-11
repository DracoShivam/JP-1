using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
//public int PlayerSpeed = 20;
{
    public float speed = 5.0f;
    public float turnSpeed = 25.0f;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // declaring movement inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // doing the movement
        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
          
    }
}
