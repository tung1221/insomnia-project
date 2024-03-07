using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class FoodStepSoundScript : MonoBehaviour
{
    public AudioSource foodWalk, foodSprint;

    public bool sprinting;



    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) ||Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                sprinting = true;
            }
            if (Input.GetKeyUp(KeyCode.RightShift))
            {
                sprinting = false;
            }
            if (sprinting)
            {
                foodWalk.enabled = false;
                foodSprint.enabled = true;
            }
            if (sprinting == false)
            {
                foodWalk.enabled = true;
                foodSprint.enabled = false;
            }

        }
        else
        {
            foodWalk.enabled = false;
            foodSprint.enabled = false;
            sprinting = false;
        }
    }
}

