using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationMeshGhostScript : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent ghost;
    public Transform playerObject;
    Vector3 destination;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        destination = playerObject.position;
        ghost.destination = destination;
    }
}
