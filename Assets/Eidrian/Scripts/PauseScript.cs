using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScrypt : MonoBehaviour
{
    private GameManager gameManager;
    [Header("Drag the pause canvas here!")]
    public GameObject pauseScreen;

    bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {
        gameManager =GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = !isPause;
            gameManager.Pause(isPause);
            pauseScreen.SetActive(isPause);

        }   
    }
    public void returnToMenu()
    {
        //Destroy(gameManager);
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.None;
    }

}
