using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector2 bottomLeftCorner, topRightCorner;


    private float counter;

    public float horizontalSpeed;

    public float damage;



    private void Awake()
    {
        bottomLeftCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        topRightCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
    }



    // Update is called once per frame
    void Update()
    {
        //counter -= Time.deltaTime;
        //if(counter <= 0)
        //{
        //    counter = Random.Range(1.0f, 4)
        //}

        transform.position += new Vector3(horizontalSpeed * Time.deltaTime, 0,0);

        if(transform.position.x < bottomLeftCorner.x || transform.position.x > topRightCorner.x)
        {
            horizontalSpeed *= -1;
        }
      

    }
}
