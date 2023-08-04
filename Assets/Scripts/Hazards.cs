using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazards : MonoBehaviour
{

    // When player interacts with the object something happens
    private void OnTriggerEnter(Collider other)
    {
        // command only occurs when player hits lava
        if (other.CompareTag("Player"))
        {
            // tells player their pig has hit lava
            Debug.Log("Burnt to a crisp");

            // function runs when the player script is found
            other.gameObject.GetComponent<Player>().KillPig();

        }
        

    }
}
