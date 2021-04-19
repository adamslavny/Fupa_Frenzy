using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public AudioClip gulpFX;
    public AudioSource gulpSource;
    public GameObject food;
    public GameObject poop;
    public Vector2 spawnValues;
    public int foodCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    public Text scoreText;
    public Text gameOverText;

    private bool gameOver;
    private int score;

    void Start()
    {
        gameOver = false;
        score = 0;
        gameOverText.text = "";
        UpdateScore();
        StartCoroutine(SpawnWaves());
       // gulpSource.clip = gulpFX;
    }

    void Update()
    {
        
    }

    IEnumerator SpawnWaves ()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(startWait);
            for (int i = 0; i < foodCount; i++)
            {
                if (gameOver == false)
                {
                    int randNum = UnityEngine.Random.Range(0, foodCount);
                    if (randNum == i || randNum == (i + 1)) //my attempt to make poop spawn more
                    {
                        Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y);
                        Instantiate(poop, spawnPosition, Quaternion.identity);
                        yield return new WaitForSeconds(spawnWait);
                    }
                    if (randNum != i)
                    {
                        Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y);
                        Instantiate(food, spawnPosition, Quaternion.identity);
                        yield return new WaitForSeconds(spawnWait);
                    }
                }
                else
                {
                    break;
                }

            }
            yield return new WaitForSeconds(waveWait);

            
        }
    }

    public void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
        gulpSource.Play();
    }

    void UpdateScore ()
    {
        scoreText.text = "Fupa: " + score;
    }
     public void ResetScore()
    {
        score = 0;
    }

    public void GameOver ()
    {
        gameOver = true;
        gameOverText.text = "GAME OVER!";
    }
    
}
