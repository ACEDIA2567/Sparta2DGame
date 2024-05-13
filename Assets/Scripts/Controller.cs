using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public event Action<Vector2> OnMoveMent;
    public event Action<Vector2> OnLook;
    public event Action OnTalk;
    public event Action OnAttack;

    // 움직임 이벤트
    public void CallbackMove(Vector2 direction)
    {
        OnMoveMent?.Invoke(direction);
    }

    // 바라보는 이벤트
    public void CallbackLook(Vector2 direction)
    {
        OnLook?.Invoke(direction);
    }

    // 공격 이벤트
    public void CallbackAttack()
    {
        OnAttack?.Invoke();
    }

    // 대화 이벤트
    public void CallbackTalk()
    {
        OnTalk?.Invoke();
    }
}
