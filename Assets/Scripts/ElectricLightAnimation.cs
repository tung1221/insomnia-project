using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ElectricLightAnimation : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isWalking;
    public Animator cameraAnimation;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        isWalking = false;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W)) {
            isWalking = true;
            cameraAnimation.ResetTrigger("Sleep");
            cameraAnimation.ResetTrigger("Sprint");
            cameraAnimation.SetTrigger("Walk");
            if (isWalking)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    cameraAnimation.ResetTrigger("Sleep");
                    cameraAnimation.ResetTrigger("Walk");
                    cameraAnimation.SetTrigger("Sprint");
                }
            }

        } else
        {
            cameraAnimation.ResetTrigger("Walk");
            cameraAnimation.ResetTrigger("Sprint");
            cameraAnimation.SetTrigger("Sleep");
            isWalking = false;
        }
    }
}
