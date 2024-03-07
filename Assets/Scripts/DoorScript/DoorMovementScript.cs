using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovementScript : MonoBehaviour
{
    public GameObject txtGrab1;
    public bool isInteractable, press;
    public Animator doorAnimator;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            isInteractable = true;
            txtGrab1.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            isInteractable = true;
            txtGrab1.SetActive(false);
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
            if (Input.GetKeyDown(KeyCode.G))
            {
                press = !press;
                if (press)
                {
                    doorAnimator.ResetTrigger("Close");
                    doorAnimator.SetTrigger("Open");
                }

                if (!press)
                {
                    doorAnimator.ResetTrigger("Open");
                    doorAnimator.SetTrigger("Close");
                }
                isInteractable = false;
            }
        }
    }
}
