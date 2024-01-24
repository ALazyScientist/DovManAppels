using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class platformermovment : MonoBehaviour
{
    public float MoveSpeed;
    public float jumppower;
    public Rigidbody2D Rb;
    private Vector2 Direction;
    public Transform groundcheck;
    public LayerMask ground;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inputs();
    }

    void inputs()
    {
        Grounded();
        
        float MoveX = Input.GetAxisRaw("Horizontal");
      
        if(Input.GetButtonDown("Jump") && Grounded())
        {
            Rb.velocity = new Vector2(Rb.velocity.y, jumppower);
        }

        Direction = new Vector2(MoveX, jumppower);
    }

    private void FixedUpdate()
    {
        move();
    }

    void move()
    {
        Rb.velocity = new Vector2(Direction.x * MoveSpeed, Rb.velocity.y);
    }

    private bool Grounded()
    {
        return Physics2D.OverlapCircle(groundcheck.position, 0.2f, ground);

    }
}
