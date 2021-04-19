using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
   // public AudioClip gulpFX;
    //public AudioSource gulpSource;
    public int scoreValue;
    private GameController gameController;
    private bool eat;
    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
       // gulpSource.clip = gulpFX;
    }
  
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Destroy(gameObject);
            gameController.AddScore(scoreValue);
            
        }
            Destroy(gameObject);
        
    }
    //bool setEat()
   // {

   // }
}
    
 

//hudsons jewish