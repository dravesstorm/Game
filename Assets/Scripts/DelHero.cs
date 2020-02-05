using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelHero : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hero")
        {
            Destroy(other.gameObject);
        }
    }
}
