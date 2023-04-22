using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveEnemySpawnerInstant : MonoBehaviour
{
    public float sunSpawnRate;
    private float sunSpawnTimer = 0.0f;

    public Transform playerTargetPos;

    public GameObject sunBeam;

    // Start is called before the first frame update
    void Start()
    {
        playerTargetPos = GameObject.Find("PlayerSunBeamTarget").transform;

        sunBeam = Resources.Load<GameObject>("Sun Beam");
    }

    // Update is called once per frame
    void Update()
    {
        sunSpawnTimer += Time.fixedDeltaTime;

        if (sunSpawnTimer >= sunSpawnRate)
        {
            Instantiate(sunBeam, playerTargetPos.position, playerTargetPos.localRotation);
            sunSpawnTimer = 0.0f;
        }
    }
}
