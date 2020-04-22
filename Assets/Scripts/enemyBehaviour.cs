using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    //молоко прыгает с периодичностью

    private Vector3 direction;
    private Rigidbody2D body;
    public float power = 2;//сила прыжка

    public float GetDirection()
    {
        GameObject Hero = GameObject.FindWithTag("Hero");
        return Mathf.Sign(Hero.transform.position.x - body.transform.position.x);
    }
    void Start()
    {
        //берем молоко
        body = GetComponent<Rigidbody2D>();
        
        StartCoroutine(Jump());

    }


    IEnumerator Jump()
    {
        
        //постоянно прыгает
        while (true)
        {
            Vector2 direction = new Vector2(5f * power * GetDirection(), 5f * power);
            
            body.velocity = direction;  
            
            //периодичность
            yield return new WaitForSeconds(Random.Range(1f, 2f));
        }
    }
}
