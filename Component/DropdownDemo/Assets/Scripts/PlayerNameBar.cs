using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 玩家名称 颜色控制
/// </summary>
public class PlayerNameBar : MonoBehaviour
{
    private Text playerName;            //玩家名称
    private Dropdown colorDropdown;     //颜色下拉菜单

    private Color[] colors;             //颜色数组

    void Start()
    {
        playerName = transform.Find("PlayerName").GetComponent<Text>();
        colorDropdown = transform.Find("TextColorDropdown").GetComponent<Dropdown>();


        colors = new Color[4];
        colors[0] = Color.white;
        colors[1] = Color.red;
        colors[2] = Color.green;
        colors[3] = Color.blue;


        List<Dropdown.OptionData> options = new List<Dropdown.OptionData>();
        options.Add(new Dropdown.OptionData("白色（默认）"));
        options.Add(new Dropdown.OptionData("红色"));
        options.Add(new Dropdown.OptionData("绿色"));
        options.Add(new Dropdown.OptionData("蓝色"));
        colorDropdown.options = options;

        colorDropdown.onValueChanged.AddListener(SetPlayerNameColor);
    }


    /// <summary>
    /// 设置玩家名称颜色
    /// </summary>
    /// <param name="index">索引</param>
    private void SetPlayerNameColor(int index)
    {
        playerName.color = colors[index];

        ColorBlock colorBlock = new ColorBlock();
        colorBlock.normalColor = colors[index];
        colorBlock.highlightedColor = colors[index];
        colorBlock.pressedColor = colors[index];
        colorBlock.disabledColor = colors[index];
        colorBlock.colorMultiplier = 1;
        colorDropdown.colors = colorBlock;
    }

    
}
