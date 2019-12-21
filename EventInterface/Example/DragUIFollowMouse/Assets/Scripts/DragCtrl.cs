using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragCtrl : MonoBehaviour, IDragHandler
{
    private RectTransform m_RectTran;

    void Start()
    {
        m_RectTran = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 posOffset = new Vector3(Screen.width / 2, Screen.height / 2, 0);     //计算偏移量
        m_RectTran.anchoredPosition = Input.mousePosition - posOffset;
    }
}
