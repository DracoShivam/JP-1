using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
   // public GameObject propeller;
    private float spinSpeed = 1200;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}
