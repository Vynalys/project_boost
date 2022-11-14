using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainThrust = 1f;
    [SerializeField] float mainRotation = 1f;
    Rigidbody rocketBody;

    // Start is called before the first frame update
    void Start()
    {
        rocketBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
       
       if(Input.GetKey(KeyCode.Space))
       {
            rocketBody.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
       }
    }

    void ProcessRotation()
    {
          if(Input.GetKey(KeyCode.A))
        {
            getRotation(mainRotation);
        }

        else if(Input.GetKey(KeyCode.D))
       {
            getRotation(-mainRotation);
       }
    }

    private void getRotation(float rotationThisFrame)
    {
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
    }
}
