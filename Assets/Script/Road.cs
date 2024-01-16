using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    Renderer RD;
    // Start is called before the first frame update
    void Start()
    {
        RD = GetComponent<Renderer>();
    }
    // Update is called once per frame
    void Update()
    {
        float Yoffset = Time.time*0.5f;
        //print(Yoffset);
        RD.material.SetTextureOffset("_MainTex", new Vector2(0, Yoffset));
    }
}
