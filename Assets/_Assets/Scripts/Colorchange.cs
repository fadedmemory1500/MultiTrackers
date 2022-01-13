using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchange : MonoBehaviour
{
    public Color zoneColor;
    public Color originalColor;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("it works");
            gameObject.GetComponent<Renderer>().material.color = zoneColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("it works exit");
            gameObject.GetComponent<Renderer>().material.color = originalColor;
        }
    }
}
