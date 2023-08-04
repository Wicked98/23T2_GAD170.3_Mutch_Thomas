using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageTriggerBox : MonoBehaviour
{
    // reference to the message panel
    public GameObject messagePanel;

    // When player interacts with the object something happens
    private void OnTriggerEnter(Collider other)
    {
        // command only occurs when player hits lava
        if (other.CompareTag("Player"))
        {
            // tells player their pig has hit lava
            Debug.Log("WARNING. Lava is dangerous. DO NOT TOUCH");

            // Enables the message panel
            messagePanel.SetActive(true);

        }

      }
    // When player exits the trigger
    private void OnTriggerExit(Collider other)
    {
        // command only occurs when player hits the message panel
        if (other.CompareTag("Player"))
        {
            

        // Enables the message panel
        messagePanel.SetActive(false);

        }

    }

}
