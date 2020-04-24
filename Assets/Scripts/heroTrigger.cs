using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class heroTrigger : MonoBehaviour
{
    public  int HealthPoint=3;

    public void Damage(int damageCount)
    {
        HealthPoint-= damageCount;
        if(HealthPoint<=0)
            Destroy(gameObject);
    }

    //столкновение с молоком
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "MilkEnemy" || other.tag == "ChocPiece" || other.tag == "ChocolateEnemy")
        {
            //  Damage(1);
            Destroy(gameObject);
            
            Application.LoadLevel("Start");
        }
    }
}
