using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Slider测试Demo
/// </summary>
public class SliderDemo : MonoBehaviour
{
    private Slider m_Slider;    //Slider组件

    private Text sliderValue;   //滑动条数值

    void Start()
    {
        m_Slider = GetComponent<Slider>();      //获取到Slider组件

        sliderValue = GameObject.Find("Canvas/SliderValue").GetComponent<Text>();

        m_Slider.onValueChanged.AddListener(OnSliderValueChanged);      //添加要监听的事件
        m_Slider.onValueChanged.AddListener(SetSliderValue);            //添加设置文本的方法

        m_Slider.onValueChanged.RemoveListener(OnSliderValueChanged);   //移除已经监听的方法
    }

    /// <summary>
    /// 当Slider的Value发生变化时
    /// </summary>
    private void OnSliderValueChanged(float value)
    {
        Debug.Log("当前Slider的Value值：" + value);
    }

    /// <summary>
    /// 设置Text显示Slider的Value
    /// </summary>
    private void SetSliderValue(float value)
    {
        string valueStr = value.ToString();     //文本为字符串，需要将float转为字符串
        sliderValue.text = valueStr;            //设置文本
    }
}
