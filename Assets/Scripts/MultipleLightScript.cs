using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleLightScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject txtGrab, light5, light3, light4;
    public bool press;
    public bool isInteractable;
    public Renderer lb2, lb3, lb4;
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
            }
        }

        if (press == false)
        {
            light3.SetActive(false);
            light4.SetActive(false);
            light5.SetActive(false);
            lb2.material = offLight;
            lb3.material = offLight;
            lb4.material = offLight;
        }
        if (press == true)
        {
            light3.SetActive(true);
            light4.SetActive(true);
            light5.SetActive(true);
            lb2.material = onLight;
            lb3.material = onLight;
            lb4.material = onLight;
        }
    }
}

