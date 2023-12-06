using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }
    public void LevelE()
    {
        
        SceneManager.LoadScene(1);

    }
    public void LevelK()
    {
        
        SceneManager.LoadScene(2);

    }
    public void ExitGame()
    {
        Debug.Log("Exit game");
        //Quit the game
        Application.Quit();

    }
}
