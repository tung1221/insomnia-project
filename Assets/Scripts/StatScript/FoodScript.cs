using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    public GameObject txtGrab;
    private int foodCount;
    public GameObject darknessText;
    private readonly int MAXIMUM_FOOD = 4;
    public TextMeshProUGUI food;
    private bool isInteractable;
    // Start is called before the first frame update



    void Start()
    {
        foodCount = 0;
        isInteractable = false;
        food.text = $"{foodCount}/{MAXIMUM_FOOD}";
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("gay food");
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

    // Update is called once per frame
    void Update()
    {

        if (isInteractable)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                foodCount++;
                food.text = $"{foodCount}/{MAXIMUM_FOOD}";
                gameObject.SetActive(false);
                GetStatsScript.instance.EatFood();
                if (foodCount == MAXIMUM_FOOD)
                {
                    darknessText.SetActive(true);
                }
            }
        }
        
    }
}
