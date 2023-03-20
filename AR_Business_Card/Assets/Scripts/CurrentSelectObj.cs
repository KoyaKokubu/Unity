using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CurrentSelectObj : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData data)
    {
        Debug.Log("EventSystemからクリックを検知した");
    }

    public void onClick()
    {
        Debug.Log("onClickが作動した");
    }
}