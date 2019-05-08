using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowFadeIn : MonoBehaviour
{
    public float fadeTime;
    public SpriteRenderer sr;

    public Color fadeInColor;
    public Color fadeOutColor;

    public bool fadedIn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        StartCoroutine(FadeIn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator FadeIn()
    {
        fadeTime = 1f;
        for (float t = 0.0f; t < fadeTime; t += Time.deltaTime)
        {
            sr.color = Color.Lerp(fadeOutColor, fadeInColor, Mathf.Min(1, t / fadeTime));
            yield return null;
        }
        sr.color = fadeInColor;
        fadedIn = true;
    }
}
