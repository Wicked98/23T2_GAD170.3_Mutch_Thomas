using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactTester : MonoBehaviour
{
    // Want this script to handle colision & trigger detection
    // when object impacts another, we want to print text
    // First collisons...

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Burnt Bacon");

        // sound effect
        // change colour of object
        // change colour of player

        // destroy player
        Destroy(collision.gameObject);
    }
    // Next collisions... 


    // Update is called once per frame
    void Update()
    {
        
    }
}
