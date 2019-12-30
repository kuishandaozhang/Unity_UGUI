using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// 鼠标按下与抬起事件接口
/// </summary>
public class IDownAndUpDemo : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("鼠标按下");

        Debug.Log(eventData.pointerEnter);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("鼠标抬起");

        Debug.Log(eventData.pointerEnter);
    }
}
