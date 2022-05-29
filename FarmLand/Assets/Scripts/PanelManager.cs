using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class PanelManager : MonoBehaviour
    /*, IPointerEnterHandler, IPointerExitHandler*/
{
    [SerializeField] public int panel_state = 1;
    [SerializeField] public bool panel_locked;
    [SerializeField] public GameObject lockbutton;
    public LockTab lockTab;

    //private void Awake()
    //{
    //    panel_locked.GetComponent<LockTab>().panel_locked=false;

    //}
void Awake()
    {
        lockTab = lockbutton.GetComponent<LockTab>();
    }

    public void PanelMovement()
    {
        if (panel_state == 0 || panel_state == 1)
        {
            if (lockTab.panelKilitli == false)
            {
                transform.LeanMoveLocalX(0, 0.5f).setEaseOutCubic();
                panel_state = 2;

            }
        }
    }

    //Panel state == 0 mevzusu þu ki: en saðda hiçbir þey olmasýn azýcýk bi çýkýntý dýþýnda, üzerine gelince raycasti görüp poplasýn düðmeye basmadan önce bi ara form olsun. 
    //Gel gör ki raycasti penetrate ettiremediðim için bu kýsýmlarý uçurdum, daha güzel görünecekti ama gel gör ki kader... :(

    //
    //public void OnPointerEnter(PointerEventData eventData)
    //{
    //    if (panel_state == 0)
    //    {
    //        transform.LeanMoveLocalX(1455f, 0.5f).setEaseOutCubic();
    //        panel_state = 1;
    //    }

    //}
    //public void OnPointerExit(PointerEventData eventData)
    //{
    //    if (panel_state == 1)
    //    {
    //        if (panel_locked == true)
    //        {
    //            transform.LeanMoveLocalX(1545f, 0.5f).setEaseOutCubic();
    //            panel_state = 0;
    //        }
    //    }
    //}
    public void PanelClose()
    {
        {
            transform.LeanMoveLocalX(1463f, 0.5f).setEaseOutCubic();
            panel_state = 1;
        }
    }
    

}

