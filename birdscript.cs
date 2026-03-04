using System;
using UnityEngine;
using UnityEngine.InputSystem; // New Input System namespace

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapstrength;
    public logicscript logic;
    public bool birdisalive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }
    void Update()
    {
        // Use the new Input System
        if (Keyboard.current.spaceKey.wasPressedThisFrame && birdisalive)
        {
            myrigidbody.linearVelocity = Vector2.up * flapstrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdisalive = false;
    }
}