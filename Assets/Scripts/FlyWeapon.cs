using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyWeapon : MonoBehaviour
{
    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.AddForce(transform.up * body.mass * 20);
        if (HeroMove.isFacingRight)
        body.velocity = new Vector2(20, 0);
        else body.velocity = new Vector2(-20, 0);
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
   
}
