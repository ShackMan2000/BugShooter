using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject trashPrefab, bugPrefab;

    [SerializeField]
    private Camera mainCamera;





    private float counter;
    
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
        counter -= Time.deltaTime;
        if (counter <= 0)
        {
            counter = Random.Range(minSpawntime, maxSpawnTime);
            SpawnTrash();
        }

    }


    private void SpawnTrash()
    {
        Instantiate(trashPrefab, GetSpawnPosition(), Quaternion.identity);

    }

    private void SpawnFood()
    {

    }


    private Vector2 GetSpawnPosition()
    {
        var newX = Random.Range(bottomLeftCorner.x, topRightCorner.x);
        var newY = Random.Range(topRightCorner.y, topRightCorner.y+1);

        return new Vector2(newX, newY);
    }



}
