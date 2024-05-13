using System;
using UnityEngine;

public class CharacterAim : MonoBehaviour
{
    private Controller controller;
    [SerializeField] private SpriteRenderer KnightSprite;
    [SerializeField] private SpriteRenderer ElfSprite;

    private void Awake()
    {
        controller = GetComponent<Controller>();
    }

    private void Update()
    {
        controller.OnLook += Look;
    }

    // 마우스 위치에 따른 플레이어 좌우 반전
    private void Look(Vector2 vector)
    {
        float z = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
        if (KnightSprite.enabled)
            KnightSprite.flipX = Mathf.Abs(z) > 90;
        if(ElfSprite.enabled)
            ElfSprite.flipX = Mathf.Abs(z) > 90;
    }
}