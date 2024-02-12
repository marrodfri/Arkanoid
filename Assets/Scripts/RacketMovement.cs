using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMovement : MonoBehaviour
{
    [SerializeField]
    float speed = 150f;

    private Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        
    }
    void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");

        rigidbody2D.velocity = Vector2.right * inputX * speed;
    }
}