using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOffLight : MonoBehaviour
{

    public GameObject light1;
    public bool press;
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            sound.Play();
            press = !press;

        }

        if (press)
        {
            light1.SetActive(true);
        }

        if (!press)
        {
            light1.SetActive(false);
        }
    }
}
