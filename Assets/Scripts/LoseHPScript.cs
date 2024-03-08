using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseHPScript : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isInteractable;
    private float timer;
    void Start()
    {
        isInteractable = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.CompareTag("Player"))
        {
            isInteractable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isInteractable)
        {
            GetStatsScript.instance.DecreaseSanity();
            isInteractable = false;
        }
    }
}
