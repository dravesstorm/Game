using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject platform;
    private float indent = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CanCreatePlatform());
       
    }

    IEnumerator CanCreatePlatform()
    {
        float sin = 0f;
        for (int i = -8; i < 500000000; i++)
        {
            Instantiate(platform, new Vector3(indent * i, -5 + 2*Mathf.Sin(sin), 0), Quaternion.identity);
            sin += 0.1f;
            yield return new WaitForSeconds(0.01f);
        }
    }

}
