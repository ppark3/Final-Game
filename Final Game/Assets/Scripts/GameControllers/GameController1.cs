using System.Collections; 
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController1 : MonoBehaviour
{
    public int phase;

    public float assistTimer;
    public TMP_Text one;
    public TMP_Text two;
    public TMP_Text two5;
    public TMP_Text three;
    public TMP_Text three5;
    public TMP_Text four;
    public TMP_Text four25;
    public TMP_Text four5;
    public TMP_Text four75;

    // Start is called before the first frame update
    void Start()
    {
        phase = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (phase == 0)
        {
            one.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && !one.GetComponent<ScrollText>().isTyping)
        {
            one.gameObject.SetActive(false);
            phase = 1;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && one.GetComponent<ScrollText>().isTyping)
        {
            one.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (phase == 1)
        {
            two.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && two.GetComponent<ScrollText>().isTyping)
        {
            two.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (phase == 1 && two.GetComponent<ScrollText>().displayed)
        {
            assistTimer += Time.deltaTime;
            if (assistTimer > 0.5f)
            {
                two5.gameObject.SetActive(true);
                assistTimer = 0.0f;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && two5.GetComponent<FadeInText>().displayed)
        {
            two.gameObject.SetActive(false);
            two5.gameObject.SetActive(false);
            assistTimer = 0.0f;
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
        if (phase == 2 && three.GetComponent<ScrollText>().displayed)
        {
            assistTimer += Time.deltaTime;
            if (assistTimer > 0.5f )
            {
                three5.gameObject.SetActive(true);
                assistTimer = 0.0f;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 2 && three5.GetComponent<FadeInText>().displayed)
        {
            three.gameObject.SetActive(false);
            three5.gameObject.SetActive(false);
            assistTimer = 0.0f;
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
        if (phase == 3 && four.GetComponent<ScrollText>().displayed && !four25.gameObject.activeSelf)
        {
            assistTimer += Time.deltaTime;
            if (assistTimer > 0.5f)
            {
                four25.gameObject.SetActive(true);
                assistTimer = 0.0f;
            }
        }
        if (phase == 3 && four25.GetComponent<FadeInText>().displayed && !four5.gameObject.activeSelf)
        {
            assistTimer += Time.deltaTime;
            if (assistTimer > 0.2f)
            {
                four5.gameObject.SetActive(true);
                assistTimer = 0.0f;
            }
        }
        if (phase == 3 && four5.GetComponent<FadeInText>().displayed)
        {
            assistTimer += Time.deltaTime;
            if (assistTimer > 0.2f)
            {
                four75.gameObject.SetActive(true);
                assistTimer = 0.0f;
            }
        }
        if (phase == 3 && four75.gameObject.activeSelf)
        {
            assistTimer += Time.deltaTime;
            if (assistTimer > 0.2f)
            {
                StartCoroutine(FlashOut());
                assistTimer = 0.0f;
                phase = 4;
            }
        }
    }

    IEnumerator FlashOut()
    {
        yield return new WaitForSeconds(0.5f);
        four.gameObject.SetActive(false);
        four25.gameObject.SetActive(false);
        four5.gameObject.SetActive(false);
        four75.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        four.gameObject.SetActive(true);
        four25.gameObject.SetActive(true);
        four5.gameObject.SetActive(true);
        four75.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        four.gameObject.SetActive(false);
        four25.gameObject.SetActive(false);
        four5.gameObject.SetActive(false);
        four75.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        four.gameObject.SetActive(true);
        four25.gameObject.SetActive(true);
        four5.gameObject.SetActive(true);
        four75.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.15f);
        four.gameObject.SetActive(false);
        four25.gameObject.SetActive(false);
        four5.gameObject.SetActive(false);
        four75.gameObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        GameManager.gameScene = 1;
        SceneManager.LoadScene("Scene2");
    }
}
