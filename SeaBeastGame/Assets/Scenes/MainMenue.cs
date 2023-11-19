using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenue : MonoBehaviour
{
    //https://www.youtube.com/watch?v=zc8ac_qUXQY Is where I got this - Brackeys

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Loads the next level in the queue
    }

    public void RestartGame()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("MainMenue");
    }

    public void QuitGame()
    {
        Debug.Log("Dam");
        Application.Quit();
    }
    
    
}
