using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject CoinReference;




    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(SpawnCoins());

    }

   IEnumerator SpawnCoins()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);

            Instantiate(CoinReference).transform.position = new Vector3(Random.Range(-105, 105), -3);
                

        }
    }



    
}//class


//add max coin count, dont forget this headass