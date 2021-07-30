using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// https://www.youtube.com/watch?v=2pf1FE-Xcc8

public class JoystickM : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    RectTransform rect;
    Vector2 touch = Vector2.zero;
    public RectTransform handle;

    float widthHalf;

    public JoystickValue value;

    private void Start()
    {
        rect = GetComponent<RectTransform>();
        widthHalf = rect.sizeDelta.x * 0.5f;
    }

    public void OnDrag(PointerEventData eventData)
    {
       Vector2 touch = (eventData.position - rect.anchoredPosition) / widthHalf;
        if (touch.magnitude > 1)
            touch = touch.normalized;
        value.joyTouch = touch * 0.02f;
        handle.anchoredPosition = touch * widthHalf;

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("조이스틱 누름");
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData) // 여기다가 파라미터 전송을 넣으면 되지않을까. 근데 안됨
    {
        value.joyTouch = Vector2.zero;
        handle.anchoredPosition = Vector2.zero;
    }

}
