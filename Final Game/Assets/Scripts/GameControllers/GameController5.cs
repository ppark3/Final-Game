using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController5 : MonoBehaviour
{
    public int phase;

    public TMP_Text one;
    public TMP_Text two;
    public TMP_Text three;
    public TMP_Text four;

    public TMP_Text five;
    public TMP_Text six; 
    public TMP_Text seven;
    public TMP_Text eight; 
    public TMP_Text nine; 

    public TMP_Text ten;

    // Start is called before the first frame update
    void Start()
    {
        phase = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameScene == 7)
        {
            if (phase == 0)
            {
                one.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && one.GetComponent<ScrollText>().isTyping)
            {
                one.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && !one.GetComponent<ScrollText>().isTyping)
            {
                phase = 1;
            }
            if (phase == 1)
            {
                two.gameObject.SetActive(true);
                three.gameObject.SetActive(true);
                four.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && four.GetComponent<ScrollText>().isTyping)
            {
                four.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && !four.GetComponent<ScrollText>().isTyping)
            {
                GameManager.gameScene = 10;
                SceneManager.LoadScene("Scene6");
            }
        }
        else if (GameManager.gameScene == 8)
        {
            if (phase == 0)
            {
                five.gameObject.SetActive(true);
            }
            if (phase == 4)
            {
                nine.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 4 && nine.GetComponent<ScrollText>().isTyping)
            {
                nine.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 4 && !nine.GetComponent<ScrollText>().isTyping)
            {
                GameManager.gameScene = 10;
                SceneManager.LoadScene("Scene6");
            }
            if (phase == 3)
            {
                eight.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 3)
            {
                phase = 4;
            }
            if (phase == 2)
            {
                seven.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 2)
            {
                GameManager.fuckYou = true;
                phase = 3;
            }
            if (phase == 1)
            {
                six.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 1)
            {
                phase = 2;
            }/*
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && five.GetComponent<ScrollText>().isTyping)
            {
                five.GetComponent<ScrollText>().cancelTyping = true;
            }*/
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 /*&& !five.GetComponent<ScrollText>().isTyping*/)
            {
                phase = 1;
            }
        }
        else if (GameManager.gameScene == 9)
        {
            if (phase == 0)
            {
                ten.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && ten.GetComponent<ScrollText>().isTyping)
            {
                ten.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && !ten.GetComponent<ScrollText>().isTyping)
            {
                GameManager.gameScene = 10;
                SceneManager.LoadScene("Scene6");
            }
        }
    }
}
