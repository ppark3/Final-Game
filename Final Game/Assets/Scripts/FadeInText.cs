using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FadeInText : MonoBehaviour
{
    public TMP_Text m_TextComponent;
    public bool displayed;
    public float fadeTime;

    public Color fadeInColor;
    public Color fadeOutColor;

    // Start is called before the first frame update
    void Start()
    {
        displayed = false;
        m_TextComponent.color = fadeOutColor;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnEnable()
    {
        m_TextComponent = gameObject.GetComponent<TMP_Text>();
        StartCoroutine(FadeIn(m_TextComponent));
    }

    public IEnumerator FadeIn(TMP_Text textComponent)
    {
        if (textComponent.color != fadeInColor && !displayed)
        {
            fadeTime = 0.3f;
            for (float t = 0.0f; t < fadeTime; t += Time.deltaTime)
            {
                textComponent.color = Color.Lerp(fadeOutColor, fadeInColor, Mathf.Min(1, t / fadeTime));
                yield return null;
            }
            displayed = true;
        }
    }

    void Stop()
    {
        StopCoroutine(FadeIn(m_TextComponent));
        m_TextComponent.color = fadeInColor;
        displayed = true;
    }
}
