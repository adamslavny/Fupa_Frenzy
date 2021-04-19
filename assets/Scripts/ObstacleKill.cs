using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleKill : MonoBehaviour
{
    public int scoreValue;
    private GameController gameController;
    private Collider2D playaCollider;

    private Playermovement playamovement;

    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
        GameObject playa = GameObject.FindWithTag("Player");
        playamovement = playa.GetComponent<Playermovement>();
        playaCollider = playa.GetComponent<Collider2D>();
        
    }
    private void Disable()
    {
        playaCollider.enabled = !playaCollider.enabled;
        playamovement.SetSpeed(0.0f);

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Destroy(gameObject);
            gameController.GameOver();
            Disable();
        }
        Destroy(gameObject);
    }

}