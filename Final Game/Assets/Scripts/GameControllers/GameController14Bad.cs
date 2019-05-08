using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController14Bad : MonoBehaviour
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

    public GameObject hey;

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
        if (Input.GetKeyDown(KeyCode.Space) && phase == 2 && three.GetComponent<ScrollText>().isTyping)
        {
            three.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 2 && !three.GetComponent<ScrollText>().isTyping)
        {
            phase = 3;
        }
        if (phase == 3)
        {
            four.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && four.GetComponent<ScrollText>().isTyping)
        {
            four.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (phase == 5 && Input.GetKeyDown(KeyCode.Space))
        {
            one.gameObject.SetActive(false);
            two.gameObject.SetActive(false);
            three.gameObject.SetActive(false);
            four.gameObject.SetActive(false);
            five.gameObject.SetActive(false);
            hey.SetActive(true);
            six.gameObject.SetActive(true);
            phase = 6;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && !four.GetComponent<ScrollText>().isTyping)
        {
            phase = 4;
        }
        if (phase == 4 && Input.GetKeyDown(KeyCode.Space))
        {
            five.gameObject.SetActive(true);
            phase = 5;
        }
        if (phase == 6 && Input.GetKeyDown(KeyCode.Space) && !six.GetComponent<ScrollText>().isTyping)
        {
            phase = 7;
            six.gameObject.SetActive(false);
        }
        if (phase == 7)
        {
            seven.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 7 && seven.GetComponent<ScrollText>().isTyping)
        {
            seven.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (phase == 11 && Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.gameScene = -1;
            SceneManager.LoadScene("GameOver2");
        }
        if (phase == 10 && Input.GetKeyDown(KeyCode.Space))
        {
            nine.gameObject.SetActive(false);
            ten.gameObject.SetActive(true);
            GameManager.uglyAsFuck = true;
            phase = 11;
        }
        if (phase == 9 && Input.GetKeyDown(KeyCode.Space))
        {
            eight.gameObject.SetActive(false);
            nine.gameObject.SetActive(true);
            phase = 10;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 7 && !seven.GetComponent<ScrollText>().isTyping)
        {
            phase = 8;
        }
        if (phase == 8 && Input.GetKeyDown(KeyCode.Space))
        {
            seven.gameObject.SetActive(false);
            eight.gameObject.SetActive(true);
            phase = 9;
        }
    }
}
