using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController9 : MonoBehaviour
{
    public int phase;

    public TMP_Text one;
    public TMP_Text two;
    public TMP_Text three;
    public TMP_Text four;
    public TMP_Text five;

    public ParticleSystem first;
    public ParticleSystem second;
    public ParticleSystem third;

    // Start is called before the first frame update
    void Start()
    {
        //GameManager.gameScene = 15;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameScene == 15)
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
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && two.GetComponent<ScrollText>().isTyping)
            {
                two.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && !two.GetComponent<ScrollText>().isTyping)
            {
                phase = 2;
            }
            if (phase == 2)
            {
                three.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 2 && three.GetComponent<SlamBehavior>().landed)
            {
                GameManager.gameScene = 18;
                SceneManager.LoadScene("Scene10");
            }
        }
        else if (GameManager.gameScene == 16)
        {
            if (phase == 0)
            {
                four.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && four.GetComponent<ScrollText>().isTyping)
            {
                four.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && !four.GetComponent<ScrollText>().isTyping)
            {
                phase = 1;
            }
            if (phase == 1)
            {
                two.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && two.GetComponent<ScrollText>().isTyping)
            {
                two.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && !two.GetComponent<ScrollText>().isTyping)
            {
                phase = 2;
            }
            if (phase == 2)
            {
                three.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 2 && three.GetComponent<SlamBehavior>().landed)
            {
                GameManager.gameScene = 18;
                SceneManager.LoadScene("Scene10");
            }
        }
        else if (GameManager.gameScene == 17)
        {
            if (phase == 0)
            {
                five.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && five.GetComponent<ScrollText>().isTyping)
            {
                five.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && !five.GetComponent<ScrollText>().isTyping)
            {
                GameManager.gameScene = 18;
                SceneManager.LoadScene("Scene10");
            }
        }
    }

    void Hit()
    {
        first.gameObject.SetActive(true);
        second.gameObject.SetActive(true);
        third.gameObject.SetActive(true);
        three.GetComponent<SlamBehavior>().landed = true;
    }
}
