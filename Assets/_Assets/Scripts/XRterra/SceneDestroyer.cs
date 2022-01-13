using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDestroyer : MonoBehaviour
{
    public float destoryPosition;
    GameObject[] gameObjects;

    // Keep start in your hierarchy to enable or disable this script through the inspector and animation windows 
    void Start()
    {

    }

    void LateUpdate()
    {
        gameObjects = (FindObjectsOfType<GameObject>() as GameObject[]);

        for (int i = 0; i < gameObjects.Length; i++)
        {

            if (gameObjects[i].transform.position.y < destoryPosition)
            {
                Destroy(gameObjects[i]);
            }

        }
    }
}
