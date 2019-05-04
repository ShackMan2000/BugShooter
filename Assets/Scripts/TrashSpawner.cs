using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject trashPrefab, foodPrefab, enemyPrefab;

    [SerializeField]
    private Camera mainCamera;


    public float chanceToSpawnFood, chanceToSpawnEnemy, chanceToSpawnTrash;





    private float trashCounter, bugToEatCounter, enemyCounter;

    [SerializeField]
    private float minSpawntime, maxSpawnTime;

    private Vector2 bottomLeftCorner, topRightCorner;


    private void Awake()
    {

        bottomLeftCorner = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0));
        topRightCorner = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, 0));

    }

    // Update is called once per frame
    void Update()
    {
        trashCounter -= Time.deltaTime;
        bugToEatCounter -= Time.deltaTime;
        enemyCounter -= Time.deltaTime;

        if (trashCounter <= 0)
        {
            trashCounter = Random.Range(minSpawntime, maxSpawnTime);
            SpawnTrash();
        }
        if (bugToEatCounter <= 0)
        {
            trashCounter = Random.Range(minSpawntime, maxSpawnTime);
            SpawnFood();
        }
        if(enemyCounter <=0)
        {
            enemyCounter = Random.Range(minSpawntime, maxSpawnTime);
            SpawnEnemy();
        }

    }


    private void SpawnTrash()
    {
        if (chanceToSpawnTrash > Random.Range(0.0f, 100.0f))
            Instantiate(trashPrefab, GetSpawnPosition(), Quaternion.identity);

    }

    private void SpawnFood()
    {
        if (chanceToSpawnFood > Random.Range(0.0f, 100.0f))
            Instantiate(foodPrefab, GetSpawnPosition(), Quaternion.identity);
    }


    private void SpawnEnemy()
    {
        if (chanceToSpawnEnemy > Random.Range(0.0f, 100.0f))
            Instantiate(enemyPrefab, GetSpawnPosition(), Quaternion.identity);
    }




    private Vector2 GetSpawnPosition()
    {
        var newX = Random.Range(bottomLeftCorner.x, topRightCorner.x);
        var newY = Random.Range(topRightCorner.y, topRightCorner.y + 1);

        return new Vector2(newX, newY);
    }



}
