using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CarGenrate : MonoBehaviour
{
    public GameObject[] car;
  
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GanrateCar", 2f, 3f);
    }
    void GanrateCar()
    {
        float ramdomX = Random.Range(-2f, 2f);
        int r = Random.Range(0, car.Length);
        Instantiate(car[r], new Vector2(ramdomX, transform.position.y), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    
}
