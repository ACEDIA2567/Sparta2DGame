using System;
using UnityEngine;

public class CharacterAim : MonoBehaviour
{
    private Controller controller;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        controller = GetComponent<Controller>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        controller.OnLook += Look;
    }

    
    private void Look(Vector2 vector)
    {
        float z = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
        spriteRenderer.flipX = Mathf.Abs(z) > 90;
    }
}