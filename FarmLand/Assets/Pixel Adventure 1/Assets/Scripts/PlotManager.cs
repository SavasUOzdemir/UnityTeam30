using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotManager : MonoBehaviour
{

    private bool isPlanted = false;
    public SpriteRenderer plant;

    public Sprite[] plantStages;

    int plantStage = 0;

    float timeBtwStages = 2f;

    float timer;

    private void Update() 
    {
        if (isPlanted)
        {
            timer -= Time.deltaTime;
    
            if (timer < 0 && plantStage < plantStages.Length-1)
            {
                timer = timeBtwStages;
                plantStage++;
                updatePlant();
            }
        }
    }

    private void OnMouseDown() {
        
        if (isPlanted) 
        {
            if (timer < 0 == plantStage < plantStages.Length-1)
            {
                Harvest();
            }            
        }
        else 
        {
            Plant();
        }

    }

    void Harvest()
    {
        isPlanted = false;
        plant.gameObject.SetActive(false);
    }

    void Plant()
    {
        isPlanted = true;
        plantStage = 0;
        updatePlant();
        timer =timeBtwStages;
        plant.gameObject.SetActive(true);
    }

    void updatePlant()
    {
        plant.sprite = plantStages[plantStage]; 
    }
}
