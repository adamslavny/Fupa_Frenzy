using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCollider : MonoBehaviour
{
   private Collider playerCollider;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    void Update()
    {
        
    }
    public void Disable() //Disables the hitbox on player so after game ends, burgers can hit the player w/o affecting anything
    {
        GameObject playa = GameObject.FindWithTag("Player");
        playerCollider = playa.GetComponent<Collider>();
        playerCollider.enabled = !playerCollider.enabled;

    }
}
