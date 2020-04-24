using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeCoin : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textScore;
    void Start()
    {
        textScore.text = PlayerPrefs.GetInt("Coins").ToString();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
            textScore.text = PlayerPrefs.GetInt("Coins").ToString();
        }
    }
    
}
