using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public event Action<Vector2> OnMoveMent;
    public event Action<Vector2> OnLook;
    public event Action OnAttack;

    // ������ �̺�Ʈ
    public void CallbackMove(Vector2 direction)
    {
        OnMoveMent?.Invoke(direction);
    }

    // �ٶ󺸴� �̺�Ʈ
    public void CallbackLook(Vector2 direction)
    {
        OnLook?.Invoke(direction);
    }

    // ���� �̺�Ʈ
    public void CallbackAttack()
    {
        OnAttack?.Invoke();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
