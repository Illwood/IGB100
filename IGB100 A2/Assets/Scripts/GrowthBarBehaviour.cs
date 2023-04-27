using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GrowthBarBehaviour : MonoBehaviour
{
    public float health = 100.0f;
    public float healthRate = 0.01f;

    public MoveStalk movestalk;
    public Slider growthBar;

    // Start is called before the first frame update
    void Start()
    {
        growthBar = this.GetComponent<Slider>();

    }

    // Update is called once per frame
    void Update()
    {
        health -= healthRate;
        growthBar.value = health;

        if (health <= 0)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }

    }
}
