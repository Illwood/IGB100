using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rigidBody;
    private float speed = 100.0f;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        if (gameObject.CompareTag("Up"))
        {
            rigidBody.velocity = speed * Time.fixedDeltaTime * transform.up;
        }
        else if (gameObject.CompareTag("Left"))
        {
            rigidBody.velocity = speed * Time.fixedDeltaTime * -transform.right;
        }
        else if (gameObject.CompareTag("Down"))
        {
            rigidBody.velocity = speed * Time.fixedDeltaTime * -transform.up;
        }
        else if (gameObject.CompareTag("Right"))
        {
            rigidBody.velocity = speed * Time.fixedDeltaTime * transform.right;
        }
    }
}
