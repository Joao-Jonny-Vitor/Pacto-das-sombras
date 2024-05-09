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
    
    private Vector2 Direction;

    [SerializeField] float Speed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate()
    {
        rb.velocity = Direction * Speed;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
            Debug.Log("Encostou no inimigo");
        {
           
            Debug.Log("Interagiu");
        }
    }

    private void OnInteraction (InputAction.CallbackContext context){

    }
   
    public void OnMovement(InputAction.CallbackContext context){
        Direction = context.ReadValue<Vector2>();

    }
}


