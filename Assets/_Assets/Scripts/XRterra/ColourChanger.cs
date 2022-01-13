using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    //public string tagName;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision) // preform on the object this script is attached to, on each collision
    {
        Color UpdatedColour = RandomColourSelector();
        GetComponent<Renderer>().material.color = UpdatedColour;


        /*
        if (collision.gameObject.tag == tagName) // preform on the object this script is attached to, on each collision with tagged object
        {
            Color UpdatedColour = RandomColourSelector();
            GetComponent<Renderer>().material.color = UpdatedColour;
        }
        */

    }
        


    /*
        private void OnTriggerEnter(Collider collider) // preform on the object this script is attached to, on each trigger collision
    {

        Color UpdatedColour = RandomColourSelector();
        GetComponent<Renderer>().material.color = UpdatedColour;


        if (collider.gameObject.tag == tagName) // preform on the object this script is attached to, on each trigger collision with tagged object
        {
            Color UpdatedColour = RandomColourSelector();
            GetComponent<Renderer>().material.color = UpdatedColour;
        }



    }

    */


    private Color RandomColourSelector() // Defines Colour Randomizer 
    {
        {
            return new Color
                (
                    r: UnityEngine.Random.Range(0f, 1f),
                    g: UnityEngine.Random.Range(0f, 1f),
                    b: UnityEngine.Random.Range(0f, 1f)
                );
        }
    }
}

