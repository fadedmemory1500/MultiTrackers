using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectGenerator : MonoBehaviour
{
    // Public Parameter to define Object Information
    public GameObject generationPoint, objectToGenerate;

    // Internal Containers to define updated Object Information
    private Vector3 generatedObjectPosition;
    private Quaternion generatedObjectRotation;
    private bool generateMultiObjects;
    private bool generateSingleObjects;
  
    // Start is called before the first frame update
    // Keep Start in script to keep enable or disable as a Public Parameter
    void Start()
    {
        generateMultiObjects = false;
        generateSingleObjects = false;
    }

    // Update is called once per frame
    void Update()
    {

        // if (Input.GetMouseButtonDown(0))


        if (generateMultiObjects == true)
        {
           
            generatedObjectPosition = generationPoint.transform.position; // Defines the Generated Object's Position based on specified Generation Point

            generatedObjectRotation = generationPoint.transform.rotation; // Defines the Generated Object's Rotation based on specified Generation Point

            Instantiate(objectToGenerate, generatedObjectPosition, generatedObjectRotation); // Generate a new specified object at the specified Generation Point

        }



        if (generateSingleObjects == true)
        {

            generatedObjectPosition = generationPoint.transform.position; // Defines the Generated Object's Position based on specified Generation Point

            generatedObjectRotation = generationPoint.transform.rotation; // Defines the Generated Object's Rotation based on specified Generation Point

            Instantiate(objectToGenerate, generatedObjectPosition, generatedObjectRotation); // Generate a new specified object at the specified Generation Point

           generateSingleObjects = false;

        }


    }

     public void ObjectGeneratorMulti(bool MultiObjects)
    {
        generateMultiObjects = MultiObjects;
    }

     public void ObjectGeneratorSingle(bool SingleObjects)
    {
        generateSingleObjects = SingleObjects;
    }
}
