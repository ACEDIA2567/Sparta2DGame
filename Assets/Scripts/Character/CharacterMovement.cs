using System;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Controller controller;
    private Rigidbody2D rb;

    private void Awake()
    {
        controller = GetComponent<Controller>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        controller.OnMoveMent += Move;
    }

    private void Move(Vector2 vector)
    {
        rb.velocity = vector * 5;
    }
}
