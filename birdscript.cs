using System;
using UnityEngine;
using UnityEngine.InputSystem;

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
        if (Keyboard.current.spaceKey.wasPressedThisFrame && birdisalive)
        {
            myrigidbody.linearVelocity = Vector2.up * flapstrength;
        }

        if (transform.position.y > 20 || transform.position.y < -20)
        {
            logic.gameover();
            birdisalive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdisalive = false;
    }
}