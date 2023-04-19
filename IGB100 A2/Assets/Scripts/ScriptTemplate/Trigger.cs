using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trigger")
        {
            Debug.Log("Trigger");
        }
    }

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.tag == "Trigger")
    //    {
    //        Debug.Log("Trigger");
    //    }
    //}

    //void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "Trigger")
    //    {
    //        Debug.Log("Trigger");
    //    }
    //}
}
