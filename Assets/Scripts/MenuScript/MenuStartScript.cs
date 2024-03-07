using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStartScript : MonoBehaviour
{
    public GameObject loadingScreen;
    public string sceneName;
    public AudioSource menuSound;

    public void Start()
    {
        menuSound.enabled = true;
    }
    public void PlayGame()
    {
        loadingScreen.SetActive(true);
        SceneManager.LoadScene(sceneName);
        menuSound.enabled = false;
    }

    public void QuitGame()
    {
        menuSound.enabled=false;
        Application.Quit();
    }
    // Start is called before the first frame update
    
}
