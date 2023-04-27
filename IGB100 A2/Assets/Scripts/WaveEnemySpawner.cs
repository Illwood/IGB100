using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveEnemySpawner : MonoBehaviour
{
    public float sunSpawnRate;
    private float sunSpawnTimer = 0.0f;
    public Transform playerTargetPos;
    public GameObject sunBeamSpawner;

    public GameObject rainCloud;
    private Vector3 rainPos;

    // Start is called before the first frame update
    void Start()
    {
        playerTargetPos = GameObject.Find("PlayerSunBeamTarget").transform;
        sunBeamSpawner = Resources.Load<GameObject>("SunBeamSpawner");

        rainCloud = Resources.Load<GameObject>("RainCloud");

        for (int i = 1; i < 9; i++)
        {
            rainPos = new Vector3(Random.Range(-25, 25), (120 * i), Random.Range(-25, 25));
            Instantiate(rainCloud, rainPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        sunSpawnTimer += Time.deltaTime;

        if (sunSpawnTimer >= sunSpawnRate)
        {
            Instantiate(sunBeamSpawner, playerTargetPos.position, playerTargetPos.rotation);
            sunSpawnTimer = 0.0f;
        }
    }
}
