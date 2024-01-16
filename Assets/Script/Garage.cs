using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Garage : MonoBehaviour
{
    public Sprite[] Cars;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CarSelection(int a)
    {
        PlayerPrefs.SetInt("Carselection", a);
        SceneManager.LoadScene("Setting");
    }
    public void Back()
    {
        SceneManager.LoadScene("Setting");
    }
}
