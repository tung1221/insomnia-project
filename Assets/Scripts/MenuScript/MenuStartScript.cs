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
        StartCoroutine(LoadLoadingScreen());
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator LoadLoadingScreen()
    {
        loadingScreen.SetActive(true);
        yield return new WaitForSeconds(3f);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    
}
