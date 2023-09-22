using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CreateCoin()
    {
        GameObject coin = Instantiate<GameObject>(coinPrefab);
        coin.transform.position = new Vector2(0, 0);
    }
}
