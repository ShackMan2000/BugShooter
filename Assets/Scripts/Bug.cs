using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{

    [SerializeField]
    public ScriptableObjectFloat health;
    [SerializeField]
    public ScriptableObjectFloat karma;
    




    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        var karma = collision.gameObject.GetComponent<Karma>();
        if(karma == null)
            return;

        health.currentValue += karma.KarmaChange;
        karma.Hit();
    }
}
