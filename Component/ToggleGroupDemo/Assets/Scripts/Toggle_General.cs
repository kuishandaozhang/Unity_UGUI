using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 开关1
/// </summary>
public class Toggle_General : MonoBehaviour
{
    private GameObject panel;     //面板1

    private Toggle toggle;

    public string panelName = "Panel";  //面板名称，默认Panel

    void Start()
    {
        panel = transform.Find("../../Panels/" + panelName).gameObject;

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
        panel.SetActive(isOpen);
    }
}
