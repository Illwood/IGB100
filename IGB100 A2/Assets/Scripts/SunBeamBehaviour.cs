using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunBeamBehaviour : MonoBehaviour
{
    public float timeAliveRate;
    private float timeAlive = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeAlive += Time.fixedDeltaTime;

        if (timeAlive >= timeAliveRate)
        {
            Destroy(this.gameObject);
        }
    }
}
