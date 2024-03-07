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
    private bool isInteractable, isFirstTime;
    private GameObject foodCan;
    public GameObject EventScareLv1;
    // Start is called before the first frame update



    void Start()
    {
        foodCount = 0;
        isInteractable = false;
        isFirstTime = true;
        food.text = $"{foodCount}/{MAXIMUM_FOOD}";
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("FoodL1"))
        {
            txtGrab.SetActive(true);
            isInteractable = true;
            foodCan = other.gameObject;
        }
        
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("haha");
    //    if (other.CompareTag("RemoveEventL1"))
    //    {
    //        Debug.Log("hwg");
    //        other.enabled = false;
    //        EventScareLv1.SetActive(false);
    //    }
    //}

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("FoodL1"))
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
                foodCan.SetActive(false);
                GetStatsScript.instance.EatFood();
                if (foodCount == MAXIMUM_FOOD && isFirstTime)
                {
                    // darknessText.SetActive(true);
                    EventScareLv1.SetActive(true);
                    isFirstTime = false;
                }
                isInteractable = false;
                txtGrab.SetActive(false);
            }
            
        }
        
    }
}
