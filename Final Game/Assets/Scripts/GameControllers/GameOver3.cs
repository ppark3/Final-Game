using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver3 : MonoBehaviour
{
    public int phase;

    public GameObject redBlanket;
    public GameObject gameOver;
    public GameObject hider;

    public TMP_Text one;
    public TMP_Text two;
    public TMP_Text three;
    public TMP_Text four;
    public TMP_Text five;
    public TMP_Text six;
    public TMP_Text seven;
    public TMP_Text eight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (phase == 0)
        {
            one.gameObject.SetActive(true);
        }
        if (phase == 0 && Input.GetKeyDown(KeyCode.Space) && one.GetComponent<FadeInText>().displayed)
        {
            phase = 1;
            two.gameObject.SetActive(true);
        }
        if (phase == 2 && Input.GetKeyDown(KeyCode.Space) && !three.GetComponent<AppearText>().reached2)
        {
            three.GetComponent<AppearText>().finish = true;
        }
        if (phase == 1 && Input.GetKeyDown(KeyCode.Space) && two.GetComponent<FadeInText>().displayed)
        {
            phase = 2;
            one.gameObject.SetActive(false);
            two.gameObject.SetActive(false);
            hider.gameObject.SetActive(true);
            three.gameObject.SetActive(true);
        }
        if (phase == 2 && Input.GetKeyDown(KeyCode.Space) && three.GetComponent<AppearText>().reached2)
        {
            four.gameObject.SetActive(true);
            phase = 3;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && four.GetComponent<ScrollText>().isTyping)
        {
            four.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && !four.GetComponent<ScrollText>().isTyping)
        {
            phase = 4;
        }
        if (phase == 5 && Input.GetKeyDown(KeyCode.Space))
        {
            three.gameObject.SetActive(false);
            four.gameObject.SetActive(false);
            six.gameObject.SetActive(true);
            phase = 6;
        }
        if (phase == 4 && Input.GetKeyDown(KeyCode.Space))
        {
            phase = 5;
            //three.gameObject.SetActive(true);
            GameManager.stab = true;
            redBlanket.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 6 && six.GetComponent<FadeInText>().displayed)
        {
            phase = 7;
        }
        if (phase == 7)
        {
            gameOver.SetActive(true);
            GameManager.playGameOverSong = true;
            phase = 8;
        }
        if (phase == 8 && gameOver.GetComponent<SlowFadeIn>().fadedIn)
        {
            seven.gameObject.SetActive(true);
            phase = 9;
        }

        if (seven.GetComponent<SlowScroll>().displayed)
        {
            eight.gameObject.SetActive(true);
        }

        if (phase == 9 && Input.GetKeyDown(KeyCode.R))
        {
            GameManager.gameScene = 0;
            SceneManager.LoadScene("Title Screen");
        }
    }
}
