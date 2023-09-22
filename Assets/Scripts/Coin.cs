using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float moveSpeed = 3;
    public Rigidbody2D rBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rBody.velocity = new Vector2(moveSpeed, 0);
        
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(gameObject);
    }


    void OnBecameInvisible()
    {
        moveSpeed *= -1;
    }
}
