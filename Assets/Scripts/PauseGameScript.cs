using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGameScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pauseMenu;
    public string sceneName;
    public bool press;
    public PlayerController playerController;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            press = !press;
            if (!press)
            {
                pauseMenu.SetActive(false);
                Time.timeScale = 1;
                playerController.enabled = true;
                AudioListener.pause = false;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }

            if (press)
            {
                pauseMenu.SetActive(true);
                Time.timeScale = 0;
                playerController.enabled = false;
                AudioListener.pause = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }        
    }

    public void ContinueGame()
    {
        Debug.Log("continue");
        press = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        playerController.enabled = true;
        AudioListener.pause = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void QuitToMenu()
    {
        Debug.Log("Quit");
        SceneManager.LoadScene(sceneName);
        AudioListener.pause = false;
    }
}
