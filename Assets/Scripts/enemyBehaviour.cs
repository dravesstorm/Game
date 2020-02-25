using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    //молоко прыгает с периодичностью

    private Vector3 direction;
    private Rigidbody2D body;
    public float power = 2;//сила прыжка

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
            body.velocity = new Vector2(-5f * power, 5f * power);
            
            //периодичность
            yield return new WaitForSeconds(Random.Range(1f, 2f));
        }
    }
}
