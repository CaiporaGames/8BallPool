using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour
{
    [SerializeField] float forceMagnitude = 3f;
    [SerializeField] Camera mainCamera;


    Rigidbody rb;
    Vector3 forceDirection;
    Vector3 mouseWorldPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            forceDirection = transform.position - mouseWorldPosition;
            rb.AddForce(forceDirection * Time.deltaTime * forceMagnitude, ForceMode.Impulse);
        }
    }
}
