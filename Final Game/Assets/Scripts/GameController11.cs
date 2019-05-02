using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController11 : MonoBehaviour
{
    public int phase;

    public TMP_Text one;
    public TMP_Text two;
    public TMP_Text three;
    public TMP_Text four;

    // Start is called before the first frame update
    void Start()
    {
        //GameManager.gameScene = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameScene == 19)
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
                GameManager.gameScene = 22;
                SceneManager.LoadScene("Scene12");
            }
        }
        if (GameManager.gameScene == 20)
        {
            if (phase == 0)
            {
                two.gameObject.SetActive(true);
            }
            if (phase == 1)
            {
                three.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && two.GetComponent<ScrollText>().isTyping)
            {
                two.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (phase == 1 && Input.GetKeyDown(KeyCode.Space))
            {
                GameManager.gameScene = 22;
                SceneManager.LoadScene("Scene12");
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && !two.GetComponent<ScrollText>().isTyping)
            {
                phase = 1;
            }
        }
        if (GameManager.gameScene == 21)
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
                GameManager.gameScene = 22;
                SceneManager.LoadScene("Scene12");
            }
        }
    }
}
