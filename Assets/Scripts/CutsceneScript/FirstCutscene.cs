using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCutscene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cutScene, playerObject, dialog1;
    public float cutSceneTime;
    void Start()
    {
        StartCoroutine(RunCutScene());
    }

    IEnumerator RunCutScene()
    {
        yield return new WaitForSeconds(cutSceneTime);
        playerObject.SetActive(true);
        cutScene.SetActive(false);
        dialog1.SetActive(true);
    }

    // Update is called once per frame
    
}
