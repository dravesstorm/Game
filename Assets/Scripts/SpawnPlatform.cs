using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject platform;
    public GameObject groundCollPlatform;
    public GameObject enemy;
    private float indent = 1f;

    void Start()
    {
        StartCoroutine(CanCreatePlatform());
       
    }
    IEnumerator CanCreatePlatform()
    {
        float sin = 0f;
        for (int i = -10; i < 5000; i++)
        {
            Instantiate(platform, new Vector3(indent * i, -5 + 2*Mathf.Sin(sin), 0), Quaternion.identity);
            Instantiate(groundCollPlatform, new Vector3(indent * i, -5 + 2 * Mathf.Sin(sin), 0), Quaternion.identity);
            //if(i % 49 == 0)
            //{
            //    Instantiate(enemy, new Vector3(indent * i, (-5 + 2 * Mathf.Sin(sin))+1, 0), Quaternion.identity);

            //}
            sin += 0.1f;
            yield return new WaitForSeconds(0.01f);
        }
    }

}
