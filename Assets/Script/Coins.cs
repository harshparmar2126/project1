using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject Coin,parent;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            float randomX = Random.Range(2f, -2f);
            float randomY = Random.Range(0f, 0f);
            Instantiate(Coin, new Vector2(randomX, randomY), Quaternion.identity, parent.transform);
        }
        InvokeRepeating("coins", 2f, 10f);
    }
    // Update is called once per frame
    void Update()
    {
       

    }
    void coins()
    {
        float randomX = Random.Range(-2f, 2f);
        Instantiate(Coin, new Vector2(randomX,transform.position.y), Quaternion.identity, parent.transform);
    }

    
}
