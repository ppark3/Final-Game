using System.Collections;  
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Begin : MonoBehaviour
{
    public Text title;
    public TextMesh one;
    public TextMesh two;
    public TextMesh three;
    public TextMesh four;
    public TextMesh five;
    public TextMesh six;
    public TextMesh seven;
    public TextMesh eight;
    public TextMesh nine;
    public TextMesh ten;
    public TextMesh eleven;
    public TextMesh twelve;
    public TextMesh thirteen;
    public TextMesh fourteen;
    public TextMesh fifteen;
    public TextMesh sixteen;

    public float fadeTime;
    public Color fadeOutColor;
    public bool go;             // starts Fade() when true;
    public bool chill;          // keeps Fade() from happening every time Update runs

    public AudioClip introSong;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        fadeOutColor = Color.clear;
        fadeTime = 3;

        audioSource.clip = introSong;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            go = true;
        }

        if (title.color == fadeOutColor)
        {
            SceneManager.LoadScene("Scene1");
        }

        if (go && !chill)
        {
            StartCoroutine(FadeText());
            chill = true;
        }
    }

    private IEnumerator FadeText()
    {
        for (float t = 0.0f; t < fadeTime; t += Time.deltaTime)
        {
            title.color = Color.Lerp(title.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            one.color = Color.Lerp(one.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            two.color = Color.Lerp(two.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            three.color = Color.Lerp(three.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            four.color = Color.Lerp(four.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            five.color = Color.Lerp(five.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            six.color = Color.Lerp(six.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            seven.color = Color.Lerp(seven.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            eight.color = Color.Lerp(eight.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            nine.color = Color.Lerp(nine.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            ten.color = Color.Lerp(ten.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            eleven.color = Color.Lerp(eleven.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            twelve.color = Color.Lerp(twelve.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            thirteen.color = Color.Lerp(thirteen.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            fourteen.color = Color.Lerp(fourteen.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            fifteen.color = Color.Lerp(fifteen.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            sixteen.color = Color.Lerp(sixteen.color, fadeOutColor, Mathf.Min(1, t / fadeTime));
            yield return null;
        }

    }
}
