using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_movement : MonoBehaviour
{
    public InputActionReference move;
    public Rigidbody2D rb;
    public float Speed;
    private Vector2 Direction;

    
    private void Update()
    {
        Direction = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Direction.x * Speed, Direction.y * Speed);
    }
}
