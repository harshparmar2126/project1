using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Car : MonoBehaviour
{
    float speed = 0.1f;
    bool isGoingLeft = false, isGoingRight = false;
    int sc = 0,carno=0;
    public Text score;
    public Sprite[] cars;
    AudioSource source;
    public AudioClip clip1,clip2;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        carno = PlayerPrefs.GetInt("Carselection", 0);
        GetComponent<SpriteRenderer>().sprite = cars[carno];
    }
    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Setting") == 1)
        {
            AccelerationMove();
        }
        if (PlayerPrefs.GetInt("Setting") == 2)
        {
            TouchMove();
        }
        if (PlayerPrefs.GetInt("Setting") == 3 || PlayerPrefs.GetInt("Setting") == 4)
        {
       
            if (isGoingLeft == true || Input.GetKey(KeyCode.LeftArrow))
            {
                float PointX = Mathf.Clamp(transform.position.x - speed, -2f, 2f);
                transform.position = new Vector2(PointX, transform.position.y);
            }
            if (isGoingRight == true || Input.GetKey(KeyCode.RightArrow))
            {
                float PointX = Mathf.Clamp(transform.position.x + speed, -2f, 2f);
                transform.position = new Vector2(PointX, transform.position.y);
            }
        }
    }
    public void BtnLeftPress()
    {
        isGoingLeft = true;
    }
    public void BtnLeftRelease()
    {
        isGoingLeft = false;
    }
    public void BtnRightPress()
    {
        isGoingRight = true;
    }
    public void BtnRightRelease()
    {
        isGoingRight = false;
    }
    public void TouchMove()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            //Debug.Log("xfbhdfcgfn" + transform.position.y);
            float half = Screen.width / 2;
            if (t.position.x > half)
            {
                transform.position = new Vector2(transform.position.x+0.05f, transform.position.y);
            }
            else if (t.position.x < half)
            {
                transform.position = new Vector2(transform.position.x-0.05f, transform.position.y);
            }
        }
    }
    public void AccelerationMove()
    {
        if (Input.acceleration.x < -0.1f)
        {
            float pointx = Mathf.Clamp(transform.position.x - speed, -2f, 2f);
            transform.position = new Vector2(pointx, transform.position.y);
        }
        if (Input.acceleration.x > 0.1f)
        {
            float pointx = Mathf.Clamp(transform.position.x + speed, -2f, 2f);
            transform.position = new Vector2(pointx, transform.position.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            source.clip = clip1;
            source.Play();
            Destroy(collision.gameObject);
            PlayerPrefs.GetInt("score", 0);
            sc += 1;
            score.text = sc.ToString();
            PlayerPrefs.SetInt("score", sc);
        }
        if (collision.gameObject.tag == "CAR")
        {
            source.clip = clip2;
            source.Play();
            Destroy(GameObject.FindGameObjectWithTag("MyCar"));
            SceneManager.LoadScene("GameOver");
        }
    }
    public void pause()
    {
        Time.timeScale = 0;
    }
    public void play()
    {
        Time.timeScale = 1;
    }
    public void Back()
    {
        SceneManager.LoadScene("Garage");
    }
}
