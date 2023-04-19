using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float lifetime;

    void Update()
    {
        DestroyCube();

        //DestroyCubeTimer();
    }

    private void DestroyCube()
    {
        if (Input.GetKeyDown("space"))
        {
            Destroy(this.gameObject);
        }
    }

    private void DestroyCubeTimer()
    {
        Destroy(this.gameObject, lifetime);
    }
}
