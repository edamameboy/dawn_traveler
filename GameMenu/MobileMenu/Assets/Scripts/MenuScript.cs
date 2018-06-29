using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour {

    public void ChangeMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("New scene has loaded!");
    }

    public void PrevMenu()
    {
        
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Quit game!");
    }

}
