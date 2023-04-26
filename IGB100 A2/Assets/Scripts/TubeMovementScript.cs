using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeMovementScript : MonoBehaviour
{
    public Transform target; //This is the object the Tube will be following
    public Vector3 Offset; //Used for the X and Z value atm, designed to be left at zero
    private Vector3 TargetedPosition;
    private float DegressPerSecond = 20;

    // Update is called once per frame
    void Update()
    {
        //Converting the target's transform into a vector
        TargetedPosition = target.position; 
        //Taking the target's Y value for the tube to follow, meanwhile the Z and X will stay at the value set in the offset.
        transform.position = new Vector3(Offset.x, (TargetedPosition.y - 50), Offset.z);

        transform.Rotate(new Vector3(0, DegressPerSecond, 0) * Time.deltaTime);
    }
}
