using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugToEat : MonoBehaviour, Karma
{
    public float KarmaChange => -2;
    public float HealthChange { get => 3; }


    public void Hit()
    {
        gameObject.SetActive(false);
    }
}
