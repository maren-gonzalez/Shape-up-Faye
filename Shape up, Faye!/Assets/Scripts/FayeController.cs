using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FayeController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5.0f;
    private float horizontalMovement;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontalMovement = context.ReadValue<Vector2>().x;
    }
    
    void Update()
    {
        rb.velocity = new Vector3(horizontalMovement * speed, rb.velocity.y, rb.velocity.z);
    }
}
