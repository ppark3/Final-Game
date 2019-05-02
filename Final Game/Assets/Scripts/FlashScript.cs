using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashScript : MonoBehaviour
{
    public float fadeTime;
    public SpriteRenderer sr;

    public Color fadeInColor;
    public Color fadeOutColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnEnable()
    {
        StartCoroutine(Flash());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Flash()
    {
        fadeTime = 0.1f;
        for (float t = 0.0f; t < fadeTime; t += Time.deltaTime)
        {
            sr.color = Color.Lerp(fadeOutColor, fadeInColor, Mathf.Min(1, t / fadeTime));
            yield return null;
        }
        for (float t = 0.0f; t < fadeTime; t += Time.deltaTime)
        {
            sr.color = Color.Lerp(fadeInColor, fadeOutColor, Mathf.Min(1, t / fadeTime));
            yield return null;
        }
        sr.color = fadeOutColor;
    }
}
