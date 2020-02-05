using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    public float speed;
    public float addForce;
    public KeyCode leftButton = KeyCode.A;
    public KeyCode rightButton = KeyCode.D;
    public KeyCode addForceButton = KeyCode.Space;
    public bool isFacingRight = true;
    private Vector3 direction;
    private float horizontal;
    private Rigidbody2D body;
    private bool CanJump;
    private bool jump = true;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.fixedAngle = true;
        CanJump = true;
    }


    void FixedUpdate()
    {
        body.AddForce(direction * body.mass * speed);

        if (Input.GetKey(addForceButton) && jump)
        {
            body.velocity = new Vector2(0, addForce);
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

  

    void Update()
    {
        if (Input.GetKey(leftButton)) horizontal = -1;
        else if (Input.GetKey(rightButton)) horizontal = 1; else horizontal = 0;

        direction = new Vector2(horizontal, 0);
       // if(body.(GameObject.FindWithTag("staticPlatform"))) CanJump = true;
        if (horizontal > 0 && !isFacingRight ) Flip(); else if (horizontal < 0 && isFacingRight) Flip();
    }
}
