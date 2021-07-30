using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "joystick")] // 우클릭했을때 Create에 joystick 나오게함
public class JoystickValue : ScriptableObject
{
    public Vector2 joyTouch;
}
