using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject cube;
    private float rotateSpeed = 100.0f;

    void Start()
    {
        cube = GameObject.Find("Cube");
    }

    void Update()
    {
        RotateCube();

        //Rotation();
    }

    private void RotateCube()
    {
        cube.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }

    private void Rotation()
    {
        if (Input.GetKeyDown("space"))
        {
            cube.transform.rotation = Quaternion.AngleAxis(45, Vector3.forward);
        }
    }
}
