using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;
using UnityEngine.Events;

public class KDropdown : Dropdown
{
    public class ClickEvent : UnityEvent<PointerEventData> { }

    public ClickEvent onPointerClick = new ClickEvent();

    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        onPointerClick.Invoke(eventData);
    }
}
