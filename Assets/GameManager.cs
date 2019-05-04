using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private ScriptableObjectFloat karmaValue, healthValue;

    [SerializeField]
    private float[] karmaPointsNeededPerLevel;

    private int currentLevel;

    private AudioManager audioManager;

    private TrashSpawner spawner;



    private void Awake()
    {
        audioManager = FindObjectOfType<AudioManager>();

        healthValue.currentValue = healthValue.maxValue;
        currentLevel = -1;
        NextLevel();
    }

    private void NextLevel()
    {
        currentLevel ++;
        karmaValue.maxValue = karmaPointsNeededPerLevel[currentLevel];
        karmaValue.currentValue = 0;
    }



    private void BugDied()
    {

    }


    private void Update()
    {
        if(karmaValue.currentValue >= karmaValue.maxValue)
        {
            NextLevel();
            audioManager.PlayLevelUpsound();

        }

        if(healthValue.currentValue <= 0)
            SceneManager.LoadScene("GameOverScene");

        


    }






}
