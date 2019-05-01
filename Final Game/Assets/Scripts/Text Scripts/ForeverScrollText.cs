using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ForeverScrollText : MonoBehaviour
{
    public TMP_Text m_TextComponent;
    public bool displayed;
    public bool isTyping;
    public bool cancelTyping;
    public bool done = false;

    // Start is called before the first frame update
    void Start()
    {
        displayed = false;
        cancelTyping = false;
    }

    void Awake()
    {
        m_TextComponent = gameObject.GetComponent<TMP_Text>();
        StartCoroutine(RevealCharacters(m_TextComponent));
    }

    // Update is called once per frame
    void Update()
    {
        if (done)
        {
            StartCoroutine(RevealCharacters(m_TextComponent));
        }
    }

    IEnumerator RevealCharacters(TMP_Text textComponent)
    {
        done = false;
        textComponent.ForceMeshUpdate();

        TMP_TextInfo textInfo = textComponent.textInfo;

        int totalVisibleCharacters = textInfo.characterCount; // Get # of Visible Character in text object
        int visibleCount = 0;
        isTyping = true;

        while (!displayed && !cancelTyping)
        {
            if (visibleCount > totalVisibleCharacters)
            {
                displayed = true;
                isTyping = false;
                yield return null;
            }

            textComponent.maxVisibleCharacters = visibleCount; // How many characters should TextMeshPro display?

            visibleCount += 1;

            yield return new WaitForSeconds(0.05f);
        }
        textComponent.maxVisibleCharacters = totalVisibleCharacters;
        displayed = true;
        isTyping = false;
        done = true;
        displayed = false;
        yield return null;
    }
}
