using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 开关3
/// </summary>
public class Toggle_3 : MonoBehaviour
{
    private GameObject panel_3;     //面板3

    private Toggle toggle;

    void Start()
    {
        panel_3 = transform.Find("../../Panels/Panel_3").gameObject;

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
        panel_3.SetActive(isOpen);
    }
}
