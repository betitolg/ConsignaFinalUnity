using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 2000f)]
    private float moveForce = 10f;

    private Rigidbody myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        //myRigidbody.AddForce(Vector3.forward);
        //myRigidbody.AddForce(Vector3.forward* 10f);
        myRigidbody.AddForce(Vector3.forward * moveForce);
    }

   
}
