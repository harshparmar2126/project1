using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Settingpage : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sett(int a)
    {
        PlayerPrefs.SetInt("Setting",a);
        if (a == 1)
        {
            SceneManager.LoadScene("Play");
        }
        if (a == 2)
        {
            SceneManager.LoadScene("Play");
        }
        if (a == 3)
        {
            SceneManager.LoadScene("Play");
        }
        if (a == 4)
        {
            SceneManager.LoadScene("Play");
        }
    }
    public void Back()
    {
        SceneManager.LoadScene("Start");
    }
}
