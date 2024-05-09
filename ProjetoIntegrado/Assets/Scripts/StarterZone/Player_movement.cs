using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Profiling;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class Player_movement : MonoBehaviour
{

    public Rigidbody2D rb;
    private Vector2 direction;
    private GameObject interactingObject;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            interactingObject = collision.gameObject;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject == interactingObject)
        {
            interactingObject = null;
        }
    }

    public void OnInteraction(InputAction.CallbackContext context)
    {
        if (context.started && interactingObject != null && interactingObject.CompareTag("Enemy"))
        {
            Debug.Log("Interagiu com o inimigo");
        }
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
}


