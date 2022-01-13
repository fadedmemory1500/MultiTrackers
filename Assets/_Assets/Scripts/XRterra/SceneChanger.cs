using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string objectTag; // Use this FUNCTION for an INTERACTION with a UNITY TRIGGER COLLIDER
    public int sceneNumber; // Use this FUNCTION for an INTERACTION with a UNITY TRIGGER COLLIDER
    

    // Keep start in your hierarchy to enable or disable this script through the inspector and animation windows 
    void Start()
    {

    }

    public void OnTriggerEnter(Collider collider) // Use this FUNCTION for an INTERACTION with a UNITY TRIGGER COLLIDER
    {
        GameObject otherObj = collider.gameObject;
        Debug.Log("Collided with: " + otherObj);
        if (collider.tag == objectTag)
        {
            SceneManager.LoadScene(sceneNumber);
        }
    }

    public void SceneToChange(int sceneNumber) // Use this FUNCTION for an INTERACTION set up with the XR TOOLKIT
    {
        SceneManager.LoadScene(sceneNumber); 
    }

}
