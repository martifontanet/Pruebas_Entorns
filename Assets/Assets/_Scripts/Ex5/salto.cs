using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class salto : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce;
    public PlayerInputMap _playerInput;
    bool readyToJump = true;
    int jumps = 0;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        _playerInput = new PlayerInputMap();
        _playerInput.Juego.Enable();
    }
    // Update is called once per frame
    void Update()
    {
        grounded = Physics.Raycast(gameObject.transform.position, Vector3.down, playerHeight, whatIsGround);
        if (grounded)
        {
            //Debug.Log("Grounded");
        }
        Inputs();
    }

    private void Inputs()
    {
        if (_playerInput.Juego.Jump.WasPressedThisFrame() && grounded)
        {
            Jump();
        }
        else if (_playerInput.Juego.Jump.WasPressedThisFrame() && !grounded && jumps == 1)
        {
            Jump();
        }
    }

    private void Jump()
    {
        // resetejar la velocitat de y per saltar sempre igual
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        //apliquem impulse perque es nomes una vegada
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        jumps++;
        Invoke(nameof(ResetJump), 0.1f);
        //Debug.Log(jumps);
    }
    private void ResetJump()
    {
     if (gameObject.transform.position.y > playerHeight)
        {
            jumps = 0;
        }
    }
}
