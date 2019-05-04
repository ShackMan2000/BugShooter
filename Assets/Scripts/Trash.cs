using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour, Karma
{
    public float KarmaChange { get => 100;}

    public void Hit()
    {
        gameObject.SetActive(false);
    }
}
