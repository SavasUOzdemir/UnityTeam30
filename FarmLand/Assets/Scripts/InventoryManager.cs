using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class InventoryManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] public int inventory_state = 0;
    private bool mouse_over = false;
    public void inventoryMovement()
    {
        if (inventory_state == 0 || inventory_state == 1)
        {
            transform.LeanMoveLocalY(0, 0.5f).setEaseOutCubic();
            inventory_state = 2;
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        if (inventory_state == 0)
        {
            transform.LeanMoveLocalY(transform.localPosition.y + 50, 0.5f).setEaseOutCubic();
            inventory_state = 1;
        }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        if (inventory_state == 1)
        {
            transform.LeanMoveLocalY(transform.localPosition.y - 50, 0.5f).setEaseOutCubic();
            inventory_state = 0;
        }
    }
}