using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource source;

    [SerializeField]
    private AudioClip trashSound, levelUpsound;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }







    public void PlayTrashSound()
    {
        source.clip = trashSound;
        source.Play();
    }

    public void PlayLevelUpsound()
    {
        source.clip = levelUpsound;
        source.Play();
    }
}
