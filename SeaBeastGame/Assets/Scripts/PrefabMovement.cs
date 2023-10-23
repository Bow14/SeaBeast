using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMovement : MonoBehaviour
{
    //ChatGPT
    
    
    public float speed = 5.0f;

    private void Update()
    {
        // Calculate the new position of the prefab
        Vector3 newPosition = transform.position + Vector3.left * speed * Time.deltaTime;

        // Update the position of the prefab
        transform.position = newPosition;
    }
}

