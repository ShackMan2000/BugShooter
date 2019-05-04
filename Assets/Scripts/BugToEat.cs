using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugToEat : MonoBehaviour, Karma
{
    public float KarmaChange => -50;

    public void Hit()
    {
        gameObject.SetActive(false);
    }
}
