using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] skeletonReference;

    private GameObject spawnedSkeleton;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;
    private int test;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnSkeletons());




    }

    IEnumerator SpawnSkeletons()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));

            randomIndex = Random.Range(0, skeletonReference.Length);
            randomSide = Random.Range(0, 2);

            spawnedSkeleton = Instantiate(skeletonReference[randomIndex]);

            if (randomSide == 0)
            {

                if (randomIndex == 0)
                {
                    spawnedSkeleton.transform.position = leftPos.position;
                    spawnedSkeleton.GetComponent<Skeleton>().speed = 8;
                }
                else if (randomIndex == 1)
                {
                    spawnedSkeleton.transform.position = leftPos.position;
                    spawnedSkeleton.GetComponent<Skeleton>().speed = 11;
                }
                else
                {
                    spawnedSkeleton.transform.position = leftPos.position;
                    spawnedSkeleton.GetComponent<Skeleton>().speed = 5;
                }

                //spawnedSkeleton.transform.position = leftPos.position;
                // spawnedSkeleton.GetComponent<Skeleton>().speed = Random.Range(4, 10);
            }
            else
            {
                if (randomIndex == 0)
                {
                    spawnedSkeleton.transform.position = rightPos.position;
                    spawnedSkeleton.GetComponent<Skeleton>().speed = -8;
                    spawnedSkeleton.transform.localScale = new Vector3(-8.2f, 8.2f, 1f);
                }
                else if (randomIndex == 1)
                {
                    spawnedSkeleton.transform.position = rightPos.position;
                    spawnedSkeleton.GetComponent<Skeleton>().speed = -11;
                    spawnedSkeleton.transform.localScale = new Vector3(-8.2f, 8.2f, 1f);
                }
                else
                {
                    spawnedSkeleton.transform.position = rightPos.position;
                    spawnedSkeleton.GetComponent<Skeleton>().speed = -5;
                    spawnedSkeleton.transform.localScale = new Vector3(-8.2f, 8.2f, 1f);
                }
                //spawnedSkeleton.transform.position = rightPos.position;
               // spawnedSkeleton.GetComponent<Skeleton>().speed = -Random.Range(4, 10);
               // spawnedSkeleton.transform.localScale = new Vector3(-8.2f, 8.2f, 1f);

            }
        } // while loop

    }


}//class

//coin spawn vector
//new Vector3(Random.Range(-105, 105), -3)




