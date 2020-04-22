using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowChoc : MonoBehaviour
{
    Rigidbody2D chocpiece;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject Hero = GameObject.FindWithTag("Hero");
        chocpiece = GetComponent<Rigidbody2D>();
        chocpiece.AddForce(transform.up * chocpiece.mass * 20);
        //chocpiece.position = Vector3.MoveTowards(chocpiece.transform.position, Hero.transform.position, Time.deltaTime * 20f);
        float Dist = Vector2.Distance(chocpiece.transform.position, Hero.transform.position);
        Vector2 Direction = new Vector2((Hero.transform.position.x - chocpiece.transform.position.x) / Dist,
                                         (Hero.transform.position.y - chocpiece.transform.position.y) / Dist);
        chocpiece.velocity = Direction * 20;
        // chocpiece.transform.Rotate(50.0f,0f, 0f);
        //if (Direction > 0) 

        //    chocpiece.velocity = new Vector2();
        //else chocpiece.velocity = new Vector2();
    }
    void Update()
    {
        chocpiece.transform.Rotate(0, 0, 20.0f);
    }
}
