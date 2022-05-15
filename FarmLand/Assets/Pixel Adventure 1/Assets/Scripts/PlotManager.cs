using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotManager : MonoBehaviour
{

    private bool isPlanted = false;
    public GameObject plant;

    private void OnMouseDown() {
        
        if (isPlanted) 
        {
            Harvest();
        }
        else 
        {
            Plant();
        }

         Debug.Log("clicked");

    }

    void Harvest()
    {
        Debug.Log("Harvested");
        isPlanted = false;
        plant.SetActive(false);
    }

    void Plant()
    {
        Debug.Log("Harvested");
        isPlanted = true;
        plant.SetActive(true);
    }
}
