using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartPage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void start()
    {
        SceneManager.LoadScene("Garage");
    }
    public void Setting()
    {
        SceneManager.LoadScene("Setting");
    }
    public void Garage()
    {
        SceneManager.LoadScene("Garage");
    }
}
