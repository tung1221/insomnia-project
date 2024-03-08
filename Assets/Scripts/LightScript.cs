using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightScript : MonoBehaviour


{

    public GameObject txtGrab, light2;
    public bool press;
    public bool isInteractable;
    public Renderer lightBulb;
    public Material offLight, onLight;
    public Animator switchAnimator;
    public AudioSource lightSwSound;


    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            txtGrab.SetActive(true);
            isInteractable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            txtGrab.SetActive(false);
            isInteractable = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (isInteractable)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                press = !press;
                switchAnimator.ResetTrigger("press");
                switchAnimator.SetTrigger("press");
                lightSwSound.Play();
            }
        }

        if (press == false)
        {
            light2.SetActive(false);
            lightBulb.material = offLight;
            
        }
        if (press == true)
        {
            light2.SetActive(true);
            lightBulb.material = onLight;
            
        }
    }
}
