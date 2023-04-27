using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public float rainHealthRate = 5.0f;
    public float sunBeamDamage = 20.0f;

    public GrowthBarBehaviour growthBar;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            growthBar.health -= sunBeamDamage;
            Debug.Log("Player_Hit_Enemy");
        }
    }
    
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Rain")
        {
            growthBar.health += rainHealthRate;
            Debug.Log("Player_Hit_Rain");
        }
    }
}
