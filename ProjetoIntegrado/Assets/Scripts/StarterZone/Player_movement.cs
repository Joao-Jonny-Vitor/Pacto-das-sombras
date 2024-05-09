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
    public Animator animator;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        //move o player
        rb.velocity = direction * speed;

        // define se ta se movendo
        bool isMoving = direction != Vector2.zero;
        animator.SetBool("isMoving", isMoving);

        

        // determina a direção para ajustar as variaveis
        if (direction == Vector2.right)
        {
            animator.SetBool("isRight", true);
            animator.SetBool("isLeft", false);
            animator.SetBool("isUp", false);
            animator.SetBool("isDown", false);
        }
        else if (direction == Vector2.left)
        {
            animator.SetBool("isLeft", true);
            animator.SetBool("isUp", false);
            animator.SetBool("isDown", false);
            animator.SetBool("isRight", false);
        }
        else if (direction == Vector2.up)
        {
            animator.SetBool("isUp", true);
            animator.SetBool("isRight", false);
            animator.SetBool("isLeft", false);
            animator.SetBool("isDown", false);
        }
        else if (direction == Vector2.down)
        {
            animator.SetBool("isDown", true);
            animator.SetBool("isRight", false);
            animator.SetBool("isLeft", false);
            animator.SetBool("isUp", false);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject)
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

        if(context.started && interactingObject != null && interactingObject.CompareTag("Door"))
        {
            Debug.Log("Interagiu com a porta");
        }
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }

    public void OnPress(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            speed = (float)(1.5 * speed);
        }
        if (context.canceled)
        {
            speed = (float)(speed / 1.5);
        }
    }
    
}


