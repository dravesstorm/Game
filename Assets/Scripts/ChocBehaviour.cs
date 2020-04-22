using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocBehaviour : MonoBehaviour
{
    public GameObject ChocPiece;
    private Rigidbody2D body;
    GameObject Hero;
    // Start is called before the first frame update
    public float GetDirection()
    {
        
        Hero = GameObject.FindWithTag("Hero");
        return Mathf.Sign(Hero.transform.position.x - body.transform.position.x);
    }
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        StartCoroutine(ChocShoot());
    }
    IEnumerator ChocShoot()
    {
        while (true)
        {
            Hero = GameObject.FindWithTag("Hero");
            if (Vector2.Distance(Hero.transform.position, transform.position) > 20)
            {
                Vector2 direction = new Vector2(10f * GetDirection(), 10f );
                body.velocity = direction;
            }
            else
                Instantiate(ChocPiece, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(Random.Range(1f, 1.5f));
        }

       
    }
    // Update is called once per frame

}
