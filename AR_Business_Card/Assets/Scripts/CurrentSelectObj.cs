using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CurrentSelectObj : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData data)
    {
        Debug.Log("EventSystem����N���b�N�����m����");
    }

    public void onClick()
    {
        Debug.Log("onClick���쓮����");
    }
}