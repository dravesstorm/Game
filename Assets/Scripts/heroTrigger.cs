using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroTrigger : MonoBehaviour
{
    //столкновение с молоком
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "MilkEnemy")
        {
            Destroy(gameObject);
        }
    }
}
