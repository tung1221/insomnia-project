using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static LevelManagerScript instance;
    private int currentLevel;
    private void Awake() => instance = this;
    public int CurrentLevel {get; private set; }

    public void getCurrentLevel()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            currentLevel = 1;
        }
        if (SceneManager.GetActiveScene().name == "InsomniaLevel2")
        {
            currentLevel = 2;
        }
        if (SceneManager.GetActiveScene().name == "InsomniaLevel3") {
            currentLevel = 3;
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
