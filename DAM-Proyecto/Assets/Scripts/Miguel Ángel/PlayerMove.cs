using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speedMove = 2;

    //public float speedJump = 5;

    Rigidbody2D rg2d;

    // Start is called before the first frame update
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rg2d.velocity = new Vector2(-speedMove, rg2d.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rg2d.velocity = new Vector2(speedMove, rg2d.velocity.y);
        }
        else
        {
            rg2d.velocity = new Vector2(0, rg2d.velocity.y);
        }
        if (Input.GetKey(KeyCode.UpArrow) && CheckGround.isGrounded)
        {
            rg2d.velocity = new Vector2(rg2d.velocity.x, 5f);
        }
    }
    public void Reespaun(bool comprobar)
    {
        if (comprobar = true)
        {
            gameObject.GetComponent<Transform>().position = new Vector3(-20, 0, 0);

        }
    }
}
