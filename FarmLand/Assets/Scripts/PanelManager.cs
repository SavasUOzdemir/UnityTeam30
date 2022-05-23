using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PanelManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] public int panel_state = 0;
    private bool mouse_over = false;
    public void PanelMovement()
    {
        if (panel_state==0||panel_state==1)
        {
            transform.LeanMoveLocalX(0, 0.5f).setEaseOutCubic();
            panel_state = 2;
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        if (panel_state == 0)
        {
            transform.LeanMoveLocalX(1455f, 0.5f).setEaseOutCubic();
            panel_state = 1;
        }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        if (panel_state == 1)
        {
            transform.LeanMoveLocalX(1545f, 0.5f).setEaseOutCubic();
            panel_state = 0;
        }
    }
    public void PanelClose()
    {
         {
            transform.LeanMoveLocalX(1545f, 0.5f).setEaseOutCubic();
            panel_state = 0;
        }
    }
}
