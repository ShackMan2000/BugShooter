using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour, Karma
{
    private AudioManager audioManager;

    public float KarmaChange { get => 1;}

    public float HealthChange { get => 0;}



    private void Awake()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    public void Hit()
    {
        gameObject.SetActive(false);
        audioManager.PlayTrashSound();
    }
}
