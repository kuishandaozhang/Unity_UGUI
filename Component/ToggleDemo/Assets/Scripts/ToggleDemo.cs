using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Toggle复选框Demo
/// </summary>
public class ToggleDemo : MonoBehaviour
{
    private Toggle m_Toggle;    //Toggle组件

    private GameObject panel;   //面板

    void Start()
    {
        m_Toggle = GetComponent<Toggle>();                              //获取组件

        panel = GameObject.Find("Canvas/Panel");                        //获取面板物体

        m_Toggle.onValueChanged.AddListener(OnToggleValueChanged);      //监听Toggle变化，并将信息传到OnToggleValueChanged()方法中
        m_Toggle.onValueChanged.AddListener(OnToggleValueChanged_2);
    }

    /// <summary>
    /// 打印Toggle状态
    /// </summary>
    /// <param name="isOn"></param>
    private void OnToggleValueChanged(bool isOn)
    {
        Debug.Log("当前状态：" + isOn);
    }

    /// <summary>
    /// 显示或隐藏面板
    /// </summary>
    /// <param name="isOn">显示与否</param>
    private void OnToggleValueChanged_2(bool isOn)
    {
        panel.SetActive(isOn);
    }


    void Update()
    {
        
    }
}
