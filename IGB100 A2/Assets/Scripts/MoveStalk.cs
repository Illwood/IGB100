using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStalk : MonoBehaviour
{
    private Rigidbody rigidBody;
    public float speed;
    public float rotateSpeed;

    private float lastMouseX;
    private float lastMouseY;

    public bool boosting = false;

    public GrowthBarBehaviour growthBar;
    public float growthDepleteRate = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move upwards every frame
        if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.Space))
        {
            boosting = true;
            growthBar.healthRate = growthDepleteRate * 2;
            rigidBody.velocity = speed * Time.fixedDeltaTime * transform.forward * 2;
        }
        else
        {
            boosting = false;
            growthBar.healthRate = growthDepleteRate;
            rigidBody.velocity = speed * Time.fixedDeltaTime * transform.forward;
        }

        // Rotate every frame depending on input
        RotateUpdate();
    }

    private void RotateUpdate()
    {
        // Vectors for each turning direction
        Vector3 spinLeft = new Vector3(0, 0, 1);
        Vector3 spinRight = new Vector3(0, 0, -1);
        Vector3 turnUp = new Vector3(-1, 0, 0);
        Vector3 turnDown = new Vector3(1, 0, 0);
        Vector3 turnLeft = new Vector3(0, -1, 0);
        Vector3 turnRight = new Vector3(0, 1, 0);

        // WASD Input
        //
        // Turn Left
        if (Input.GetKey("a"))
        {
            this.transform.Rotate(turnLeft * rotateSpeed * Time.fixedDeltaTime);
            Debug.Log("Left_Key_Rotate");
        }

        // Turn Right
        if (Input.GetKey("d"))
        {
            this.transform.Rotate(turnRight * rotateSpeed * Time.fixedDeltaTime);
            Debug.Log("Right_Key_Rotate");
        }

        // Turn Down
        if (Input.GetKey("w"))
        {
            this.transform.Rotate(turnDown * rotateSpeed * Time.fixedDeltaTime);
            Debug.Log("Down_Key_Rotate");
        }

        // Turn Up
        if (Input.GetKey("s"))
        {
            this.transform.Rotate(turnUp * rotateSpeed * Time.fixedDeltaTime);
            Debug.Log("Up_Key_Rotate");
        }

        // Spin Left
        if (Input.GetKey("q"))
        {
            this.transform.Rotate(spinLeft * rotateSpeed * Time.fixedDeltaTime);
            Debug.Log("Left_Spin_Key_Rotate");
        }

        // Spin Right
        if (Input.GetKey("e"))
        {
            this.transform.Rotate(spinRight * rotateSpeed * Time.fixedDeltaTime);
            Debug.Log("Right_Spin_Key_Rotate");
        }

        // Mouse Input (Basic)
        // (Based on if mouse is 5/16 or 11/16 of width/height)
        //
        // Turn Left
        if (Input.mousePosition.x < (5 * (Screen.width / 16)))
        {
            this.transform.Rotate(turnLeft * rotateSpeed * Time.fixedDeltaTime);
            Debug.Log("Left_Mouse_Rotate");
        }

        // Turn Right
        if (Input.mousePosition.x > (11 * (Screen.width / 16)))
        {
            this.transform.Rotate(turnRight * rotateSpeed * Time.fixedDeltaTime);
            Debug.Log("Right_Mouse_Rotate");
        }

        // Turn Down
        if (Input.mousePosition.y < (5 * (Screen.height / 16)))
        {
            this.transform.Rotate(turnDown * rotateSpeed * Time.fixedDeltaTime);
            Debug.Log("Down_Mouse_Rotate");
        }

        // Turn Up
        if (Input.mousePosition.y > (11 * (Screen.height / 16)))
        {
            this.transform.Rotate(turnUp * rotateSpeed * Time.fixedDeltaTime);
            Debug.Log("Up_Mouse_Rotate");
        }

        // Spin Left
        if (Input.GetMouseButton(0) == true)
        {
            this.transform.Rotate(spinLeft * rotateSpeed * Time.fixedDeltaTime);
            Debug.Log("Left_Spin_Mouse_Rotate");
        }

        // Spin Right
        if (Input.GetMouseButton(1) == true)
        {
            this.transform.Rotate(spinRight * rotateSpeed * Time.fixedDeltaTime);
            Debug.Log("Right_Spin_Mouse_Rotate");
        }
    }
}
