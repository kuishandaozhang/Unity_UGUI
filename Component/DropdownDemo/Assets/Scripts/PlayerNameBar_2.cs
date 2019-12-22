using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// 玩家名称 颜色控制
/// </summary>
public class PlayerNameBar_2 : MonoBehaviour
{
    private Text playerName;            //玩家名称
    private KDropdown colorDropdown;     //颜色下拉菜单

    private Color[] colors;             //颜色数组

    void Start()
    {
        playerName = transform.Find("PlayerName").GetComponent<Text>();
        colorDropdown = transform.Find("TextColorDropdown_2").GetComponent<KDropdown>();


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
        colorDropdown.onPointerClick.AddListener(SetItemsBGColor);
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

    /// <summary>
    /// 设置所有选项的背景颜色
    /// </summary>
    /// <param name="evetnt"></param>
    private void SetItemsBGColor(PointerEventData evetnt)
    {
        Debug.Log("2121");

        Transform items = colorDropdown.transform.Find("Dropdown List/Viewport/Content");
        if (items == null) return;

        int index = -1;
        foreach (Transform item in items)
        {
            Debug.Log(item.name);
            Debug.Log(index);

            if (index == -1)
            {
                index++;
                continue;
            }

            Toggle t = item.GetComponent<Toggle>();
            t.colors = GetColorBlock(index);
            Debug.Log(t.colors.normalColor);
            index++;
        }
    }

    private ColorBlock GetColorBlock(int index)
    {
        ColorBlock colorBlock = new ColorBlock();
        colorBlock.normalColor = colors[index];
        colorBlock.highlightedColor = new Color(colors[index].r - 0.3f, colors[index].g - 0.3f, colors[index].b - 0.3f, 1);
        colorBlock.pressedColor = colors[index];
        colorBlock.disabledColor = colors[index];
        colorBlock.colorMultiplier = 1;

        return colorBlock;
    }
}
