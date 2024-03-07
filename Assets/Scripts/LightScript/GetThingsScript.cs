using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetThingsScript : MonoBehaviour
{
    public GameObject things;
    public GameObject electricLightSource;
    public GameObject electricLightInHand;
    public AudioSource pickup;
    public bool isInteractable;


    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            isInteractable = true;
            things.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            isInteractable = false;
            things.SetActive(false);
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
                
                isInteractable = false;
                electricLightInHand.SetActive(true);
                electricLightSource.SetActive(false);
            }
        }
    }
}
