using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>
/// 拖拽Demo
/// </summary>
public class DragDemo : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    /// <summary>
    /// 开始拖拽
    /// </summary>
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("开始拖拽！" + eventData.pointerDrag + "---pointerEnter:" + eventData.pointerEnter);

        Text text = eventData.pointerDrag.GetComponent<Text>();
        text.text = "开始拖拽！";
    }


    /// <summary>
    /// 拖拽中
    /// </summary>
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("拖拽中~" + eventData.pointerDrag + "---pointerEnter:" + eventData.pointerEnter);

        Text text = eventData.pointerDrag.GetComponent<Text>();
        text.text = "拖拽中~";
    }


    /// <summary>
    /// 拖拽结束
    /// </summary>
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("拖拽结束！" + eventData.pointerDrag + "---pointerEnter:" + eventData.pointerEnter);

        Text text = eventData.pointerDrag.GetComponent<Text>();
        text.text = "拖拽结束！";
    }
}
