using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocTrigger : MonoBehaviour
{
    private int hitPoints;
    // Start is called before the first frame update
    void Start()
    {
        hitPoints = 2;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Weapon")
        {
            if (hitPoints > 0)
                --hitPoints;
            else 
                Destroy(gameObject);
        }
    }
}
