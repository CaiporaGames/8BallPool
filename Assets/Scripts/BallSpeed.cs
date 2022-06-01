using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeed : MonoBehaviour
{
    [SerializeField] float stopSpeed = 0.1f;
    Vector3 stopSpeedVector;
    float stopSpeedVectorMagnitude;
    Rigidbody rb;

    Vector3 startPosition;

    void Start()
    {
        stopSpeedVector = new Vector3(stopSpeed, stopSpeed, stopSpeed);
        stopSpeedVectorMagnitude = stopSpeedVector.magnitude;
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.velocity.magnitude <= stopSpeedVectorMagnitude)
        {
            rb.velocity = Vector3.zero;
        }
        else
        {
           // Debug.Log("111");
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            SetStartPosition();
        }
    }

    void SetStartPosition()
    {
        transform.position = startPosition;
        rb.velocity = Vector3.zero;
    }
}
