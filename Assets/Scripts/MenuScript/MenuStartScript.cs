using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStartScript : MonoBehaviour
{
    public GameObject loadingScreen;
    public string sceneName;
    
    public void PlayGame()
    {
        loadingScreen.SetActive(true);
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    
}
