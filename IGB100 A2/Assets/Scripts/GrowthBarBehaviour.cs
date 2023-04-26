using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GrowthBarBehaviour : MonoBehaviour
{
    public float health = 100.0f;
    public float healthMax = 100.0f;

    //public MoveStalk movestalk;
    //public Slider growthBar;

    // Start is called before the first frame update
    void Start()
    {
        //growthBar = GetComponent<Slider>();

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (movestalk.boosting == true)
        {
            health -= 0.5f;
            growthBar.value = (health / healthMax);
        }
        else
        {
            health -= 0.25f;
            growthBar.value = (health / healthMax);
        }
        */
    }
}
