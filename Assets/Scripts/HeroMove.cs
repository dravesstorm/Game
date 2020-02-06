using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    public float speed;
    public float addForce;
    public KeyCode leftButton = KeyCode.A;
    public KeyCode rightButton = KeyCode.D;
    public KeyCode addForceButton = KeyCode.W;
    public static bool isFacingRight = true;
    private Vector3 direction;
    private float horizontal;
    private Rigidbody2D body;
    public static bool canJump;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.fixedAngle = true;
        canJump = true;
    }


    void FixedUpdate()
    {
        body.AddForce(direction * body.mass * speed/2);

        if (Input.GetKey(addForceButton) && canJump)
        {
            body.velocity = new Vector2(0, addForce);
            canJump = false;
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
             else if (Input.GetKey(rightButton)) horizontal = 1; 
                     else horizontal = 0;

        direction = new Vector2(horizontal, 0);
        if (horizontal > 0 && !isFacingRight ) Flip(); 
            else if (horizontal < 0 && isFacingRight) Flip();
    }
}
