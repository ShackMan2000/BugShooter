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
       
        var karma = collision.gameObject.GetComponent<Karma>();
        if(karma == null)
            return;

        currentHealth += karma.KarmaChange;
        karma.Hit();
    }
}
