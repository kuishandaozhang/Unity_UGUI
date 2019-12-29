using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;     //UI接口在该命名空间中

public class EnterAndExitDemo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Image image;
    private Text text;

    void Start()
    {
        image = GetComponent<Image>();
        text = transform.Find("Text").GetComponent<Text>();
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("鼠标进入！");
        image.color = Color.red;    //红色
        text.text = "鼠标进入";
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("鼠标移出！！");
        image.color = Color.green;  //绿色
        text.text = "鼠标移出";
    }
}
