using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // kills pig character
    public void KillPig()
    {
        // reloads current scene, teleporting pig back to start per death 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
