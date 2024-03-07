using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class GetStatsScript : MonoBehaviour
{

    public static GetStatsScript instance;
    private void Awake() => instance = this;
    // Start is called before the first frame update
    public GameObject dialog2;
    public GameObject stats;
    public TextMeshProUGUI sanity, hungry;
    private readonly int SANITY = 100;
    private readonly int HUNGRY = 0;
    private int currentSanity;
    private int currentHungry;
    public Collider trigger1;
    private float timer = 0.0f;
    private readonly int sanityDecreasingTime = 5;
    private readonly int hungryDecreasingTime = 5;
    void Start()
    {
        sanity.text = SANITY.ToString();
        hungry.text = HUNGRY.ToString();
    }

    public GetStatsScript() {
        
    }

    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("get trigger");
        if (other.CompareTag("Player"))
        {

            currentHungry = HUNGRY; 
            currentSanity = SANITY;
            trigger1.enabled = false;
            dialog2.SetActive(true);
            stats.SetActive(true);
            sanity.text = currentSanity.ToString();
            hungry.text = currentHungry.ToString();

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!trigger1.enabled)
        {
            timer += Time.deltaTime;
            if (timer >= hungryDecreasingTime)
            {
                currentHungry++;
                hungry.text = currentHungry.ToString();
            }
            if (timer >= sanityDecreasingTime)
            {
                currentSanity--;
                sanity.text = currentSanity.ToString();
                timer = 0.0f;
            }
            
        }
    }

    public void RegenSanity()
    {
        while (currentSanity <= 96) {
            currentSanity += 4;
            sanity.text = currentSanity.ToString();
        }
        if (currentSanity > 96 && currentSanity <= 99)
        {
            currentSanity = 100;

        }
        sanity.text = currentSanity.ToString();
    }

    public void EatFood()
    {
        if (currentHungry < 15)
        {
            currentHungry = 0;
        } else
        {
            currentHungry -= 15;
        }
        hungry.text = currentHungry.ToString();


    }
}
