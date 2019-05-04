using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{

    [SerializeField]
    public ScriptableObjectFloat health;
    [SerializeField]
    public ScriptableObjectFloat karmaValue;





    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("enemy"))
        {
            health.currentValue -= collision.gameObject.GetComponent<Enemy>().damage;
        }
        else
        {
            var objectsKarma = collision.gameObject.GetComponent<Karma>();
            if (objectsKarma == null)
                return;

            karmaValue.currentValue += objectsKarma.KarmaChange;
            objectsKarma.Hit();

        }

    }
}
