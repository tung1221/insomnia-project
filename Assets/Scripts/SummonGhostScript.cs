using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonGhostScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ghost;
    public Collider col;
    public GameObject dialog3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            col.enabled = false;
            dialog3.SetActive(true);
            
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
