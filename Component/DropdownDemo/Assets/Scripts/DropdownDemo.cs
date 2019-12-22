using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dropdown示例
/// </summary>
public class DropdownDemo : MonoBehaviour
{
    private Dropdown m_Dropdown;    //Dropdown组件


    void Start()
    {
        m_Dropdown = GetComponent<Dropdown>();      //获取组件

        m_Dropdown.onValueChanged.AddListener(OnDropdownValueChanged);

        //添加选项
        List<string> newOptions = new List<string>();
        newOptions.Add("新增选项 1");
        newOptions.Add("新增选项 2");
        newOptions.Add("新增选项 3");

        m_Dropdown.AddOptions(newOptions);


        //覆盖全部选项
        List<Dropdown.OptionData> allOptions = new List<Dropdown.OptionData>();
        allOptions.Add(new Dropdown.OptionData("选项 001"));
        allOptions.Add(new Dropdown.OptionData("选项 002"));
        allOptions.Add(new Dropdown.OptionData("选项 003"));
        allOptions.Add(new Dropdown.OptionData("选项 004"));

        m_Dropdown.options = allOptions;
    }


    /// <summary>
    /// 当选项改变时
    /// </summary>
    /// <param name="value">选项索引</param>
    private void OnDropdownValueChanged(int value)
    {
        //Debug.Log("当前选项：" + value);

        Debug.Log("当前选项：" + m_Dropdown.options[value].text);
    }
}
