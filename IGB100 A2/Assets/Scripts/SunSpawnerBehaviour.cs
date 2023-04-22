using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSpawnerBehaviour : MonoBehaviour
{
    public float timeAliveRate;
    private float timeAlive = 0.0f;

    public Color warningAlpha;

    public GameObject sunBeam;

    public Transform playerTargetPos;
    private Quaternion sunBeamOffset;

    // Start is called before the first frame update
    void Start()
    {
        warningAlpha = GetComponent<SpriteRenderer>().color;
        sunBeam = Resources.Load<GameObject>("SunBeam");
        playerTargetPos = GameObject.Find("PlayerSunBeamTarget").transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAlive += Time.fixedDeltaTime;

        warningAlpha.a += 0.03f;
        GetComponent<SpriteRenderer>().color = warningAlpha;

        //sunBeamOffset = playerTargetPos.transform.localRotation;
        //sunBeamOffset *= Quaternion.Euler(Random.Range(-15.0f, 15.0f), Random.Range(-15.0f, 15.0f), Random.Range(-15.0f, 15.0f));

        if (timeAlive >= timeAliveRate)
        {
            Instantiate(sunBeam, this.gameObject.transform.position, playerTargetPos.transform.localRotation);
            Destroy(this.gameObject);
        }
    }
}
