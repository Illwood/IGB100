using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveEnemySpawner : MonoBehaviour
{
    public float sunSpawnRate;
    private float sunSpawnTimer = 0.0f;

    public Transform playerTargetPos;

    public GameObject sunBeamSpawner;

    // Start is called before the first frame update
    void Start()
    {
        playerTargetPos = GameObject.Find("PlayerSunBeamTarget").transform;

        sunBeamSpawner = Resources.Load<GameObject>("SunBeamSpawner");
    }

    // Update is called once per frame
    void Update()
    {
        sunSpawnTimer += Time.fixedDeltaTime;

        if (sunSpawnTimer >= sunSpawnRate)
        {
            Instantiate(sunBeamSpawner, playerTargetPos.position, playerTargetPos.rotation);
            sunSpawnTimer = 0.0f;
        }
    }
}
