using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockTab : MonoBehaviour
{

    public GameObject lockbutton;
    public GameObject unlockbutton;
    public bool panelKilitli;

    private void Awake()
    {
        lockbutton.SetActive(false);
        unlockbutton.SetActive(true);
        panelKilitli = false;
    }
    
    public void LockPanel()
    {
           if (panelKilitli == false)
            {
                lockbutton.SetActive(true);
                unlockbutton.SetActive(false);
            panelKilitli = true;

        }
            else  
            {
                lockbutton.SetActive(false);
                unlockbutton.SetActive(true);
            panelKilitli = false;
            }
            }

}