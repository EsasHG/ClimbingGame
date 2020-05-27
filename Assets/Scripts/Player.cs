using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float MovementSpeed = 0.1f;
    public float JumpStrength = 1.3f;

    private bool DoubleJumpUsed = false;
    private Quaternion StartRot;

    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        StartRot = transform.rotation;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = StartRot;
        rigidBody.velocity += new Vector2(1,0) * Input.GetAxisRaw("Horizontal") * MovementSpeed;

        if(Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene("SampleScene");

        if (Math.Abs(rigidBody.velocity.y) < 0.5)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            if(!DoubleJumpUsed)
            {
                DoubleJumpUsed = true;
                Jump();
            }
        }
        
    }

    private void Jump()
    {
        rigidBody.AddForce(Vector3.up * JumpStrength);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DoubleJumpUsed = false;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {

    }
}

