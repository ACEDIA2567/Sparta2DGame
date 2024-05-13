using System;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");

    private Animator animator;
    private Controller controller;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<Controller>();
    }

    private void Start()
    {
        controller.OnMoveMent += Move;
    }

    // 속도에 따른 isWalking true / false 결정
    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > 0.5f);
    }
}