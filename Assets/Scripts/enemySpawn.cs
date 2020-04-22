using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    //спавн молока 
    public GameObject MilkPrefab;
    public GameObject ChocPrefab;
    public GameObject cookie;
    public int maxMilks;
    public int maxChocs;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateMilk());
        StartCoroutine(CreateChoc());
    }
    IEnumerator CreateChoc()
    {

        while (true)
        {
            GameObject[] chocs = GameObject.FindGameObjectsWithTag("ChocolateEnemy");

            if (cookie != null)
            {
                if (chocs.Length < maxChocs)
                {//позиция + 20 чтоб был за картой и вертикаль 2 чтоб не упал в пропасть
                    Vector3 enemyPosition = new Vector3(cookie.transform.position.x + 20f, 2f, 0f);
                    Instantiate(ChocPrefab, enemyPosition, Quaternion.identity);
                }
                yield return new WaitForSeconds(Random.Range(10f, 20f));
            }
            else
            {
                break;
            }
        }
    }

    IEnumerator CreateMilk()
    {

        while (true)
        {
            GameObject[] milks = GameObject.FindGameObjectsWithTag("MilkEnemy");

            if (cookie != null)
            {
                if (milks.Length < maxMilks)
                {//позиция + 20 чтоб был за картой и вертикаль 3 чтоб не упал в пропасть
                    Vector3 enemyPosition = new Vector3(cookie.transform.position.x + 20f, 2f, 0f);
                    Instantiate(MilkPrefab, enemyPosition, Quaternion.identity);
                }
                yield return new WaitForSeconds(Random.Range(2f, 4f));
            }
            else
            {
                break;
            }
        }
    }
}