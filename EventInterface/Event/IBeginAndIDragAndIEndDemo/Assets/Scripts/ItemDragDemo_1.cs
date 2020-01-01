using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>
/// 物品放入物品槽Demo
/// </summary>
public class ItemDragDemo_1 : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform m_RectTransform;      //获取该组件，用于拖拽时移动自身位置
    private Image m_Image;                        //用于修改自身是否接收射线
    private Transform dragingParent;            //Item拖拽时的父物体

    void Start()
    {
        m_RectTransform = GetComponent<RectTransform>();
        m_Image = GetComponent<Image>();

        dragingParent = transform.parent;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        m_Image.raycastTarget = false;   //取消接收事件

        transform.SetParent(dragingParent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        m_RectTransform.anchoredPosition = Input.mousePosition - new Vector3(Screen.width / 2.0f, Screen.height / 2.0f, 0);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        m_Image.raycastTarget = true;    //恢复接收事件

        if (eventData.pointerEnter == null)
            return;


        //1，获取到槽的Transform组件
        Transform slot = eventData.pointerEnter.transform;

        //2，将物品的父物体设置为槽
        transform.SetParent(slot);

        //3，将物品的【本地位置】归零
        transform.localPosition = Vector3.zero;
    }
}
