using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    //спавн молока 
    public GameObject MilkPrefab;
    public GameObject cookie;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateEnemy());
    }

    IEnumerator CreateEnemy()
    {
        //бесконечно 
        while(true)
        {
            if (cookie != null)
            {
                //позиция + 20 чтоб был за картой и вертикаль 3 чтоб не упал в пропасть
                Vector3 enemyPosition = new Vector3(cookie.transform.position.x + 20f, 3f, 0f);
                Instantiate(MilkPrefab, enemyPosition, Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(2f, 4f));
            }
            else
            {
                break;
            }
        }
    }
}