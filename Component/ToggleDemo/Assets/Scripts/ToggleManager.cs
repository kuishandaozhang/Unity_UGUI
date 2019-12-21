using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Toggle组件管理器Demo
/// </summary>
public class ToggleManager : MonoBehaviour
{
    private Toggle toggle;      //Toggle组件

    void Start()
    {
        toggle = GameObject.Find("Canvas/Toggle").GetComponent<Toggle>();       //获取Toggle组件

        Debug.Log("ToggleManager: " + toggle.name);
    }

    void Update()
    {
        
    }
}
