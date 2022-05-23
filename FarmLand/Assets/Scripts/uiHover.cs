using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class uiHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool mouse_over = false;
    [SerializeField] private int sidehud_state = 0;
    void Update()
    {
        if (mouse_over)
        {
            Debug.Log("Mouse Over");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
       //Debug.Log(transform.position);
        if (sidehud_state==0)
        {
            transform.position += new Vector3(-75f, 0f, 0f);
            sidehud_state = 1;
        }
        
        {

        }
            
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        //Debug.Log("Mouse exit");
        if (sidehud_state==1)
        {
            transform.position += new Vector3(75f, 0f, 0f);
            sidehud_state = 0;
        }
    }
}

