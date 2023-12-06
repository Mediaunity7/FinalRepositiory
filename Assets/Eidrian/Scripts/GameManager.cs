using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    private void Awake()
    {
        if (Instance == null)
        {
           
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Pause(bool isPause)
    {
       
        switchPause(isPause);

    }
    void switchPause(bool p)
    {
        
        switch (p)
        {
            case true:

                disableGame();
                break;
            case false:

                enableGame();
                break;
        }
       
    }
    void disableGame()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
    }
   public void enableGame()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
