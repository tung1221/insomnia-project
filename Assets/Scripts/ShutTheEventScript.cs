using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShutTheEventScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider ShutTheEventObjectCollider;
    public GameObject EventScareLv1;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("... touch");
        Debug.Log(other);
        if (other.CompareTag("Player"))
        {
            Debug.Log("access");
            ShutTheEventObjectCollider.enabled = false;
            EventScareLv1.SetActive(false);
        }
    }


    // Update is called once per frame

}
