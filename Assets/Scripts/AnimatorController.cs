using System;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");

    [SerializeField] private Animator KnightAnimator;
    [SerializeField] private Animator ElfAnimator;
    private Controller controller;

    private void Awake()
    {
        controller = GetComponent<Controller>();
    }

    private void Start()
    {
        controller.OnMoveMent += Move;
    }

    // 속도에 따른 isWalking true / false 결정
    private void Move(Vector2 vector)
    {
        if(KnightAnimator.enabled) KnightAnimator.SetBool(isWalking, vector.magnitude > 0.5f);
        if(ElfAnimator.enabled) ElfAnimator.SetBool(isWalking, vector.magnitude > 0.5f);
    }
}