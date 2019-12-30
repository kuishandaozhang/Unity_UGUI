using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>
/// 点击事件接口
/// </summary>
public class ClickDemo : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Font font;  //字体

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("点击事件");

        Debug.Log(eventData.pointerEnter);

        //1, 生成物体，设置名称为：ClickImageChild
        GameObject imageChild = new GameObject("ClickImageChild");

        //2, 设置该物体为ClickImage的子物体
        imageChild.transform.SetParent(eventData.pointerEnter.transform);

        //3, 为其动态添加Text组件
        Text childText = imageChild.AddComponent<Text>();

        //4, 设置Text组件文本内容
        childText.text = "动态生成的Text组件";

        //5, 设置Text组件字体
        childText.font = font;

        //6, 位置归零
        imageChild.transform.localPosition = Vector3.zero;
    }
}
