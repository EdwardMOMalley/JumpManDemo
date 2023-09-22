using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMan : MonoBehaviour
{
    public Rigidbody2D rBody;
    public float jumpForce = 10;

    public AudioSource jumpSound;
    public AudioSource coinSound;
    public GameObject coinSpawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.transform.position.y);
        if (Input.GetMouseButtonDown(0) && gameObject.transform.position.y <-4.1)
        {
            jumpSound.Play();
            rBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Coin")
        {
            coinSound.Play();
            coinSpawner.GetComponent<CoinSpawner>().CreateCoin();
        }

    }
}
