using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LosingScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject loadingScreen;
    public string sceneName;
    public TextMeshProUGUI Level;


    public void ReplayGame()
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
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        LevelManagerScript.instance.getCurrentLevel();
        int level = LevelManagerScript.instance.CurrentLevel;
        Level.text = level.ToString();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
