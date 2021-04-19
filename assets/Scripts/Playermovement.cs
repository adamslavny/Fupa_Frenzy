using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class Playermovement : MonoBehaviour
{
    private Rigidbody2D rb2;
    public Boundary boundary;
    public float speed;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, 0.0f);

        rb2.velocity = (speed * movement);

        rb2.position = new Vector2
        (
            Mathf.Clamp(rb2.position.x, boundary.xMin, boundary.xMax),
            -2.5f
        );

    }

    public void SetSpeed(float val)
    {
        speed = val;
    }
}

//penis
