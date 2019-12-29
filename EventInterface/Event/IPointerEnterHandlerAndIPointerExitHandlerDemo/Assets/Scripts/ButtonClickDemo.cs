using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickDemo : MonoBehaviour
{
    void Start()
    {
        Button button = GetComponent<Button>();

        button.onClick.AddListener(OnBtnClick);
    }

    private void OnBtnClick()
    {
        Debug.Log("button click");
    }
}
