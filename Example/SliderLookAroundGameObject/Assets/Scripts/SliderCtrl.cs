using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum DirType
{
    Hor,
    Ver,
}

/// <summary>
/// Slider控制器
/// </summary>
public class SliderCtrl : MonoBehaviour
{
    private Slider m_Slider;        //Slider组件

    private Transform lookTarget;   //观察对象的Transform组件

    public DirType dirType = DirType.Hor;

    void Start()
    {
        m_Slider = GetComponent<Slider>();                      //获取组件
        lookTarget = GameObject.Find("LookTarget_2").transform;   //获取目标对象

        m_Slider.onValueChanged.AddListener(LookTarget);        //监听事件
    }

    /// <summary>
    /// 查看物体
    /// </summary>
    private void LookTarget(float value)
    {
        //value:     0    0.5    1
        //Y  轴:   -180    0    180

        float rot = 0;            //物体Y轴旋转值
        float startValue = -180;    //最小值   【定值，无需修改】
        float valueSpan = 360;      //值得跨度，360 = 180 - (-180)   【定值，无需修改】

        rot = startValue + valueSpan * value;                 //计算旋转值

        if(dirType == DirType.Hor) lookTarget.eulerAngles = new Vector3(0, rot, 0);      //赋予旋转值    Y Axis
        else lookTarget.eulerAngles = new Vector3(rot, 0, 0);                            //X Axis
    }
}
