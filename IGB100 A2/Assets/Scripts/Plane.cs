using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public Transform target; //This is the object the plane will be following
    public Vector3 Offset; //Only used for the y value atm
    private Vector3 TargetedPosition;

    // Update is called once per frame
    void Update()
    {
        //Converting the target's transform into a vector
        TargetedPosition = target.position; 
        //Taking the target's X and Z values for the plane to follow, meanwhile the Y will stay at the value set in the offset.
        transform.position = new Vector3(TargetedPosition.x, Offset.y, TargetedPosition.z); 
    }
}
