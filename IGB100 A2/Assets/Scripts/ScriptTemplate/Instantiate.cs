using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject cube;
    public GameObject cubes;
    public float instantiateRate;
    private float nextInstantiate;
    public GameObject other;
    public float rotation;
    public Transform spawnPosition;

    void Start()
    {
        cube = Resources.Load<GameObject>("Cube");
        nextInstantiate = Time.time + instantiateRate;
        other = GameObject.Find("Other");
        spawnPosition = GameObject.Find("Spawn Position").transform;
    }

    void Update()
    {
        InstantiateCube();

        //InstantiateCubeTimer();

        //InstantiateInParent();

        //InstantiateInOther();

        //InstantiateCubeRotate();
    }

    private void InstantiateCube()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(cube, spawnPosition.position, spawnPosition.rotation);
        }
    }

    private void InstantiateCubeTimer()
    {
        if (Time.time > nextInstantiate)
        {
            Instantiate(cube, spawnPosition.position, spawnPosition.rotation);
            nextInstantiate = Time.time + instantiateRate;
        }
    }

    private void InstantiateInParent()
    {
        if (Input.GetKeyDown("space"))
        {
            cubes = Instantiate(cube, transform.position, transform.rotation);
            cubes.transform.parent = this.gameObject.transform;
        }
    }

    private void InstantiateInOther()
    {
        if (Input.GetKeyDown("space"))
        {
            cubes = Instantiate(cube, other.transform.position, other.transform.rotation);
            cubes.transform.parent = other.gameObject.transform;
        }
    }

    private void InstantiateCubeRotate()
    {
        if (Input.GetKeyDown("space"))
        {
            Quaternion spawnRotation = Quaternion.AngleAxis(rotation, Vector3.back);
            Instantiate(cube, spawnPosition.position, spawnRotation);
        }
    }
}
