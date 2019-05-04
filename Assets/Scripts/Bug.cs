using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{

    public float currentHealth;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        currentHealth += collision.gameObject.GetComponent<Trash>().KarmaChange;
        collision.gameObject.GetComponent<Karma>().Hit();
    }
}
