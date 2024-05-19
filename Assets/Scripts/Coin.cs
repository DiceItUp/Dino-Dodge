using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value;

    private string PLAYER_TAG = "Player";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.CompareTag(PLAYER_TAG))
        {
            Destroy(gameObject);
            CoinCounter.instance.IncreaseCoins(value);
        }



    }




}//class
