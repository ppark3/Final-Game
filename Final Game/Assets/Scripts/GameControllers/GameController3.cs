using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController3 : MonoBehaviour
{
    public int phase;

    public TMP_Text one;
    public TMP_Text two;
    public TMP_Text three;
    public TMP_Text four;

    public TMP_Text five;
    public TMP_Text six; //well
    public TMP_Text seven; //screw
    public TMP_Text eight; //you
    public TMP_Text nine; //too
    public TMP_Text ten;

    public TMP_Text eleven;


    // Start is called before the first frame update
    void Start()
    {
        phase = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameScene == 3)
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
            if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && !four.GetComponent<ScrollText>().isTyping)
            {
                GameManager.gameScene = 6;
                SceneManager.LoadScene("Scene4");
            }
        }
        else if(GameManager.gameScene == 4)
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
                phase = 1;
            }
            if (phase == 1)
            {
                six.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && six.GetComponent<ScrollText>().isTyping)
            {
                six.GetComponent<ScrollText>().cancelTyping = true;
            }

            if (phase == 4)
            {
                nine.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 4)
            {
                five.gameObject.SetActive(false);
                six.gameObject.SetActive(false);
                seven.gameObject.SetActive(false);
                eight.gameObject.SetActive(false);
                nine.gameObject.SetActive(false);
                phase = 5;
            }

            if (phase == 3)
            {
                eight.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 3)
            {
                GameManager.screwYou = true;
                phase = 4;
            }

            if (phase == 2)
            {
                seven.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 2)
            {
                phase = 3;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && !six.GetComponent<ScrollText>().isTyping)
            {
                phase = 2;
            }
            if (phase == 5)
            {
                ten.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 5 && ten.GetComponent<ScrollText>().isTyping)
            {
                ten.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 5 && !ten.GetComponent<ScrollText>().isTyping)
            {
                GameManager.gameScene = 6;
                SceneManager.LoadScene("Scene4");
            }
        }
        else if (GameManager.gameScene == 5)
        {
            if (phase == 0)
            {
                eleven.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && !eleven.GetComponent<ScrollText>().isTyping)
            {
                GameManager.gameScene = 6;
                SceneManager.LoadScene("Scene4");
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && eleven.GetComponent<ScrollText>().isTyping)
            {
                eleven.GetComponent<ScrollText>().cancelTyping = true;
            }
        }
    }
}
