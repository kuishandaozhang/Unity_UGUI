using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 开关2
/// </summary>
public class Toggle_2 : MonoBehaviour
{
    private GameObject panel_2;     //面板2

    private Toggle toggle;

    void Start()
    {
        panel_2 = transform.Find("../../Panels/Panel_2").gameObject;

        toggle = GetComponent<Toggle>();    //获取自身的Toggle组件

        toggle.onValueChanged.AddListener(OpenOrClosePanel);
    }


    /// <summary>
    /// 打开或关闭面板
    /// </summary>
    /// <param name="isOpen">是否打开</param>
    private void OpenOrClosePanel(bool isOpen)
    {
        Debug.Log(name + ":" + isOpen);
        panel_2.SetActive(isOpen);
    }
}
