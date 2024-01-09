using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    // Start is called before the first frame update
    public float MoveSpeed;
    public Rigidbody2D Rb;
    private Vector2 Direction;

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
        float MoveX = Input.GetAxisRaw("Horizontal");
        float Movey = Input.GetAxisRaw("Vertical");

        Direction = new Vector2(MoveX, Movey);
    }

    private void FixedUpdate()
    {
       move();
    }

    void move()
    {
        Rb.velocity = new Vector2(Direction.x * MoveSpeed, Direction.y * MoveSpeed);
    }
}
